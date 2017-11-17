namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    partial class SimulationResultControl
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
            this.uxInvoiceSimulation = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bedrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxInvoiceSimulation)).BeginInit();
            this.SuspendLayout();
            // 
            // uxInvoiceSimulation
            // 
            this.uxInvoiceSimulation.AllowUserToAddRows = false;
            this.uxInvoiceSimulation.AllowUserToDeleteRows = false;
            this.uxInvoiceSimulation.BackgroundColor = System.Drawing.Color.White;
            this.uxInvoiceSimulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxInvoiceSimulation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uxInvoiceSimulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxInvoiceSimulation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Omschrijving,
            this.Bedrag});
            this.uxInvoiceSimulation.GridColor = System.Drawing.Color.White;
            this.uxInvoiceSimulation.Location = new System.Drawing.Point(3, 3);
            this.uxInvoiceSimulation.MultiSelect = false;
            this.uxInvoiceSimulation.Name = "uxInvoiceSimulation";
            this.uxInvoiceSimulation.ReadOnly = true;
            this.uxInvoiceSimulation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxInvoiceSimulation.Size = new System.Drawing.Size(684, 244);
            this.uxInvoiceSimulation.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Omschrijving
            // 
            this.Omschrijving.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Omschrijving.HeaderText = "Omschrijving";
            this.Omschrijving.Name = "Omschrijving";
            this.Omschrijving.ReadOnly = true;
            // 
            // Bedrag
            // 
            this.Bedrag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bedrag.HeaderText = "Bedrag (€)";
            this.Bedrag.Name = "Bedrag";
            this.Bedrag.ReadOnly = true;
            // 
            // SimulationResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxInvoiceSimulation);
            this.MaximumSize = new System.Drawing.Size(690, 250);
            this.MinimumSize = new System.Drawing.Size(690, 250);
            this.Name = "SimulationResultControl";
            this.Size = new System.Drawing.Size(690, 250);
            ((System.ComponentModel.ISupportInitialize)(this.uxInvoiceSimulation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxInvoiceSimulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omschrijving;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bedrag;
    }
}
