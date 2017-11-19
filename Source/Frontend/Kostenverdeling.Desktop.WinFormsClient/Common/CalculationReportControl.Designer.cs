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
            this.uxTotalInvoiceAmount = new System.Windows.Forms.TextBox();
            this.uxTotalInvoiceAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxPeriodLabel
            // 
            this.uxPeriodLabel.AutoSize = true;
            this.uxPeriodLabel.Location = new System.Drawing.Point(3, 7);
            this.uxPeriodLabel.Name = "uxPeriodLabel";
            this.uxPeriodLabel.Size = new System.Drawing.Size(46, 13);
            this.uxPeriodLabel.TabIndex = 0;
            this.uxPeriodLabel.Text = "Periode:";
            // 
            // uxPeriod
            // 
            this.uxPeriod.AutoSize = true;
            this.uxPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.uxPeriod.Location = new System.Drawing.Point(47, 7);
            this.uxPeriod.Name = "uxPeriod";
            this.uxPeriod.Size = new System.Drawing.Size(132, 13);
            this.uxPeriod.TabIndex = 1;
            this.uxPeriod.Text = "dd/mm/yyyy - dd/mm/yyyy";
            // 
            // uxInvoiceDate
            // 
            this.uxInvoiceDate.AutoSize = true;
            this.uxInvoiceDate.ForeColor = System.Drawing.Color.DimGray;
            this.uxInvoiceDate.Location = new System.Drawing.Point(266, 7);
            this.uxInvoiceDate.Name = "uxInvoiceDate";
            this.uxInvoiceDate.Size = new System.Drawing.Size(65, 13);
            this.uxInvoiceDate.TabIndex = 3;
            this.uxInvoiceDate.Text = "dd/mm/yyyy";
            // 
            // uxInvoiceDateLabel
            // 
            this.uxInvoiceDateLabel.AutoSize = true;
            this.uxInvoiceDateLabel.Location = new System.Drawing.Point(193, 7);
            this.uxInvoiceDateLabel.Name = "uxInvoiceDateLabel";
            this.uxInvoiceDateLabel.Size = new System.Drawing.Size(75, 13);
            this.uxInvoiceDateLabel.TabIndex = 2;
            this.uxInvoiceDateLabel.Text = "Factuurdatum:";
            // 
            // uxInvoiceNumberLabel
            // 
            this.uxInvoiceNumberLabel.AutoSize = true;
            this.uxInvoiceNumberLabel.Location = new System.Drawing.Point(345, 7);
            this.uxInvoiceNumberLabel.Name = "uxInvoiceNumberLabel";
            this.uxInvoiceNumberLabel.Size = new System.Drawing.Size(83, 13);
            this.uxInvoiceNumberLabel.TabIndex = 4;
            this.uxInvoiceNumberLabel.Text = "Factuurnummer:";
            // 
            // uxSplitter
            // 
            this.uxSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxSplitter.Location = new System.Drawing.Point(16, 32);
            this.uxSplitter.Name = "uxSplitter";
            this.uxSplitter.Size = new System.Drawing.Size(703, 2);
            this.uxSplitter.TabIndex = 6;
            // 
            // tabCategories
            // 
            this.tabCategories.Location = new System.Drawing.Point(16, 44);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.SelectedIndex = 0;
            this.tabCategories.Size = new System.Drawing.Size(703, 277);
            this.tabCategories.TabIndex = 7;
            // 
            // uxInvoiceNumber
            // 
            this.uxInvoiceNumber.Location = new System.Drawing.Point(434, 5);
            this.uxInvoiceNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInvoiceNumber.Name = "uxInvoiceNumber";
            this.uxInvoiceNumber.Size = new System.Drawing.Size(103, 20);
            this.uxInvoiceNumber.TabIndex = 8;
            this.uxInvoiceNumber.TextChanged += new System.EventHandler(this.uxInvoiceNumber_TextChanged_1);
            // 
            // uxTotalInvoiceAmount
            // 
            this.uxTotalInvoiceAmount.Location = new System.Drawing.Point(628, 4);
            this.uxTotalInvoiceAmount.Margin = new System.Windows.Forms.Padding(2);
            this.uxTotalInvoiceAmount.Name = "uxTotalInvoiceAmount";
            this.uxTotalInvoiceAmount.Size = new System.Drawing.Size(91, 20);
            this.uxTotalInvoiceAmount.TabIndex = 10;
            this.uxTotalInvoiceAmount.TextChanged += new System.EventHandler(this.uxTotalInvoiceAmount_TextChanged);
            // 
            // uxTotalInvoiceAmountLabel
            // 
            this.uxTotalInvoiceAmountLabel.AutoSize = true;
            this.uxTotalInvoiceAmountLabel.Location = new System.Drawing.Point(550, 8);
            this.uxTotalInvoiceAmountLabel.Name = "uxTotalInvoiceAmountLabel";
            this.uxTotalInvoiceAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.uxTotalInvoiceAmountLabel.TabIndex = 9;
            this.uxTotalInvoiceAmountLabel.Text = "Totaalbedrag;";
            // 
            // CalculationReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxTotalInvoiceAmount);
            this.Controls.Add(this.uxTotalInvoiceAmountLabel);
            this.Controls.Add(this.uxInvoiceNumber);
            this.Controls.Add(this.tabCategories);
            this.Controls.Add(this.uxSplitter);
            this.Controls.Add(this.uxInvoiceNumberLabel);
            this.Controls.Add(this.uxInvoiceDate);
            this.Controls.Add(this.uxInvoiceDateLabel);
            this.Controls.Add(this.uxPeriod);
            this.Controls.Add(this.uxPeriodLabel);
            this.MaximumSize = new System.Drawing.Size(735, 335);
            this.MinimumSize = new System.Drawing.Size(735, 335);
            this.Name = "CalculationReportControl";
            this.Size = new System.Drawing.Size(735, 335);
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
        private System.Windows.Forms.TextBox uxTotalInvoiceAmount;
        private System.Windows.Forms.Label uxTotalInvoiceAmountLabel;
    }
}
