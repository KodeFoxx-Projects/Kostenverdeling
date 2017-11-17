namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.___body = new System.Windows.Forms.Panel();
            this.___contentBodyContainer = new System.Windows.Forms.Panel();
            this.___contentBody = new System.Windows.Forms.Panel();
            this.___footerSplitter = new System.Windows.Forms.Label();
            this.___footerBody = new System.Windows.Forms.Panel();
            this.___headerSplitter = new System.Windows.Forms.Label();
            this.___headerBody = new System.Windows.Forms.Panel();
            this.@__applicationVersion = new System.Windows.Forms.Label();
            this.@__applicationName = new System.Windows.Forms.Label();
            this.___headerBar = new System.Windows.Forms.Label();
            this.___headerLogo = new System.Windows.Forms.PictureBox();
            this.___body.SuspendLayout();
            this.___contentBodyContainer.SuspendLayout();
            this.___headerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.___headerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ___body
            // 
            this.___body.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.___body.Controls.Add(this.___contentBodyContainer);
            this.___body.Controls.Add(this.___footerSplitter);
            this.___body.Controls.Add(this.___footerBody);
            this.___body.Controls.Add(this.___headerSplitter);
            this.___body.Controls.Add(this.___headerBody);
            this.___body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___body.Location = new System.Drawing.Point(0, 0);
            this.___body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___body.Name = "___body";
            this.___body.Size = new System.Drawing.Size(1085, 575);
            this.___body.TabIndex = 0;
            // 
            // ___contentBodyContainer
            // 
            this.___contentBodyContainer.Controls.Add(this.___contentBody);
            this.___contentBodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___contentBodyContainer.Location = new System.Drawing.Point(0, 68);
            this.___contentBodyContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___contentBodyContainer.Name = "___contentBodyContainer";
            this.___contentBodyContainer.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.___contentBodyContainer.Size = new System.Drawing.Size(1085, 443);
            this.___contentBodyContainer.TabIndex = 5;
            // 
            // ___contentBody
            // 
            this.___contentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___contentBody.Location = new System.Drawing.Point(11, 10);
            this.___contentBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___contentBody.Name = "___contentBody";
            this.___contentBody.Size = new System.Drawing.Size(1063, 423);
            this.___contentBody.TabIndex = 0;
            // 
            // ___footerSplitter
            // 
            this.___footerSplitter.BackColor = System.Drawing.Color.Transparent;
            this.___footerSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.___footerSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.___footerSplitter.Location = new System.Drawing.Point(0, 511);
            this.___footerSplitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.___footerSplitter.Name = "___footerSplitter";
            this.___footerSplitter.Size = new System.Drawing.Size(1085, 2);
            this.___footerSplitter.TabIndex = 4;
            // 
            // ___footerBody
            // 
            this.___footerBody.BackColor = System.Drawing.Color.White;
            this.___footerBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.___footerBody.Location = new System.Drawing.Point(0, 513);
            this.___footerBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___footerBody.Name = "___footerBody";
            this.___footerBody.Size = new System.Drawing.Size(1085, 62);
            this.___footerBody.TabIndex = 3;
            // 
            // ___headerSplitter
            // 
            this.___headerSplitter.BackColor = System.Drawing.Color.Transparent;
            this.___headerSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.___headerSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.___headerSplitter.Location = new System.Drawing.Point(0, 66);
            this.___headerSplitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.___headerSplitter.Name = "___headerSplitter";
            this.___headerSplitter.Size = new System.Drawing.Size(1085, 2);
            this.___headerSplitter.TabIndex = 2;
            // 
            // ___headerBody
            // 
            this.___headerBody.BackColor = System.Drawing.Color.White;
            this.___headerBody.Controls.Add(this.@__applicationVersion);
            this.___headerBody.Controls.Add(this.@__applicationName);
            this.___headerBody.Controls.Add(this.___headerBar);
            this.___headerBody.Controls.Add(this.___headerLogo);
            this.___headerBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.___headerBody.Location = new System.Drawing.Point(0, 0);
            this.___headerBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___headerBody.Name = "___headerBody";
            this.___headerBody.Size = new System.Drawing.Size(1085, 66);
            this.___headerBody.TabIndex = 0;
            // 
            // __applicationVersion
            // 
            this.@__applicationVersion.AutoSize = true;
            this.@__applicationVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__applicationVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.@__applicationVersion.Location = new System.Drawing.Point(16, 36);
            this.@__applicationVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__applicationVersion.Name = "__applicationVersion";
            this.@__applicationVersion.Size = new System.Drawing.Size(110, 13);
            this.@__applicationVersion.TabIndex = 2;
            this.@__applicationVersion.Text = "%applicationVersion%";
            this.@__applicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // __applicationName
            // 
            this.@__applicationName.AutoSize = true;
            this.@__applicationName.BackColor = System.Drawing.Color.Transparent;
            this.@__applicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__applicationName.ForeColor = System.Drawing.Color.White;
            this.@__applicationName.Location = new System.Drawing.Point(16, 11);
            this.@__applicationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__applicationName.Name = "__applicationName";
            this.@__applicationName.Size = new System.Drawing.Size(210, 25);
            this.@__applicationName.TabIndex = 1;
            this.@__applicationName.Text = "%applicationName%";
            this.@__applicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ___headerBar
            // 
            this.___headerBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.___headerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___headerBar.Location = new System.Drawing.Point(0, 0);
            this.___headerBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.___headerBar.Name = "___headerBar";
            this.___headerBar.Size = new System.Drawing.Size(1085, 66);
            this.___headerBar.TabIndex = 3;
            // 
            // ___headerLogo
            // 
            this.___headerLogo.Image = ((System.Drawing.Image)(resources.GetObject("___headerLogo.Image")));
            this.___headerLogo.Location = new System.Drawing.Point(11, 0);
            this.___headerLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.___headerLogo.Name = "___headerLogo";
            this.___headerLogo.Size = new System.Drawing.Size(107, 121);
            this.___headerLogo.TabIndex = 0;
            this.___headerLogo.TabStop = false;
            this.___headerLogo.Visible = false;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 575);
            this.Controls.Add(this.___body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%name%";
            this.Resize += new System.EventHandler(this.MasterForm_Resize);
            this.___body.ResumeLayout(false);
            this.___contentBodyContainer.ResumeLayout(false);
            this.___headerBody.ResumeLayout(false);
            this.___headerBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.___headerLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ___body;
        private System.Windows.Forms.Panel ___headerBody;
        private System.Windows.Forms.PictureBox ___headerLogo;
        private System.Windows.Forms.Label ___headerSplitter;
        private System.Windows.Forms.Label __applicationVersion;
        private System.Windows.Forms.Label ___footerSplitter;
        private System.Windows.Forms.Panel ___contentBodyContainer;
        public System.Windows.Forms.Panel ___contentBody;
        public System.Windows.Forms.Panel ___footerBody;
        public System.Windows.Forms.Label __applicationName;
        public System.Windows.Forms.Label ___headerBar;
    }
}