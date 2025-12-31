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

namespace BundleToolGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnBrowseAab.Click += new System.EventHandler(this.btnBrowseAab_Click);
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
        }

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

            string aabPath = txtAabPath.Text;
            string outputDir = txtOutputFolder.Text;

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            string aabName = Path.GetFileNameWithoutExtension(aabPath);
            string apksPath = Path.Combine(outputDir, aabName + ".apks");

            bool needRebuild = true;

            if (File.Exists(apksPath))
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
                    txtLog.AppendText("AAB was updated. Rebuilding APKs.\r\n");
                }
            }
            else
            {
                txtLog.AppendText("No APKs found. Building.\r\n");
            }

            if (needRebuild)
            {
                await RunCommandAsync(
                    "-jar \"" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bundletool.jar") + "\" build-apks --overwrite " +
                    "--bundle=\"" + aabPath + "\" " +
                    "--output=\"" + apksPath + "\""
                );
            }

            await RunCommandAsync(
                "-jar \"" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bundletool.jar") + "\" install-apks " +
                "--apks=\"" + apksPath + "\""
            );

            txtLog.AppendText("Install completed successfully.\r\n");
        }
    }
}
