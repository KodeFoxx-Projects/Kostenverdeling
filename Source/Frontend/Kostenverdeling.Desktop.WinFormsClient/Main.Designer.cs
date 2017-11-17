namespace Kostenverdeling.Desktop.WinFormsClient
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uxWizardStepTitle = new System.Windows.Forms.Label();
            this.uxWizardStepViewHost = new System.Windows.Forms.Panel();
            this.uxWizardNext = new System.Windows.Forms.Button();
            this.uxWizardPrevious = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxReset = new System.Windows.Forms.Button();
            this.uxConfiguration = new System.Windows.Forms.Button();
            this.uxConfig = new System.Windows.Forms.Button();
            this.___contentBody.SuspendLayout();
            this.___footerBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ___contentBody
            // 
            this.___contentBody.Controls.Add(this.uxWizardStepViewHost);
            this.___contentBody.Controls.Add(this.uxWizardStepTitle);
            this.___contentBody.Margin = new System.Windows.Forms.Padding(5);
            this.___contentBody.Size = new System.Drawing.Size(1006, 526);
            // 
            // ___footerBody
            // 
            this.___footerBody.Controls.Add(this.uxConfig);
            this.___footerBody.Controls.Add(this.uxReset);
            this.___footerBody.Controls.Add(this.uxCancel);
            this.___footerBody.Controls.Add(this.uxWizardPrevious);
            this.___footerBody.Controls.Add(this.uxWizardNext);
            this.___footerBody.Location = new System.Drawing.Point(0, 616);
            this.___footerBody.Margin = new System.Windows.Forms.Padding(5);
            this.___footerBody.Size = new System.Drawing.Size(1028, 62);
            // 
            // ___headerBar
            // 
            this.___headerBar.Size = new System.Drawing.Size(1028, 66);
            // 
            // uxWizardStepTitle
            // 
            this.uxWizardStepTitle.AutoSize = true;
            this.uxWizardStepTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxWizardStepTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWizardStepTitle.Location = new System.Drawing.Point(0, 0);
            this.uxWizardStepTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxWizardStepTitle.Name = "uxWizardStepTitle";
            this.uxWizardStepTitle.Size = new System.Drawing.Size(199, 25);
            this.uxWizardStepTitle.TabIndex = 0;
            this.uxWizardStepTitle.Text = "%wizardStepTitle%";
            // 
            // uxWizardStepViewHost
            // 
            this.uxWizardStepViewHost.Location = new System.Drawing.Point(5, 28);
            this.uxWizardStepViewHost.Margin = new System.Windows.Forms.Padding(4);
            this.uxWizardStepViewHost.Name = "uxWizardStepViewHost";
            this.uxWizardStepViewHost.Size = new System.Drawing.Size(1000, 492);
            this.uxWizardStepViewHost.TabIndex = 1;
            // 
            // uxWizardNext
            // 
            this.uxWizardNext.Location = new System.Drawing.Point(916, 18);
            this.uxWizardNext.Margin = new System.Windows.Forms.Padding(4);
            this.uxWizardNext.Name = "uxWizardNext";
            this.uxWizardNext.Size = new System.Drawing.Size(100, 28);
            this.uxWizardNext.TabIndex = 0;
            this.uxWizardNext.Text = "Volgende >";
            this.uxWizardNext.UseVisualStyleBackColor = true;
            this.uxWizardNext.Click += new System.EventHandler(this.uxWizardNext_Click);
            // 
            // uxWizardPrevious
            // 
            this.uxWizardPrevious.Location = new System.Drawing.Point(808, 18);
            this.uxWizardPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.uxWizardPrevious.Name = "uxWizardPrevious";
            this.uxWizardPrevious.Size = new System.Drawing.Size(100, 28);
            this.uxWizardPrevious.TabIndex = 1;
            this.uxWizardPrevious.Text = "< Vorige";
            this.uxWizardPrevious.UseVisualStyleBackColor = true;
            this.uxWizardPrevious.Click += new System.EventHandler(this.uxWizardPrevious_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(21, 18);
            this.uxCancel.Margin = new System.Windows.Forms.Padding(4);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(100, 28);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Afsluiten";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxReset
            // 
            this.uxReset.Location = new System.Drawing.Point(646, 18);
            this.uxReset.Margin = new System.Windows.Forms.Padding(4);
            this.uxReset.Name = "uxReset";
            this.uxReset.Size = new System.Drawing.Size(146, 28);
            this.uxReset.TabIndex = 3;
            this.uxReset.Text = "Opnieuw beginnen";
            this.uxReset.UseVisualStyleBackColor = true;
            this.uxReset.Click += new System.EventHandler(this.uxReset_Click);
            // 
            // uxConfiguration
            // 
            this.uxConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxConfiguration.Location = new System.Drawing.Point(917, 28);
            this.uxConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.uxConfiguration.Name = "uxConfiguration";
            this.uxConfiguration.Size = new System.Drawing.Size(100, 28);
            this.uxConfiguration.TabIndex = 5;
            this.uxConfiguration.Text = "Instellingen";
            this.uxConfiguration.UseVisualStyleBackColor = true;
            // 
            // uxConfig
            // 
            this.uxConfig.Location = new System.Drawing.Point(512, 18);
            this.uxConfig.Margin = new System.Windows.Forms.Padding(4);
            this.uxConfig.Name = "uxConfig";
            this.uxConfig.Size = new System.Drawing.Size(118, 28);
            this.uxConfig.TabIndex = 4;
            this.uxConfig.Text = "Instellingen...";
            this.uxConfig.UseVisualStyleBackColor = true;
            this.uxConfig.Click += new System.EventHandler(this.uxConfig_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 678);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1046, 772);
            this.MinimumSize = new System.Drawing.Size(1046, 715);
            this.Name = "Main";
            this.Text = " Verdeling Facturatie [ Elegast vzw ] - v%version%";
            this.___contentBody.ResumeLayout(false);
            this.___contentBody.PerformLayout();
            this.___footerBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uxWizardStepTitle;
        private System.Windows.Forms.Panel uxWizardStepViewHost;
        private System.Windows.Forms.Button uxWizardNext;
        private System.Windows.Forms.Button uxWizardPrevious;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxReset;
        private System.Windows.Forms.Button uxConfiguration;
        private System.Windows.Forms.Button uxConfig;
    }
}

