
namespace AndroidReleaseTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Keystore Base64

        private System.Windows.Forms.TabPage tabKeystoreBase64;

        private System.Windows.Forms.TableLayoutPanel tableKeystore;

        private System.Windows.Forms.Label lblKeystore;
        private System.Windows.Forms.TextBox txtKeystorePath;
        private System.Windows.Forms.Button btnBrowseKeystore;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.Button btnCopyBase64;

        #endregion

        #region Windows Form Designer generated code
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAabToPhone;

        private System.Windows.Forms.TableLayoutPanel tableLayout;

        private System.Windows.Forms.Label lblAab;
        private System.Windows.Forms.TextBox txtAabPath;
        private System.Windows.Forms.Button btnBrowseAab;

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnBrowseOutput;

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.TextBox txtLog;

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAabToPhone = new System.Windows.Forms.TabPage();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblAab = new System.Windows.Forms.Label();
            this.txtAabPath = new System.Windows.Forms.TextBox();
            this.btnBrowseAab = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabKeystoreBase64 = new System.Windows.Forms.TabPage();
            this.tableKeystore = new System.Windows.Forms.TableLayoutPanel();
            this.lblKeystore = new System.Windows.Forms.Label();
            this.txtKeystorePath = new System.Windows.Forms.TextBox();
            this.btnBrowseKeystore = new System.Windows.Forms.Button();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.btnCopyBase64 = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabAabToPhone.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.tabKeystoreBase64.SuspendLayout();
            this.tableKeystore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAabToPhone);
            this.tabMain.Controls.Add(this.tabKeystoreBase64);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(800, 500);
            this.tabMain.TabIndex = 0;
            // 
            // tabAabToPhone
            // 
            this.tabAabToPhone.Controls.Add(this.tableLayout);
            this.tabAabToPhone.Location = new System.Drawing.Point(4, 25);
            this.tabAabToPhone.Name = "tabAabToPhone";
            this.tabAabToPhone.Padding = new System.Windows.Forms.Padding(10);
            this.tabAabToPhone.Size = new System.Drawing.Size(792, 471);
            this.tabAabToPhone.TabIndex = 0;
            this.tabAabToPhone.Text = "AAB to phone";
            this.tabAabToPhone.UseVisualStyleBackColor = true;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayout.Controls.Add(this.lblAab, 0, 0);
            this.tableLayout.Controls.Add(this.txtAabPath, 1, 0);
            this.tableLayout.Controls.Add(this.btnBrowseAab, 2, 0);
            this.tableLayout.Controls.Add(this.lblOutput, 0, 1);
            this.tableLayout.Controls.Add(this.txtOutputFolder, 1, 1);
            this.tableLayout.Controls.Add(this.btnBrowseOutput, 2, 1);
            this.tableLayout.Controls.Add(this.btnInstall, 0, 2);
            this.tableLayout.Controls.Add(this.txtLog, 0, 4);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(10, 10);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 5;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(772, 451);
            this.tableLayout.TabIndex = 0;
            // 
            // lblAab
            // 
            this.lblAab.Location = new System.Drawing.Point(3, 0);
            this.lblAab.Name = "lblAab";
            this.lblAab.Size = new System.Drawing.Size(100, 23);
            this.lblAab.TabIndex = 0;
            this.lblAab.Text = "AAB file";
            this.lblAab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAabPath
            // 
            this.txtAabPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAabPath.Location = new System.Drawing.Point(162, 6);
            this.txtAabPath.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtAabPath.Name = "txtAabPath";
            this.txtAabPath.ReadOnly = true;
            this.txtAabPath.Size = new System.Drawing.Size(507, 22);
            this.txtAabPath.TabIndex = 1;
            // 
            // btnBrowseAab
            // 
            this.btnBrowseAab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseAab.Location = new System.Drawing.Point(675, 3);
            this.btnBrowseAab.Name = "btnBrowseAab";
            this.btnBrowseAab.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseAab.TabIndex = 2;
            this.btnBrowseAab.Text = "Browse...";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(3, 35);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(151, 23);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output APKs folder";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutputFolder.Location = new System.Drawing.Point(162, 41);
            this.txtOutputFolder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(507, 22);
            this.txtOutputFolder.TabIndex = 4;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseOutput.Location = new System.Drawing.Point(675, 38);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse...";
            // 
            // btnInstall
            // 
            this.tableLayout.SetColumnSpan(this.btnInstall, 3);
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstall.Location = new System.Drawing.Point(3, 73);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(766, 44);
            this.btnInstall.TabIndex = 6;
            this.btnInstall.Text = "Build and install";
            // 
            // txtLog
            // 
            this.tableLayout.SetColumnSpan(this.txtLog, 3);
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 133);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(766, 315);
            this.txtLog.TabIndex = 7;
            // 
            // tabKeystoreBase64
            // 
            this.tabKeystoreBase64.Controls.Add(this.tableKeystore);
            this.tabKeystoreBase64.Location = new System.Drawing.Point(4, 25);
            this.tabKeystoreBase64.Name = "tabKeystoreBase64";
            this.tabKeystoreBase64.Padding = new System.Windows.Forms.Padding(10);
            this.tabKeystoreBase64.Size = new System.Drawing.Size(792, 471);
            this.tabKeystoreBase64.TabIndex = 1;
            this.tabKeystoreBase64.Text = "Keystore Base64";
            this.tabKeystoreBase64.UseVisualStyleBackColor = true;
            // 
            // tableKeystore
            // 
            this.tableKeystore.ColumnCount = 3;
            this.tableKeystore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableKeystore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableKeystore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableKeystore.Controls.Add(this.lblKeystore, 0, 0);
            this.tableKeystore.Controls.Add(this.txtKeystorePath, 1, 0);
            this.tableKeystore.Controls.Add(this.btnBrowseKeystore, 2, 0);
            this.tableKeystore.Controls.Add(this.txtBase64, 0, 3);
            this.tableKeystore.Controls.Add(this.btnCopyBase64, 0, 4);
            this.tableKeystore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableKeystore.Location = new System.Drawing.Point(10, 10);
            this.tableKeystore.Name = "tableKeystore";
            this.tableKeystore.RowCount = 5;
            this.tableKeystore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableKeystore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableKeystore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableKeystore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableKeystore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableKeystore.Size = new System.Drawing.Size(772, 451);
            this.tableKeystore.TabIndex = 0;
            // 
            // lblKeystore
            // 
            this.lblKeystore.Location = new System.Drawing.Point(3, 0);
            this.lblKeystore.Name = "lblKeystore";
            this.lblKeystore.Size = new System.Drawing.Size(100, 23);
            this.lblKeystore.TabIndex = 0;
            this.lblKeystore.Text = "Keystore file";
            this.lblKeystore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKeystorePath
            // 
            this.txtKeystorePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeystorePath.Location = new System.Drawing.Point(123, 3);
            this.txtKeystorePath.Name = "txtKeystorePath";
            this.txtKeystorePath.ReadOnly = true;
            this.txtKeystorePath.Size = new System.Drawing.Size(526, 22);
            this.txtKeystorePath.TabIndex = 1;
            // 
            // btnBrowseKeystore
            // 
            this.btnBrowseKeystore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseKeystore.Location = new System.Drawing.Point(655, 3);
            this.btnBrowseKeystore.Name = "btnBrowseKeystore";
            this.btnBrowseKeystore.Size = new System.Drawing.Size(114, 29);
            this.btnBrowseKeystore.TabIndex = 2;
            this.btnBrowseKeystore.Text = "Browse...";
            // 
            // txtBase64
            // 
            this.tableKeystore.SetColumnSpan(this.txtBase64, 3);
            this.txtBase64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64.Location = new System.Drawing.Point(3, 93);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ReadOnly = true;
            this.txtBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64.Size = new System.Drawing.Size(766, 289);
            this.txtBase64.TabIndex = 4;
            // 
            // btnCopyBase64
            // 
            this.tableKeystore.SetColumnSpan(this.btnCopyBase64, 3);
            this.btnCopyBase64.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyBase64.Location = new System.Drawing.Point(3, 388);
            this.btnCopyBase64.Name = "btnCopyBase64";
            this.btnCopyBase64.Size = new System.Drawing.Size(766, 60);
            this.btnCopyBase64.TabIndex = 5;
            this.btnCopyBase64.Text = "Copy Base64";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "BundleTool GUI";
            this.tabMain.ResumeLayout(false);
            this.tabAabToPhone.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.tabKeystoreBase64.ResumeLayout(false);
            this.tableKeystore.ResumeLayout(false);
            this.tableKeystore.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

