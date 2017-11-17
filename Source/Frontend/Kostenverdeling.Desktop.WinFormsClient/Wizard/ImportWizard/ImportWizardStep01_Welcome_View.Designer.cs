namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    partial class ImportWizardStep01_Welcome_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportWizardStep01_Welcome_View));
            this.uxInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxInfo
            // 
            this.uxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxInfo.Location = new System.Drawing.Point(0, 0);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(750, 400);
            this.uxInfo.TabIndex = 0;
            this.uxInfo.Text = resources.GetString("uxInfo.Text");
            // 
            // ImportWizardStep01_Welcome_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxInfo);
            this.Name = "ImportWizardStep01_Welcome_View";
            this.Size = new System.Drawing.Size(750, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uxInfo;
    }
}
