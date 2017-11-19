using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kostenverdeling.Model.Calculation;

namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    public partial class CalculationReportControl : UserControl
    {
        private readonly CalculationReport _report;
        public CalculationReport Report { get { return _report; } }

        public event EventHandler IsValid;
        public event EventHandler IsInValid;        

        private void RaiseIsValid() {
            if (IsValid != null) {
                IsValid(this, EventArgs.Empty);
            }
        }

        private void RaiseIsInValid() {
            if (IsInValid != null) {
                IsInValid(this, EventArgs.Empty);
            }
        }


        public bool IsInValidState {
            get {
                return ValidateState();
            }
        }

        public string InvoiceNumber { get { return uxInvoiceNumber.Text; } }        

        private bool ValidateState() {            
            if (String.IsNullOrWhiteSpace(uxInvoiceNumber.Text)) {
                RaiseIsInValid();                
                return false;
            }

            if(!uxInvoiceNumber.Text.Trim().Any() || uxInvoiceNumber.Text == "-") {
                RaiseIsInValid();                
                return false;
            }

            if (String.IsNullOrWhiteSpace(uxTotalInvoiceAmount.Text))
            {
                RaiseIsInValid();                
                return false;
            }

            if (!uxTotalInvoiceAmount.Text.Trim().Any()) {
                RaiseIsInValid();                
                return false;
            }

            if (!Double.TryParse(uxTotalInvoiceAmount.Text.Replace(".", ","), out var result))
            {
                RaiseIsInValid();                
                return false;
            }

            RaiseIsValid();
            return true;
        }

        public CalculationReportControl(CalculationReport report, TabPage simulationTabPage = null) {
            InitializeComponent();
            _report = report;

            if(simulationTabPage != null) {
                tabCategories.TabPages.Add(simulationTabPage);
            }

            uxPeriod.Text = $"{_report.StartDate.ToString("dd/MM/yyyy")} - {_report.EndDate.ToString("dd/MM/yyyy")}";
            uxInvoiceDate.Text = _report.InvoiceDate.ToString("dd/MM/yyyy");
            uxInvoiceNumber.Text = _report.InvoiceNumber;            

            var categories = report.SubReports.Select(sr => sr.Category).Distinct();
            foreach(var category in categories) {
                var categoryTabPage = new TabPage(category);
                categoryTabPage.BackColor = Color.White;
                var subReportControl = new CalculationSubReportControl(_report.SubReports.Where(sr => sr.Category == category).ToList());
                categoryTabPage.Controls.Add(subReportControl);
                tabCategories.TabPages.Add(categoryTabPage);
            }
        }        

        private void uxInvoiceNumber_TextChanged_1(object sender, EventArgs e) {
            _report.InvoiceNumber = uxInvoiceNumber.Text;
            ValidateState();
        }

        private void uxTotalInvoiceAmount_TextChanged(object sender, EventArgs e) {
            _report.OriginalInvoiceTotal = uxTotalInvoiceAmount.Text;
            ValidateState();
        }
    }
}
