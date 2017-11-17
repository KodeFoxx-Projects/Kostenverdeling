namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    partial class CalculationReportControl
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
            this.uxPeriodLabel = new System.Windows.Forms.Label();
            this.uxPeriod = new System.Windows.Forms.Label();
            this.uxInvoiceDate = new System.Windows.Forms.Label();
            this.uxInvoiceDateLabel = new System.Windows.Forms.Label();
            this.uxInvoiceNumberLabel = new System.Windows.Forms.Label();
            this.uxSplitter = new System.Windows.Forms.Label();
            this.tabCategories = new System.Windows.Forms.TabControl();
            this.uxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.uxInvoiceNumberIgnore = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uxPeriodLabel
            // 
            this.uxPeriodLabel.AutoSize = true;
            this.uxPeriodLabel.Location = new System.Drawing.Point(4, 9);
            this.uxPeriodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPeriodLabel.Name = "uxPeriodLabel";
            this.uxPeriodLabel.Size = new System.Drawing.Size(61, 17);
            this.uxPeriodLabel.TabIndex = 0;
            this.uxPeriodLabel.Text = "Periode:";
            // 
            // uxPeriod
            // 
            this.uxPeriod.AutoSize = true;
            this.uxPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.uxPeriod.Location = new System.Drawing.Point(63, 9);
            this.uxPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPeriod.Name = "uxPeriod";
            this.uxPeriod.Size = new System.Drawing.Size(169, 17);
            this.uxPeriod.TabIndex = 1;
            this.uxPeriod.Text = "dd/mm/yyyy - dd/mm/yyyy";
            // 
            // uxInvoiceDate
            // 
            this.uxInvoiceDate.AutoSize = true;
            this.uxInvoiceDate.ForeColor = System.Drawing.Color.DimGray;
            this.uxInvoiceDate.Location = new System.Drawing.Point(355, 9);
            this.uxInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxInvoiceDate.Name = "uxInvoiceDate";
            this.uxInvoiceDate.Size = new System.Drawing.Size(82, 17);
            this.uxInvoiceDate.TabIndex = 3;
            this.uxInvoiceDate.Text = "dd/mm/yyyy";
            // 
            // uxInvoiceDateLabel
            // 
            this.uxInvoiceDateLabel.AutoSize = true;
            this.uxInvoiceDateLabel.Location = new System.Drawing.Point(257, 9);
            this.uxInvoiceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxInvoiceDateLabel.Name = "uxInvoiceDateLabel";
            this.uxInvoiceDateLabel.Size = new System.Drawing.Size(99, 17);
            this.uxInvoiceDateLabel.TabIndex = 2;
            this.uxInvoiceDateLabel.Text = "Factuurdatum:";
            // 
            // uxInvoiceNumberLabel
            // 
            this.uxInvoiceNumberLabel.AutoSize = true;
            this.uxInvoiceNumberLabel.Location = new System.Drawing.Point(460, 9);
            this.uxInvoiceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxInvoiceNumberLabel.Name = "uxInvoiceNumberLabel";
            this.uxInvoiceNumberLabel.Size = new System.Drawing.Size(111, 17);
            this.uxInvoiceNumberLabel.TabIndex = 4;
            this.uxInvoiceNumberLabel.Text = "Factuurnummer:";
            // 
            // uxSplitter
            // 
            this.uxSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxSplitter.Location = new System.Drawing.Point(21, 39);
            this.uxSplitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxSplitter.Name = "uxSplitter";
            this.uxSplitter.Size = new System.Drawing.Size(937, 2);
            this.uxSplitter.TabIndex = 6;
            // 
            // tabCategories
            // 
            this.tabCategories.Location = new System.Drawing.Point(21, 54);
            this.tabCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.SelectedIndex = 0;
            this.tabCategories.Size = new System.Drawing.Size(937, 341);
            this.tabCategories.TabIndex = 7;
            // 
            // uxInvoiceNumber
            // 
            this.uxInvoiceNumber.Location = new System.Drawing.Point(578, 6);
            this.uxInvoiceNumber.Name = "uxInvoiceNumber";
            this.uxInvoiceNumber.Size = new System.Drawing.Size(177, 22);
            this.uxInvoiceNumber.TabIndex = 8;
            this.uxInvoiceNumber.TextChanged += new System.EventHandler(this.uxInvoiceNumber_TextChanged_1);
            // 
            // uxInvoiceNumberIgnore
            // 
            this.uxInvoiceNumberIgnore.AutoSize = true;
            this.uxInvoiceNumberIgnore.Location = new System.Drawing.Point(761, 8);
            this.uxInvoiceNumberIgnore.Name = "uxInvoiceNumberIgnore";
            this.uxInvoiceNumberIgnore.Size = new System.Drawing.Size(186, 21);
            this.uxInvoiceNumberIgnore.TabIndex = 9;
            this.uxInvoiceNumberIgnore.Text = "Ik vul dit later manueel in";
            this.uxInvoiceNumberIgnore.UseVisualStyleBackColor = true;
            this.uxInvoiceNumberIgnore.CheckedChanged += new System.EventHandler(this.uxInvoiceNumberIgnore_CheckedChanged);
            // 
            // CalculationReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxInvoiceNumberIgnore);
            this.Controls.Add(this.uxInvoiceNumber);
            this.Controls.Add(this.tabCategories);
            this.Controls.Add(this.uxSplitter);
            this.Controls.Add(this.uxInvoiceNumberLabel);
            this.Controls.Add(this.uxInvoiceDate);
            this.Controls.Add(this.uxInvoiceDateLabel);
            this.Controls.Add(this.uxPeriod);
            this.Controls.Add(this.uxPeriodLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(980, 412);
            this.MinimumSize = new System.Drawing.Size(980, 412);
            this.Name = "CalculationReportControl";
            this.Size = new System.Drawing.Size(980, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPeriodLabel;
        private System.Windows.Forms.Label uxPeriod;
        private System.Windows.Forms.Label uxInvoiceDate;
        private System.Windows.Forms.Label uxInvoiceDateLabel;
        private System.Windows.Forms.Label uxInvoiceNumberLabel;
        private System.Windows.Forms.Label uxSplitter;
        private System.Windows.Forms.TabControl tabCategories;
        private System.Windows.Forms.TextBox uxInvoiceNumber;
        private System.Windows.Forms.CheckBox uxInvoiceNumberIgnore;
    }
}
