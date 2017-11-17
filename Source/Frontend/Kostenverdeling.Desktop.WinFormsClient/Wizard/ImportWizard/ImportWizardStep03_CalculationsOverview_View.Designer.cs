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
            this.uxInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(1000, 36);
            this.uxInfo.TabIndex = 12;
            this.uxInfo.Text = "Overzicht van de berekeningen opgesplitst per bedrijf en project.";
            // 
            // uxTabContainer
            // 
            this.uxTabContainer.Location = new System.Drawing.Point(4, 42);
            this.uxTabContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxTabContainer.Name = "uxTabContainer";
            this.uxTabContainer.SelectedIndex = 0;
            this.uxTabContainer.Size = new System.Drawing.Size(992, 447);
            this.uxTabContainer.TabIndex = 13;
            this.uxTabContainer.Visible = false;
            // 
            // uxProgressPanel
            // 
            this.uxProgressPanel.Controls.Add(this.uxProgressInfo);
            this.uxProgressPanel.Controls.Add(this.uxProgressBar);
            this.uxProgressPanel.Controls.Add(this.uxBezigMetVerwerkenGegevens);
            this.uxProgressPanel.Location = new System.Drawing.Point(3, 42);
            this.uxProgressPanel.Name = "uxProgressPanel";
            this.uxProgressPanel.Size = new System.Drawing.Size(986, 440);
            this.uxProgressPanel.TabIndex = 14;
            // 
            // uxProgressInfo
            // 
            this.uxProgressInfo.AutoSize = true;
            this.uxProgressInfo.Location = new System.Drawing.Point(13, 22);
            this.uxProgressInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxProgressInfo.Name = "uxProgressInfo";
            this.uxProgressInfo.Size = new System.Drawing.Size(259, 17);
            this.uxProgressInfo.TabIndex = 16;
            this.uxProgressInfo.Text = "Bezig met berekeningen en simulaties...";
            // 
            // uxProgressBar
            // 
            this.uxProgressBar.Location = new System.Drawing.Point(17, 42);
            this.uxProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.uxProgressBar.Name = "uxProgressBar";
            this.uxProgressBar.Size = new System.Drawing.Size(961, 28);
            this.uxProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.uxProgressBar.TabIndex = 15;
            // 
            // uxBezigMetVerwerkenGegevens
            // 
            this.uxBezigMetVerwerkenGegevens.AutoSize = true;
            this.uxBezigMetVerwerkenGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBezigMetVerwerkenGegevens.Location = new System.Drawing.Point(2, 1);
            this.uxBezigMetVerwerkenGegevens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxBezigMetVerwerkenGegevens.Name = "uxBezigMetVerwerkenGegevens";
            this.uxBezigMetVerwerkenGegevens.Size = new System.Drawing.Size(113, 17);
            this.uxBezigMetVerwerkenGegevens.TabIndex = 14;
            this.uxBezigMetVerwerkenGegevens.Text = "Even geduld...";
            // 
            // ImportWizardStep03_CalculationsOverview_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxInfo);
            this.Controls.Add(this.uxProgressPanel);
            this.Controls.Add(this.uxTabContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 492);
            this.MinimumSize = new System.Drawing.Size(1000, 492);
            this.Name = "ImportWizardStep03_CalculationsOverview_View";
            this.Size = new System.Drawing.Size(1000, 492);
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
