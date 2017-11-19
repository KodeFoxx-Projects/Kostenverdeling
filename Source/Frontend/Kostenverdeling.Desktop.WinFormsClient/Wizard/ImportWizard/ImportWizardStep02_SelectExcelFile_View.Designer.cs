namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    partial class ImportWizardStep02_SelectExcelFile_View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportWizardStep02_SelectExcelFile_View));
            this.uxInfo = new System.Windows.Forms.Label();
            this.uxExcelFileLabel = new System.Windows.Forms.Label();
            this.uxBrowseExcelFile = new System.Windows.Forms.Button();
            this.uxExcelFile = new System.Windows.Forms.TextBox();
            this.uxDataLabel = new System.Windows.Forms.Label();
            this.uxDataPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.uxInvoiceDates = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uxFilterType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxUnknown = new System.Windows.Forms.Label();
            this.uxLegendDepartmentsAndDivisions = new System.Windows.Forms.Label();
            this.uxDepartmentsAndDivisions = new System.Windows.Forms.TreeView();
            this.uxDepartmentsAndDivisionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions = new System.Windows.Forms.ToolStripMenuItem();
            this.uxStructuurDepartementen = new System.Windows.Forms.Label();
            this.uxEndDateInvoice = new System.Windows.Forms.DateTimePicker();
            this.uxStartDateInvoice = new System.Windows.Forms.DateTimePicker();
            this.uxEndDateInvoiceLabel = new System.Windows.Forms.Label();
            this.uxStartDateInvoiceLabel = new System.Windows.Forms.Label();
            this.uxNumberOfEmployees = new System.Windows.Forms.Label();
            this.uxNumberOfEmployeesLabel = new System.Windows.Forms.Label();
            this.uxNumberOfRecords = new System.Windows.Forms.Label();
            this.uxNumberOfRecordsLabel = new System.Windows.Forms.Label();
            this.uxBusyPanel = new System.Windows.Forms.Panel();
            this.uxProgressInfo = new System.Windows.Forms.Label();
            this.uxProgressBar = new System.Windows.Forms.ProgressBar();
            this.uxBezigMetVerwerkenGegevens = new System.Windows.Forms.Label();
            this.uxDataPanel.SuspendLayout();
            this.uxDepartmentsAndDivisionsMenu.SuspendLayout();
            this.uxBusyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxInfo
            // 
            this.uxInfo.Location = new System.Drawing.Point(0, 0);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(750, 29);
            this.uxInfo.TabIndex = 1;
            this.uxInfo.Text = resources.GetString("uxInfo.Text");
            // 
            // uxExcelFileLabel
            // 
            this.uxExcelFileLabel.AutoSize = true;
            this.uxExcelFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExcelFileLabel.Location = new System.Drawing.Point(3, 36);
            this.uxExcelFileLabel.Name = "uxExcelFileLabel";
            this.uxExcelFileLabel.Size = new System.Drawing.Size(99, 13);
            this.uxExcelFileLabel.TabIndex = 2;
            this.uxExcelFileLabel.Text = "EXCEL bestand:";
            // 
            // uxBrowseExcelFile
            // 
            this.uxBrowseExcelFile.Location = new System.Drawing.Point(661, 78);
            this.uxBrowseExcelFile.Name = "uxBrowseExcelFile";
            this.uxBrowseExcelFile.Size = new System.Drawing.Size(75, 23);
            this.uxBrowseExcelFile.TabIndex = 4;
            this.uxBrowseExcelFile.Text = "Bladeren...";
            this.uxBrowseExcelFile.UseVisualStyleBackColor = true;
            this.uxBrowseExcelFile.Click += new System.EventHandler(this.uxBrowseExcelFile_Click);
            // 
            // uxExcelFile
            // 
            this.uxExcelFile.Location = new System.Drawing.Point(15, 52);
            this.uxExcelFile.Name = "uxExcelFile";
            this.uxExcelFile.ReadOnly = true;
            this.uxExcelFile.Size = new System.Drawing.Size(721, 20);
            this.uxExcelFile.TabIndex = 5;
            this.uxExcelFile.Text = "(geen bestand geselecteerd)";
            // 
            // uxDataLabel
            // 
            this.uxDataLabel.AutoSize = true;
            this.uxDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDataLabel.Location = new System.Drawing.Point(-3, 0);
            this.uxDataLabel.Name = "uxDataLabel";
            this.uxDataLabel.Size = new System.Drawing.Size(68, 13);
            this.uxDataLabel.TabIndex = 6;
            this.uxDataLabel.Text = "Gegevens:";
            // 
            // uxDataPanel
            // 
            this.uxDataPanel.Controls.Add(this.label11);
            this.uxDataPanel.Controls.Add(this.uxInvoiceDates);
            this.uxDataPanel.Controls.Add(this.label8);
            this.uxDataPanel.Controls.Add(this.uxFilterType);
            this.uxDataPanel.Controls.Add(this.label9);
            this.uxDataPanel.Controls.Add(this.label6);
            this.uxDataPanel.Controls.Add(this.label1);
            this.uxDataPanel.Controls.Add(this.uxUnknown);
            this.uxDataPanel.Controls.Add(this.uxLegendDepartmentsAndDivisions);
            this.uxDataPanel.Controls.Add(this.uxDepartmentsAndDivisions);
            this.uxDataPanel.Controls.Add(this.uxStructuurDepartementen);
            this.uxDataPanel.Controls.Add(this.uxEndDateInvoice);
            this.uxDataPanel.Controls.Add(this.uxStartDateInvoice);
            this.uxDataPanel.Controls.Add(this.uxEndDateInvoiceLabel);
            this.uxDataPanel.Controls.Add(this.uxStartDateInvoiceLabel);
            this.uxDataPanel.Controls.Add(this.uxNumberOfEmployees);
            this.uxDataPanel.Controls.Add(this.uxNumberOfEmployeesLabel);
            this.uxDataPanel.Controls.Add(this.uxNumberOfRecords);
            this.uxDataPanel.Controls.Add(this.uxNumberOfRecordsLabel);
            this.uxDataPanel.Controls.Add(this.uxDataLabel);
            this.uxDataPanel.Location = new System.Drawing.Point(6, 107);
            this.uxDataPanel.Name = "uxDataPanel";
            this.uxDataPanel.Size = new System.Drawing.Size(741, 290);
            this.uxDataPanel.TabIndex = 7;
            this.uxDataPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(206, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 27);
            this.label11.TabIndex = 31;
            this.label11.Text = "Toelichting: Enkel de records met geselecteerde factuurdatum worden meegenomen in" +
    " de berekening.";
            // 
            // uxInvoiceDates
            // 
            this.uxInvoiceDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxInvoiceDates.FormattingEnabled = true;
            this.uxInvoiceDates.Location = new System.Drawing.Point(208, 33);
            this.uxInvoiceDates.Name = "uxInvoiceDates";
            this.uxInvoiceDates.Size = new System.Drawing.Size(195, 21);
            this.uxInvoiceDates.TabIndex = 29;
            this.uxInvoiceDates.SelectedIndexChanged += new System.EventHandler(this.uxInvoiceDates_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Filter factuurdatum:";
            // 
            // uxFilterType
            // 
            this.uxFilterType.AutoSize = true;
            this.uxFilterType.ForeColor = System.Drawing.Color.DimGray;
            this.uxFilterType.Location = new System.Drawing.Point(73, 53);
            this.uxFilterType.Name = "uxFilterType";
            this.uxFilterType.Size = new System.Drawing.Size(10, 13);
            this.uxFilterType.TabIndex = 27;
            this.uxFilterType.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Filter \"Type\":";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(435, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Toelichting: Automatisch voorgestelde start- en einddatum voor de factuur. Geliev" +
    "e deze te controleren en eventueel aan te passen.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(612, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Onbekend bedrijf of project";
            // 
            // uxUnknown
            // 
            this.uxUnknown.AutoSize = true;
            this.uxUnknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUnknown.ForeColor = System.Drawing.Color.DimGray;
            this.uxUnknown.Location = new System.Drawing.Point(612, 263);
            this.uxUnknown.Name = "uxUnknown";
            this.uxUnknown.Size = new System.Drawing.Size(104, 12);
            this.uxUnknown.TabIndex = 18;
            this.uxUnknown.Text = "Gekend bedrijf of project";
            // 
            // uxLegendDepartmentsAndDivisions
            // 
            this.uxLegendDepartmentsAndDivisions.AutoSize = true;
            this.uxLegendDepartmentsAndDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLegendDepartmentsAndDivisions.ForeColor = System.Drawing.Color.DimGray;
            this.uxLegendDepartmentsAndDivisions.Location = new System.Drawing.Point(568, 263);
            this.uxLegendDepartmentsAndDivisions.Name = "uxLegendDepartmentsAndDivisions";
            this.uxLegendDepartmentsAndDivisions.Size = new System.Drawing.Size(43, 12);
            this.uxLegendDepartmentsAndDivisions.TabIndex = 17;
            this.uxLegendDepartmentsAndDivisions.Text = "Legende:";
            // 
            // uxDepartmentsAndDivisions
            // 
            this.uxDepartmentsAndDivisions.Location = new System.Drawing.Point(9, 86);
            this.uxDepartmentsAndDivisions.Name = "uxDepartmentsAndDivisions";
            this.uxDepartmentsAndDivisions.Size = new System.Drawing.Size(718, 174);
            this.uxDepartmentsAndDivisions.TabIndex = 16;
            // 
            // uxDepartmentsAndDivisionsMenu
            // 
            this.uxDepartmentsAndDivisionsMenu.Enabled = false;
            this.uxDepartmentsAndDivisionsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxDepartmentsAndDivisionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions});
            this.uxDepartmentsAndDivisionsMenu.Name = "uxDepartmentsAndDivisionsMenu";
            this.uxDepartmentsAndDivisionsMenu.Size = new System.Drawing.Size(191, 26);
            // 
            // uxToggleIgnoreIncludeDepartmentsAndDivisions
            // 
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions.Enabled = false;
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions.Name = "uxToggleIgnoreIncludeDepartmentsAndDivisions";
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions.Size = new System.Drawing.Size(190, 22);
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions.Text = "Negeren / Meenemen";
            this.uxToggleIgnoreIncludeDepartmentsAndDivisions.Click += new System.EventHandler(this.uxToggleIgnoreIncludeDepartmentsAndDivisions_Click);
            // 
            // uxStructuurDepartementen
            // 
            this.uxStructuurDepartementen.AutoSize = true;
            this.uxStructuurDepartementen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStructuurDepartementen.Location = new System.Drawing.Point(6, 70);
            this.uxStructuurDepartementen.Name = "uxStructuurDepartementen";
            this.uxStructuurDepartementen.Size = new System.Drawing.Size(116, 13);
            this.uxStructuurDepartementen.TabIndex = 15;
            this.uxStructuurDepartementen.Text = "Bedrijven en projecten:";
            // 
            // uxEndDateInvoice
            // 
            this.uxEndDateInvoice.Location = new System.Drawing.Point(583, 33);
            this.uxEndDateInvoice.Name = "uxEndDateInvoice";
            this.uxEndDateInvoice.Size = new System.Drawing.Size(144, 20);
            this.uxEndDateInvoice.TabIndex = 14;
            this.uxEndDateInvoice.ValueChanged += new System.EventHandler(this.uxEndDateInvoice_ValueChanged);
            // 
            // uxStartDateInvoice
            // 
            this.uxStartDateInvoice.Location = new System.Drawing.Point(435, 33);
            this.uxStartDateInvoice.Name = "uxStartDateInvoice";
            this.uxStartDateInvoice.Size = new System.Drawing.Size(142, 20);
            this.uxStartDateInvoice.TabIndex = 13;
            this.uxStartDateInvoice.ValueChanged += new System.EventHandler(this.uxStartDateInvoice_ValueChanged);
            // 
            // uxEndDateInvoiceLabel
            // 
            this.uxEndDateInvoiceLabel.AutoSize = true;
            this.uxEndDateInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndDateInvoiceLabel.Location = new System.Drawing.Point(583, 17);
            this.uxEndDateInvoiceLabel.Name = "uxEndDateInvoiceLabel";
            this.uxEndDateInvoiceLabel.Size = new System.Drawing.Size(96, 13);
            this.uxEndDateInvoiceLabel.TabIndex = 12;
            this.uxEndDateInvoiceLabel.Text = "Einddatum factuur:";
            // 
            // uxStartDateInvoiceLabel
            // 
            this.uxStartDateInvoiceLabel.AutoSize = true;
            this.uxStartDateInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartDateInvoiceLabel.Location = new System.Drawing.Point(432, 17);
            this.uxStartDateInvoiceLabel.Name = "uxStartDateInvoiceLabel";
            this.uxStartDateInvoiceLabel.Size = new System.Drawing.Size(97, 13);
            this.uxStartDateInvoiceLabel.TabIndex = 11;
            this.uxStartDateInvoiceLabel.Text = "Startdatum factuur:";
            // 
            // uxNumberOfEmployees
            // 
            this.uxNumberOfEmployees.AutoSize = true;
            this.uxNumberOfEmployees.ForeColor = System.Drawing.Color.DimGray;
            this.uxNumberOfEmployees.Location = new System.Drawing.Point(104, 40);
            this.uxNumberOfEmployees.Name = "uxNumberOfEmployees";
            this.uxNumberOfEmployees.Size = new System.Drawing.Size(10, 13);
            this.uxNumberOfEmployees.TabIndex = 10;
            this.uxNumberOfEmployees.Text = "-";
            // 
            // uxNumberOfEmployeesLabel
            // 
            this.uxNumberOfEmployeesLabel.AutoSize = true;
            this.uxNumberOfEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberOfEmployeesLabel.Location = new System.Drawing.Point(6, 40);
            this.uxNumberOfEmployeesLabel.Name = "uxNumberOfEmployeesLabel";
            this.uxNumberOfEmployeesLabel.Size = new System.Drawing.Size(100, 13);
            this.uxNumberOfEmployeesLabel.TabIndex = 9;
            this.uxNumberOfEmployeesLabel.Text = "Aantal werknemers:";
            // 
            // uxNumberOfRecords
            // 
            this.uxNumberOfRecords.AutoSize = true;
            this.uxNumberOfRecords.ForeColor = System.Drawing.Color.DimGray;
            this.uxNumberOfRecords.Location = new System.Drawing.Point(82, 27);
            this.uxNumberOfRecords.Name = "uxNumberOfRecords";
            this.uxNumberOfRecords.Size = new System.Drawing.Size(10, 13);
            this.uxNumberOfRecords.TabIndex = 8;
            this.uxNumberOfRecords.Text = "-";
            // 
            // uxNumberOfRecordsLabel
            // 
            this.uxNumberOfRecordsLabel.AutoSize = true;
            this.uxNumberOfRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberOfRecordsLabel.Location = new System.Drawing.Point(6, 27);
            this.uxNumberOfRecordsLabel.Name = "uxNumberOfRecordsLabel";
            this.uxNumberOfRecordsLabel.Size = new System.Drawing.Size(78, 13);
            this.uxNumberOfRecordsLabel.TabIndex = 7;
            this.uxNumberOfRecordsLabel.Text = "Aantal records:";
            // 
            // uxBusyPanel
            // 
            this.uxBusyPanel.Controls.Add(this.uxProgressInfo);
            this.uxBusyPanel.Controls.Add(this.uxProgressBar);
            this.uxBusyPanel.Controls.Add(this.uxBezigMetVerwerkenGegevens);
            this.uxBusyPanel.Location = new System.Drawing.Point(6, 107);
            this.uxBusyPanel.Name = "uxBusyPanel";
            this.uxBusyPanel.Size = new System.Drawing.Size(741, 290);
            this.uxBusyPanel.TabIndex = 8;
            this.uxBusyPanel.Visible = false;
            // 
            // uxProgressInfo
            // 
            this.uxProgressInfo.AutoSize = true;
            this.uxProgressInfo.Location = new System.Drawing.Point(6, 17);
            this.uxProgressInfo.Name = "uxProgressInfo";
            this.uxProgressInfo.Size = new System.Drawing.Size(226, 13);
            this.uxProgressInfo.TabIndex = 13;
            this.uxProgressInfo.Text = "Bezig met verwerken E-Blox EXCEL bestand...";
            // 
            // uxProgressBar
            // 
            this.uxProgressBar.Location = new System.Drawing.Point(9, 33);
            this.uxProgressBar.Name = "uxProgressBar";
            this.uxProgressBar.Size = new System.Drawing.Size(721, 23);
            this.uxProgressBar.TabIndex = 12;
            // 
            // uxBezigMetVerwerkenGegevens
            // 
            this.uxBezigMetVerwerkenGegevens.AutoSize = true;
            this.uxBezigMetVerwerkenGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBezigMetVerwerkenGegevens.Location = new System.Drawing.Point(-2, 0);
            this.uxBezigMetVerwerkenGegevens.Name = "uxBezigMetVerwerkenGegevens";
            this.uxBezigMetVerwerkenGegevens.Size = new System.Drawing.Size(90, 13);
            this.uxBezigMetVerwerkenGegevens.TabIndex = 6;
            this.uxBezigMetVerwerkenGegevens.Text = "Even geduld...";
            // 
            // ImportWizardStep02_SelectExcelFile_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxExcelFile);
            this.Controls.Add(this.uxBrowseExcelFile);
            this.Controls.Add(this.uxExcelFileLabel);
            this.Controls.Add(this.uxInfo);
            this.Controls.Add(this.uxDataPanel);
            this.Controls.Add(this.uxBusyPanel);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "ImportWizardStep02_SelectExcelFile_View";
            this.Size = new System.Drawing.Size(750, 400);
            this.uxDataPanel.ResumeLayout(false);
            this.uxDataPanel.PerformLayout();
            this.uxDepartmentsAndDivisionsMenu.ResumeLayout(false);
            this.uxBusyPanel.ResumeLayout(false);
            this.uxBusyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInfo;
        private System.Windows.Forms.Label uxExcelFileLabel;
        private System.Windows.Forms.Button uxBrowseExcelFile;
        public System.Windows.Forms.TextBox uxExcelFile;
        private System.Windows.Forms.Label uxDataLabel;
        private System.Windows.Forms.Panel uxDataPanel;
        private System.Windows.Forms.Panel uxBusyPanel;
        private System.Windows.Forms.Label uxBezigMetVerwerkenGegevens;
        private System.Windows.Forms.Label uxNumberOfRecordsLabel;
        private System.Windows.Forms.Label uxNumberOfEmployees;
        private System.Windows.Forms.Label uxNumberOfEmployeesLabel;
        private System.Windows.Forms.Label uxNumberOfRecords;
        private System.Windows.Forms.Label uxProgressInfo;
        private System.Windows.Forms.ProgressBar uxProgressBar;
        private System.Windows.Forms.DateTimePicker uxEndDateInvoice;
        private System.Windows.Forms.DateTimePicker uxStartDateInvoice;
        private System.Windows.Forms.Label uxEndDateInvoiceLabel;
        private System.Windows.Forms.Label uxStartDateInvoiceLabel;
        private System.Windows.Forms.Label uxStructuurDepartementen;
        private System.Windows.Forms.TreeView uxDepartmentsAndDivisions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxUnknown;
        private System.Windows.Forms.Label uxLegendDepartmentsAndDivisions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uxFilterType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox uxInvoiceDates;
        private System.Windows.Forms.ContextMenuStrip uxDepartmentsAndDivisionsMenu;
        private System.Windows.Forms.ToolStripMenuItem uxToggleIgnoreIncludeDepartmentsAndDivisions;
    }
}
