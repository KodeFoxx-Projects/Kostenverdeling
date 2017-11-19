namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    partial class ImportWizardStep03_CalculationsOverview_View
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
            this.uxInfo = new System.Windows.Forms.Label();
            this.uxTabContainer = new System.Windows.Forms.TabControl();
            this.uxProgressPanel = new System.Windows.Forms.Panel();
            this.uxProgressInfo = new System.Windows.Forms.Label();
            this.uxProgressBar = new System.Windows.Forms.ProgressBar();
            this.uxBezigMetVerwerkenGegevens = new System.Windows.Forms.Label();
            this.uxProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxInfo
            // 
            this.uxInfo.Location = new System.Drawing.Point(0, 2);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(750, 29);
            this.uxInfo.TabIndex = 12;
            this.uxInfo.Text = "Overzicht van de berekeningen opgesplitst per bedrijf en project.";
            // 
            // uxTabContainer
            // 
            this.uxTabContainer.Location = new System.Drawing.Point(3, 34);
            this.uxTabContainer.Name = "uxTabContainer";
            this.uxTabContainer.SelectedIndex = 0;
            this.uxTabContainer.Size = new System.Drawing.Size(744, 363);
            this.uxTabContainer.TabIndex = 13;
            this.uxTabContainer.Visible = false;
            // 
            // uxProgressPanel
            // 
            this.uxProgressPanel.Controls.Add(this.uxProgressInfo);
            this.uxProgressPanel.Controls.Add(this.uxProgressBar);
            this.uxProgressPanel.Controls.Add(this.uxBezigMetVerwerkenGegevens);
            this.uxProgressPanel.Location = new System.Drawing.Point(2, 34);
            this.uxProgressPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxProgressPanel.Name = "uxProgressPanel";
            this.uxProgressPanel.Size = new System.Drawing.Size(740, 358);
            this.uxProgressPanel.TabIndex = 14;
            // 
            // uxProgressInfo
            // 
            this.uxProgressInfo.AutoSize = true;
            this.uxProgressInfo.Location = new System.Drawing.Point(10, 18);
            this.uxProgressInfo.Name = "uxProgressInfo";
            this.uxProgressInfo.Size = new System.Drawing.Size(193, 13);
            this.uxProgressInfo.TabIndex = 16;
            this.uxProgressInfo.Text = "Bezig met berekeningen en simulaties...";
            // 
            // uxProgressBar
            // 
            this.uxProgressBar.Location = new System.Drawing.Point(13, 34);
            this.uxProgressBar.Name = "uxProgressBar";
            this.uxProgressBar.Size = new System.Drawing.Size(721, 23);
            this.uxProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.uxProgressBar.TabIndex = 15;
            // 
            // uxBezigMetVerwerkenGegevens
            // 
            this.uxBezigMetVerwerkenGegevens.AutoSize = true;
            this.uxBezigMetVerwerkenGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBezigMetVerwerkenGegevens.Location = new System.Drawing.Point(2, 1);
            this.uxBezigMetVerwerkenGegevens.Name = "uxBezigMetVerwerkenGegevens";
            this.uxBezigMetVerwerkenGegevens.Size = new System.Drawing.Size(90, 13);
            this.uxBezigMetVerwerkenGegevens.TabIndex = 14;
            this.uxBezigMetVerwerkenGegevens.Text = "Even geduld...";
            // 
            // ImportWizardStep03_CalculationsOverview_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxInfo);
            this.Controls.Add(this.uxProgressPanel);
            this.Controls.Add(this.uxTabContainer);
            this.MaximumSize = new System.Drawing.Size(750, 400);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "ImportWizardStep03_CalculationsOverview_View";
            this.Size = new System.Drawing.Size(750, 400);
            this.uxProgressPanel.ResumeLayout(false);
            this.uxProgressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uxInfo;
        private System.Windows.Forms.TabControl uxTabContainer;
        private System.Windows.Forms.Panel uxProgressPanel;
        private System.Windows.Forms.Label uxProgressInfo;
        private System.Windows.Forms.ProgressBar uxProgressBar;
        private System.Windows.Forms.Label uxBezigMetVerwerkenGegevens;
    }
}
