namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    partial class MasterDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDialogForm));
            this.___body = new System.Windows.Forms.Panel();
            this.___contentBodyContainer = new System.Windows.Forms.Panel();
            this.___contentBody = new System.Windows.Forms.Panel();
            this.uxTextInfo = new System.Windows.Forms.Label();
            this.___footerSplitter = new System.Windows.Forms.Label();
            this.___footerBody = new System.Windows.Forms.Panel();
            this.uxCopyToClipboard = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOk = new System.Windows.Forms.Button();
            this.___headerSplitter = new System.Windows.Forms.Label();
            this.___headerBody = new System.Windows.Forms.Panel();
            this.@__applicationName = new System.Windows.Forms.Label();
            this.___headerBar = new System.Windows.Forms.Label();
            this.___headerLogo = new System.Windows.Forms.PictureBox();
            this.___body.SuspendLayout();
            this.___contentBodyContainer.SuspendLayout();
            this.___contentBody.SuspendLayout();
            this.___footerBody.SuspendLayout();
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
            this.___body.Name = "___body";
            this.___body.Size = new System.Drawing.Size(565, 123);
            this.___body.TabIndex = 1;
            // 
            // ___contentBodyContainer
            // 
            this.___contentBodyContainer.Controls.Add(this.___contentBody);
            this.___contentBodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___contentBodyContainer.Location = new System.Drawing.Point(0, 43);
            this.___contentBodyContainer.Name = "___contentBodyContainer";
            this.___contentBodyContainer.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.___contentBodyContainer.Size = new System.Drawing.Size(565, 28);
            this.___contentBodyContainer.TabIndex = 5;
            // 
            // ___contentBody
            // 
            this.___contentBody.AutoScroll = true;
            this.___contentBody.Controls.Add(this.uxTextInfo);
            this.___contentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___contentBody.Location = new System.Drawing.Point(8, 8);
            this.___contentBody.Name = "___contentBody";
            this.___contentBody.Size = new System.Drawing.Size(549, 12);
            this.___contentBody.TabIndex = 0;
            // 
            // uxTextInfo
            // 
            this.uxTextInfo.AutoSize = true;
            this.uxTextInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTextInfo.Location = new System.Drawing.Point(0, 0);
            this.uxTextInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTextInfo.MaximumSize = new System.Drawing.Size(548, 0);
            this.uxTextInfo.Name = "uxTextInfo";
            this.uxTextInfo.Size = new System.Drawing.Size(61, 13);
            this.uxTextInfo.TabIndex = 3;
            this.uxTextInfo.Text = "%infoText%";
            this.uxTextInfo.TextChanged += new System.EventHandler(this.uxTextInfo_TextChanged);
            // 
            // ___footerSplitter
            // 
            this.___footerSplitter.BackColor = System.Drawing.Color.Transparent;
            this.___footerSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.___footerSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.___footerSplitter.Location = new System.Drawing.Point(0, 71);
            this.___footerSplitter.Name = "___footerSplitter";
            this.___footerSplitter.Size = new System.Drawing.Size(565, 2);
            this.___footerSplitter.TabIndex = 4;
            // 
            // ___footerBody
            // 
            this.___footerBody.BackColor = System.Drawing.Color.White;
            this.___footerBody.Controls.Add(this.uxCopyToClipboard);
            this.___footerBody.Controls.Add(this.uxCancel);
            this.___footerBody.Controls.Add(this.uxOk);
            this.___footerBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.___footerBody.Location = new System.Drawing.Point(0, 73);
            this.___footerBody.Name = "___footerBody";
            this.___footerBody.Size = new System.Drawing.Size(565, 50);
            this.___footerBody.TabIndex = 3;
            // 
            // uxCopyToClipboard
            // 
            this.uxCopyToClipboard.Location = new System.Drawing.Point(10, 13);
            this.uxCopyToClipboard.Name = "uxCopyToClipboard";
            this.uxCopyToClipboard.Size = new System.Drawing.Size(192, 23);
            this.uxCopyToClipboard.TabIndex = 4;
            this.uxCopyToClipboard.Text = "Foutmelding kopiëren naar klembord";
            this.uxCopyToClipboard.UseVisualStyleBackColor = true;
            this.uxCopyToClipboard.Visible = false;
            this.uxCopyToClipboard.Click += new System.EventHandler(this.uxCopyToClipboard_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(399, 13);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 3;
            this.uxCancel.Text = "Annuleren";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOk
            // 
            this.uxOk.Location = new System.Drawing.Point(480, 13);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(75, 23);
            this.uxOk.TabIndex = 2;
            this.uxOk.Text = "Ok";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // ___headerSplitter
            // 
            this.___headerSplitter.BackColor = System.Drawing.Color.Transparent;
            this.___headerSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.___headerSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.___headerSplitter.Location = new System.Drawing.Point(0, 41);
            this.___headerSplitter.Name = "___headerSplitter";
            this.___headerSplitter.Size = new System.Drawing.Size(565, 2);
            this.___headerSplitter.TabIndex = 2;
            // 
            // ___headerBody
            // 
            this.___headerBody.BackColor = System.Drawing.Color.White;
            this.___headerBody.Controls.Add(this.@__applicationName);
            this.___headerBody.Controls.Add(this.___headerBar);
            this.___headerBody.Controls.Add(this.___headerLogo);
            this.___headerBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.___headerBody.Location = new System.Drawing.Point(0, 0);
            this.___headerBody.Name = "___headerBody";
            this.___headerBody.Size = new System.Drawing.Size(565, 41);
            this.___headerBody.TabIndex = 0;
            // 
            // __applicationName
            // 
            this.@__applicationName.AutoSize = true;
            this.@__applicationName.BackColor = System.Drawing.Color.Transparent;
            this.@__applicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__applicationName.ForeColor = System.Drawing.Color.White;
            this.@__applicationName.Location = new System.Drawing.Point(12, 9);
            this.@__applicationName.Name = "__applicationName";
            this.@__applicationName.Size = new System.Drawing.Size(172, 20);
            this.@__applicationName.TabIndex = 1;
            this.@__applicationName.Text = "%applicationName%";
            this.@__applicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ___headerBar
            // 
            this.___headerBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.___headerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.___headerBar.Location = new System.Drawing.Point(0, 0);
            this.___headerBar.Name = "___headerBar";
            this.___headerBar.Size = new System.Drawing.Size(565, 41);
            this.___headerBar.TabIndex = 3;
            // 
            // ___headerLogo
            // 
            this.___headerLogo.Image = ((System.Drawing.Image)(resources.GetObject("___headerLogo.Image")));
            this.___headerLogo.Location = new System.Drawing.Point(8, 0);
            this.___headerLogo.Name = "___headerLogo";
            this.___headerLogo.Size = new System.Drawing.Size(80, 98);
            this.___headerLogo.TabIndex = 0;
            this.___headerLogo.TabStop = false;
            this.___headerLogo.Visible = false;
            // 
            // MasterDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 123);
            this.ControlBox = false;
            this.Controls.Add(this.___body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(581, 768);
            this.MinimumSize = new System.Drawing.Size(581, 162);
            this.Name = "MasterDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MasterDialogForm";
            this.___body.ResumeLayout(false);
            this.___contentBodyContainer.ResumeLayout(false);
            this.___contentBody.ResumeLayout(false);
            this.___contentBody.PerformLayout();
            this.___footerBody.ResumeLayout(false);
            this.___headerBody.ResumeLayout(false);
            this.___headerBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.___headerLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ___body;
        private System.Windows.Forms.Panel ___contentBodyContainer;
        public System.Windows.Forms.Panel ___contentBody;
        private System.Windows.Forms.Label ___footerSplitter;
        public System.Windows.Forms.Panel ___footerBody;
        private System.Windows.Forms.Label ___headerSplitter;
        private System.Windows.Forms.Panel ___headerBody;
        private System.Windows.Forms.Label __applicationName;
        private System.Windows.Forms.Label ___headerBar;
        private System.Windows.Forms.PictureBox ___headerLogo;
        private System.Windows.Forms.Button uxOk;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Label uxTextInfo;
        private System.Windows.Forms.Button uxCopyToClipboard;
    }
}