using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidReleaseTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnBrowseAab.Click += new System.EventHandler(this.btnBrowseAab_Click);
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            btnBrowseKeystoreAab.Click += BtnBrowseKeystoreAab_Click;

            WireKeystoreBase64Events();
        }

        #region AAB install
        private Task RunCommandAsync(string arguments)
        {
            return Task.Run(() =>
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "java",
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = psi;

                    process.OutputDataReceived += (s, e) =>
                    {
                        if (e.Data != null)
                        {
                            Invoke((MethodInvoker)(() =>
                            {
                                txtLog.AppendText(e.Data + Environment.NewLine);
                            }));
                        }
                    };

                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (e.Data != null)
                        {
                            Invoke((MethodInvoker)(() =>
                            {
                                txtLog.AppendText("[ERR] " + e.Data + Environment.NewLine);
                            }));
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();
                }
            });
        }

        private void btnBrowseAab_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Android App Bundle (*.aab)|*.aab";
                dialog.Title = "Select AAB file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtAabPath.Text = dialog.FileName;

                    // Get folder containing the AAB
                    string aabDirectory = Path.GetDirectoryName(dialog.FileName);

                    // Create APKs subfolder path
                    string apksFolder = Path.Combine(aabDirectory, "APKs");

                    // Auto set output folder only if empty
                    if (string.IsNullOrEmpty(txtOutputFolder.Text))
                    {
                        txtOutputFolder.Text = apksFolder;
                    }
                }
            }
        }


        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select output folder";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAabPath.Text) ||
                string.IsNullOrWhiteSpace(txtOutputFolder.Text))
            {
                MessageBox.Show("Please select AAB file and output folder.");
                return;
            }

            txtLog.Clear();

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string bundleToolPath = Path.Combine(baseDir, "bundletool.jar");

            string aabPath = txtAabPath.Text;
            string outputDir = txtOutputFolder.Text;

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            string aabName = Path.GetFileNameWithoutExtension(aabPath);
            string apksPath = Path.Combine(outputDir, aabName + ".apks");

            bool cleanBuild = chkCleanBuildAab.Checked;
            bool needRebuild = cleanBuild;

            if (File.Exists(apksPath) && !cleanBuild)
            {
                DateTime aabTime = File.GetLastWriteTimeUtc(aabPath);
                DateTime apksTime = File.GetLastWriteTimeUtc(apksPath);

                if (apksTime >= aabTime)
                {
                    needRebuild = false;
                    txtLog.AppendText("Existing APKs are up to date. Reusing.\r\n");
                }
                else
                {
                    txtLog.AppendText("AAB updated. Rebuilding APKs.\r\n");
                }
            }
            else if (cleanBuild)
            {
                txtLog.AppendText("Clean build enabled. Forcing rebuild.\r\n");
            }
            else
            {
                txtLog.AppendText("No APKs found. Building.\r\n");
            }

            // Resolve keystore info
            string keystorePath = txtKeystorePathAab.Text;
            string keystoreAlias = txtKeystoreAliasAab.Text;
            string keystorePassword = txtKeystorePasswordAab.Text;
            string aliasPassword = txtAliasPasswordAab.Text;

            bool useDebugKey =
                string.IsNullOrWhiteSpace(keystorePath) &&
                string.IsNullOrWhiteSpace(keystoreAlias) &&
                string.IsNullOrWhiteSpace(keystorePassword) &&
                string.IsNullOrWhiteSpace(aliasPassword);

            if (useDebugKey)
            {
                keystorePath = Path.Combine(baseDir, "debug.keystore");
                keystoreAlias = "androiddebugkey";
                keystorePassword = "android";
                aliasPassword = "android";

                txtLog.AppendText("Using debug keystore.\r\n");
            }
            else
            {
                txtLog.AppendText("Using custom keystore.\r\n");
            }

            if (needRebuild)
            {
                string buildArgs =
                    "-jar \"" + bundleToolPath + "\" build-apks --overwrite " +
                    "--bundle=\"" + aabPath + "\" " +
                    "--output=\"" + apksPath + "\" " +
                    "--ks=\"" + keystorePath + "\" " +
                    "--ks-key-alias=\"" + keystoreAlias + "\" " +
                    "--ks-pass=pass:" + keystorePassword + " " +
                    "--key-pass=pass:" + aliasPassword;

                await RunCommandAsync(buildArgs);
            }

            await RunCommandAsync(
                "-jar \"" + bundleToolPath + "\" install-apks " +
                "--apks=\"" + apksPath + "\""
            );

            txtLog.AppendText("Install completed successfully.\r\n");
        }

        private void BtnBrowseKeystoreAab_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Keystore files (*.jks)|*.jks|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtKeystorePathAab.Text = dlg.FileName;
                }
            }
        }
        #endregion

        #region Keystore
        private void WireKeystoreBase64Events()
        {
            this.btnBrowseKeystore.Click += btnBrowseKeystore_Click;
            //this.btnGetBase64.Click += btnGetBase64_Click;
            this.btnCopyBase64.Click += btnCopyBase64_Click;
        }

        private void btnBrowseKeystore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Keystore files (*.jks;*.keystore)|*.jks;*.keystore|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtKeystorePath.Text = dialog.FileName;
                    GetBase64();
                }
            }
        }
        private void btnGetBase64_Click(object sender, EventArgs e)
        {
            GetBase64();
        }

        void GetBase64()
        {
            if (string.IsNullOrWhiteSpace(txtKeystorePath.Text) ||
                !File.Exists(txtKeystorePath.Text))
            {
                MessageBox.Show("Please select a valid keystore file.");
                return;
            }

            try
            {
                byte[] fileBytes = File.ReadAllBytes(txtKeystorePath.Text);
                string base64 = Convert.ToBase64String(fileBytes);

                txtBase64.Text = base64;
                Clipboard.SetText(base64);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to encode keystore.\n" + ex.Message);
            }
        }

        private void btnCopyBase64_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBase64.Text))
            {
                Clipboard.SetText(txtBase64.Text);
            }
        }

        #endregion

        private void tableLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
