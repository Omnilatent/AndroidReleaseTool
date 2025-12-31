
namespace BundleToolGUI
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
            this.tabMain.SuspendLayout();
            this.tabAabToPhone.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAabToPhone);
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
            this.txtAabPath.Location = new System.Drawing.Point(162, 3);
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
            this.txtOutputFolder.Location = new System.Drawing.Point(162, 38);
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
            this.ResumeLayout(false);

        }

        #endregion
    }
}

