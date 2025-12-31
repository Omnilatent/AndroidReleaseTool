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

            string apksPath = Path.Combine(
                txtOutputFolder.Text,
                "my_app.apks"
            );

            await RunCommandAsync(
                "-jar bundletool.jar build-apks --overwrite " +
                "--bundle=\"" + txtAabPath.Text + "\" " +
                "--output=\"" + apksPath + "\""
            );

            await RunCommandAsync(
                "-jar bundletool.jar install-apks " +
                "--apks=\"" + apksPath + "\""
            );
        }

    }
}
