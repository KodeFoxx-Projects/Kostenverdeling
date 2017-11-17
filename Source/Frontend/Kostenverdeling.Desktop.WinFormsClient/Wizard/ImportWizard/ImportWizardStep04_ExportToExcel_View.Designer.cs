namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    partial class ImportWizardStep04_ExportToExcel_View
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportWizardStep04_ExportToExcel_View));
            this.uxExcelFile = new System.Windows.Forms.TextBox();
            this.uxExcelFileLabel = new System.Windows.Forms.Label();
            this.uxInfo = new System.Windows.Forms.Label();
            this.uxBrowseExcelFile = new System.Windows.Forms.Button();
            this.uxBusyPanel = new System.Windows.Forms.Panel();
            this.uxProgressInfo = new System.Windows.Forms.Label();
            this.uxProgressBar = new System.Windows.Forms.ProgressBar();
            this.uxBezigMetVerwerkenGegevens = new System.Windows.Forms.Label();
            this.uxOkPanel = new System.Windows.Forms.Panel();
            this.uxExportAgain = new System.Windows.Forms.Button();
            this.uxOpenExportFolder = new System.Windows.Forms.Button();
            this.uxOkInfoText = new System.Windows.Forms.Label();
            this.uxOkInfo = new System.Windows.Forms.Label();
            this.uxBusyPanel.SuspendLayout();
            this.uxOkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxExcelFile
            // 
            this.uxExcelFile.Location = new System.Drawing.Point(20, 64);
            this.uxExcelFile.Margin = new System.Windows.Forms.Padding(4);
            this.uxExcelFile.Name = "uxExcelFile";
            this.uxExcelFile.ReadOnly = true;
            this.uxExcelFile.Size = new System.Drawing.Size(960, 22);
            this.uxExcelFile.TabIndex = 8;
            this.uxExcelFile.Text = "(geen locatie (map) geselecteerd)";
            // 
            // uxExcelFileLabel
            // 
            this.uxExcelFileLabel.AutoSize = true;
            this.uxExcelFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExcelFileLabel.Location = new System.Drawing.Point(4, 44);
            this.uxExcelFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxExcelFileLabel.Name = "uxExcelFileLabel";
            this.uxExcelFileLabel.Size = new System.Drawing.Size(201, 17);
            this.uxExcelFileLabel.TabIndex = 7;
            this.uxExcelFileLabel.Text = "Locatie EXCEL bestanden:";
            // 
            // uxInfo
            // 
            this.uxInfo.Location = new System.Drawing.Point(0, 0);
            this.uxInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(1000, 36);
            this.uxInfo.TabIndex = 6;
            this.uxInfo.Text = "Selecteer de locatie (map) waarin je de EXCEL bestanden wilt opslaan. Na de selec" +
    "tie zal het programma de bestanden genereren en je verwittigen wanneer het expor" +
    "teren afgerond is.";
            // 
            // uxBrowseExcelFile
            // 
            this.uxBrowseExcelFile.Location = new System.Drawing.Point(880, 94);
            this.uxBrowseExcelFile.Margin = new System.Windows.Forms.Padding(4);
            this.uxBrowseExcelFile.Name = "uxBrowseExcelFile";
            this.uxBrowseExcelFile.Size = new System.Drawing.Size(100, 28);
            this.uxBrowseExcelFile.TabIndex = 9;
            this.uxBrowseExcelFile.Text = "Bladeren...";
            this.uxBrowseExcelFile.UseVisualStyleBackColor = true;
            this.uxBrowseExcelFile.Click += new System.EventHandler(this.uxBrowseExcelFile_Click);
            // 
            // uxBusyPanel
            // 
            this.uxBusyPanel.Controls.Add(this.uxProgressInfo);
            this.uxBusyPanel.Controls.Add(this.uxProgressBar);
            this.uxBusyPanel.Controls.Add(this.uxBezigMetVerwerkenGegevens);
            this.uxBusyPanel.Location = new System.Drawing.Point(8, 132);
            this.uxBusyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.uxBusyPanel.Name = "uxBusyPanel";
            this.uxBusyPanel.Size = new System.Drawing.Size(988, 89);
            this.uxBusyPanel.TabIndex = 10;
            this.uxBusyPanel.Visible = false;
            // 
            // uxProgressInfo
            // 
            this.uxProgressInfo.AutoSize = true;
            this.uxProgressInfo.Location = new System.Drawing.Point(9, 20);
            this.uxProgressInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxProgressInfo.Name = "uxProgressInfo";
            this.uxProgressInfo.Size = new System.Drawing.Size(361, 17);
            this.uxProgressInfo.TabIndex = 13;
            this.uxProgressInfo.Text = "Bezig met exporteren van de berekeningen naar EXCEL";
            // 
            // uxProgressBar
            // 
            this.uxProgressBar.Location = new System.Drawing.Point(12, 41);
            this.uxProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.uxProgressBar.Name = "uxProgressBar";
            this.uxProgressBar.Size = new System.Drawing.Size(961, 28);
            this.uxProgressBar.TabIndex = 12;
            // 
            // uxBezigMetVerwerkenGegevens
            // 
            this.uxBezigMetVerwerkenGegevens.AutoSize = true;
            this.uxBezigMetVerwerkenGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBezigMetVerwerkenGegevens.Location = new System.Drawing.Point(-3, 0);
            this.uxBezigMetVerwerkenGegevens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxBezigMetVerwerkenGegevens.Name = "uxBezigMetVerwerkenGegevens";
            this.uxBezigMetVerwerkenGegevens.Size = new System.Drawing.Size(450, 17);
            this.uxBezigMetVerwerkenGegevens.TabIndex = 6;
            this.uxBezigMetVerwerkenGegevens.Text = "Bezig met exporteren naar EXCEL bestanden. Even geduld...";
            // 
            // uxOkPanel
            // 
            this.uxOkPanel.Controls.Add(this.uxExportAgain);
            this.uxOkPanel.Controls.Add(this.uxOpenExportFolder);
            this.uxOkPanel.Controls.Add(this.uxOkInfoText);
            this.uxOkPanel.Controls.Add(this.uxOkInfo);
            this.uxOkPanel.Location = new System.Drawing.Point(8, 229);
            this.uxOkPanel.Margin = new System.Windows.Forms.Padding(4);
            this.uxOkPanel.Name = "uxOkPanel";
            this.uxOkPanel.Size = new System.Drawing.Size(988, 259);
            this.uxOkPanel.TabIndex = 11;
            this.uxOkPanel.Visible = false;
            // 
            // uxExportAgain
            // 
            this.uxExportAgain.Location = new System.Drawing.Point(621, 75);
            this.uxExportAgain.Margin = new System.Windows.Forms.Padding(4);
            this.uxExportAgain.Name = "uxExportAgain";
            this.uxExportAgain.Size = new System.Drawing.Size(172, 28);
            this.uxExportAgain.TabIndex = 15;
            this.uxExportAgain.Text = "Opnieuw exporteren...";
            this.uxExportAgain.UseVisualStyleBackColor = true;
            // 
            // uxOpenExportFolder
            // 
            this.uxOpenExportFolder.Location = new System.Drawing.Point(800, 75);
            this.uxOpenExportFolder.Margin = new System.Windows.Forms.Padding(4);
            this.uxOpenExportFolder.Name = "uxOpenExportFolder";
            this.uxOpenExportFolder.Size = new System.Drawing.Size(172, 28);
            this.uxOpenExportFolder.TabIndex = 14;
            this.uxOpenExportFolder.Text = "Export map openen...";
            this.uxOpenExportFolder.UseVisualStyleBackColor = true;
            this.uxOpenExportFolder.Click += new System.EventHandler(this.uxOpenExportFolder_Click);
            // 
            // uxOkInfoText
            // 
            this.uxOkInfoText.AutoSize = true;
            this.uxOkInfoText.Location = new System.Drawing.Point(9, 20);
            this.uxOkInfoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxOkInfoText.MaximumSize = new System.Drawing.Size(963, 0);
            this.uxOkInfoText.Name = "uxOkInfoText";
            this.uxOkInfoText.Size = new System.Drawing.Size(956, 51);
            this.uxOkInfoText.TabIndex = 13;
            this.uxOkInfoText.Text = resources.GetString("uxOkInfoText.Text");
            // 
            // uxOkInfo
            // 
            this.uxOkInfo.AutoSize = true;
            this.uxOkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOkInfo.Location = new System.Drawing.Point(-3, 0);
            this.uxOkInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxOkInfo.Name = "uxOkInfo";
            this.uxOkInfo.Size = new System.Drawing.Size(154, 17);
            this.uxOkInfo.TabIndex = 6;
            this.uxOkInfo.Text = "Exporteren voltooid.";
            // 
            // ImportWizardStep04_ExportToExcel_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxOkPanel);
            this.Controls.Add(this.uxBusyPanel);
            this.Controls.Add(this.uxBrowseExcelFile);
            this.Controls.Add(this.uxExcelFile);
            this.Controls.Add(this.uxExcelFileLabel);
            this.Controls.Add(this.uxInfo);
            this.MaximumSize = new System.Drawing.Size(1000, 492);
            this.MinimumSize = new System.Drawing.Size(1000, 492);
            this.Name = "ImportWizardStep04_ExportToExcel_View";
            this.Size = new System.Drawing.Size(1000, 492);
            this.uxBusyPanel.ResumeLayout(false);
            this.uxBusyPanel.PerformLayout();
            this.uxOkPanel.ResumeLayout(false);
            this.uxOkPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox uxExcelFile;
        private System.Windows.Forms.Label uxExcelFileLabel;
        private System.Windows.Forms.Label uxInfo;
        private System.Windows.Forms.Button uxBrowseExcelFile;
        private System.Windows.Forms.Panel uxBusyPanel;
        private System.Windows.Forms.Label uxProgressInfo;
        private System.Windows.Forms.ProgressBar uxProgressBar;
        private System.Windows.Forms.Label uxBezigMetVerwerkenGegevens;
        private System.Windows.Forms.Panel uxOkPanel;
        private System.Windows.Forms.Label uxOkInfoText;
        private System.Windows.Forms.Label uxOkInfo;
        private System.Windows.Forms.Button uxOpenExportFolder;
        private System.Windows.Forms.Button uxExportAgain;
    }
}
