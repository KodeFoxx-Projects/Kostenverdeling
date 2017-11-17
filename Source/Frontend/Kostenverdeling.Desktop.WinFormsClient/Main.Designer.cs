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
            this.___contentBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___contentBody.Size = new System.Drawing.Size(756, 427);
            // 
            // ___footerBody
            // 
            this.___footerBody.Controls.Add(this.uxConfig);
            this.___footerBody.Controls.Add(this.uxReset);
            this.___footerBody.Controls.Add(this.uxCancel);
            this.___footerBody.Controls.Add(this.uxWizardPrevious);
            this.___footerBody.Controls.Add(this.uxWizardNext);
            this.___footerBody.Location = new System.Drawing.Point(0, 501);
            this.___footerBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___footerBody.Size = new System.Drawing.Size(772, 50);
            // 
            // __applicationName
            // 
            this.@__applicationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // ___headerBar
            // 
            this.___headerBar.Size = new System.Drawing.Size(772, 54);
            // 
            // uxWizardStepTitle
            // 
            this.uxWizardStepTitle.AutoSize = true;
            this.uxWizardStepTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxWizardStepTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWizardStepTitle.Location = new System.Drawing.Point(0, 0);
            this.uxWizardStepTitle.Name = "uxWizardStepTitle";
            this.uxWizardStepTitle.Size = new System.Drawing.Size(162, 20);
            this.uxWizardStepTitle.TabIndex = 0;
            this.uxWizardStepTitle.Text = "%wizardStepTitle%";
            // 
            // uxWizardStepViewHost
            // 
            this.uxWizardStepViewHost.Location = new System.Drawing.Point(4, 23);
            this.uxWizardStepViewHost.Name = "uxWizardStepViewHost";
            this.uxWizardStepViewHost.Size = new System.Drawing.Size(750, 400);
            this.uxWizardStepViewHost.TabIndex = 1;
            // 
            // uxWizardNext
            // 
            this.uxWizardNext.Location = new System.Drawing.Point(687, 15);
            this.uxWizardNext.Name = "uxWizardNext";
            this.uxWizardNext.Size = new System.Drawing.Size(75, 23);
            this.uxWizardNext.TabIndex = 0;
            this.uxWizardNext.Text = "Volgende >";
            this.uxWizardNext.UseVisualStyleBackColor = true;
            this.uxWizardNext.Click += new System.EventHandler(this.uxWizardNext_Click);
            // 
            // uxWizardPrevious
            // 
            this.uxWizardPrevious.Location = new System.Drawing.Point(606, 15);
            this.uxWizardPrevious.Name = "uxWizardPrevious";
            this.uxWizardPrevious.Size = new System.Drawing.Size(75, 23);
            this.uxWizardPrevious.TabIndex = 1;
            this.uxWizardPrevious.Text = "< Vorige";
            this.uxWizardPrevious.UseVisualStyleBackColor = true;
            this.uxWizardPrevious.Click += new System.EventHandler(this.uxWizardPrevious_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(16, 15);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Afsluiten";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxReset
            // 
            this.uxReset.Location = new System.Drawing.Point(484, 15);
            this.uxReset.Name = "uxReset";
            this.uxReset.Size = new System.Drawing.Size(110, 23);
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
            this.uxConfig.Location = new System.Drawing.Point(384, 15);
            this.uxConfig.Name = "uxConfig";
            this.uxConfig.Size = new System.Drawing.Size(88, 23);
            this.uxConfig.TabIndex = 4;
            this.uxConfig.Text = "Instellingen...";
            this.uxConfig.UseVisualStyleBackColor = true;
            this.uxConfig.Click += new System.EventHandler(this.uxConfig_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 551);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 635);
            this.MinimumSize = new System.Drawing.Size(788, 588);
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

