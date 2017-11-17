using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Kostenverdeling.Model.Calculation;
using Kostenverdeling.Desktop.WinFormsClient.Common;
using Kostenverdeling.Model.InvoiceSimulation;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public partial class ImportWizardStep03_CalculationsOverview_View : UserControl
    {
        private List<CalculationReportControl> _calculationReports;

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

        private ImportWizardController _controller;

        public ImportWizardStep03_CalculationsOverview_View(ImportWizardController controller) {
            InitializeComponent();
            _controller = controller;
        }

        internal void RefreshCalculations() {

            uxTabContainer.Visible = false;
            uxProgressPanel.Visible = true;

            var previousReportSettingsInvoiceNumber = new Dictionary<string, string>();
            var previousReportSettingsIgnoreInvoiceNumber = new Dictionary<string, bool>();
            if (_controller.CalculationReports != null) {
                foreach(var calculationReport in _controller.CalculationReports) {
                    var key = calculationReport.Department.Id.ToString();
                    previousReportSettingsInvoiceNumber.Add(key, calculationReport.InvoiceNumber);
                    previousReportSettingsIgnoreInvoiceNumber.Add(key, calculationReport.IgnoreInvoiceNumber);
                }
            }

            var calculator = new Calculator(_controller.ImportResult);
            var reports = calculator.Calculate();
            if(_controller.CalculationReports != null) {
                foreach(var report in reports) {
                    var key = report.Department.Id.ToString();
                    report.InvoiceNumber = previousReportSettingsInvoiceNumber[key];
                    report.IgnoreInvoiceNumber = previousReportSettingsIgnoreInvoiceNumber[key];
                }
            }
            _controller.CalculationReports = reports;

            var simulations = RefreshSimulations();
            var tabPages = new List<TabPage>();

            if(_calculationReports != null) {
                foreach(var calculationReportControl in _calculationReports) {
                    calculationReportControl.IsValid -= CalculationReportControl_IsValid;
                    calculationReportControl.IsInValid -= CalculationReportControl_IsInValid;
                    calculationReportControl.Dispose();
                }
                _calculationReports = null;
            }
            _calculationReports = new List<CalculationReportControl>();            
            _validSate = new Dictionary<string, bool>();            

            foreach (var department in _controller.ImportResult.DepartmentRepository.GetDepartments().Where(d => !d.CanIgnore)) {
                var tabPage = new TabPage(department.Name);
                tabPage.BackColor = Color.White;

                var departmentSimulations = simulations.Where(sr => sr.Department.Id == department.Id).ToList();
                var simulationResultTabPage = new TabPage("Factuur Simulatie");
                simulationResultTabPage.Controls.Add(new SimulationResultControl(departmentSimulations));

                var calculationReportControl = new CalculationReportControl(reports.Where(r => r.Department.Id == department.Id).SingleOrDefault(), simulationResultTabPage);
                _validSate.Add(calculationReportControl.Report.Department.Id.ToString(), false);
                calculationReportControl.IsValid += CalculationReportControl_IsValid;
                calculationReportControl.IsInValid += CalculationReportControl_IsInValid;

                tabPage.Controls.Add(calculationReportControl);
                tabPages.Add(tabPage);
            }

            uxTabContainer.TabPages.Clear();
            foreach (var tabPage in tabPages) {
                uxTabContainer.TabPages.Add(tabPage);
            }

            uxTabContainer.Visible = true;
            uxProgressPanel.Visible = false;
        }

        private Dictionary<string, bool> _validSate = new Dictionary<string, bool>();

        private void CalculationReportControl_IsInValid(object sender, EventArgs e) {
            var report = (sender as CalculationReportControl);
            var key = report.Report.Department.Id.ToString();
            var value = false;
            if (!_validSate.ContainsKey(key)) {
                _validSate.Add(key, value);
            } else {
                _validSate[key] = value;
            }

            RefreshValidState();
        }

        private void CalculationReportControl_IsValid(object sender, EventArgs e) {
            var report = (sender as CalculationReportControl);
            var key = report.Report.Department.Id.ToString();
            var value = true;
            if (!_validSate.ContainsKey(key)) {
                _validSate.Add(key, value);
            }
            else {
                _validSate[key] = value;
            }

            RefreshValidState();
        }

        internal void RefreshValidState() {
            if (_validSate == null || _validSate.Keys.Count == 0) {
                RaiseIsValid();
            }

            if (_validSate.Values.Any(v => v == false)) {
                RaiseIsInValid();
            } else {
                RaiseIsValid();
            }
        }

        internal List<InvoiceSimulationResult> RefreshSimulations() {
            var simulator = new InvoiceSimulator();
            var simulations = simulator.Calculate(_controller.ImportResult);
            return simulations;         
        }
    }
}
