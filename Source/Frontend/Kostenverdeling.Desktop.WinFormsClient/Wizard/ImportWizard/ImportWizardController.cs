using Kostenverdeling.Model.Calculation;
using Kostenverdeling.Model.DataImport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public class ImportWizardController : WizardController
    {
        public ImportWizardController()            
        {
            ExportDone = false;

            this.AddStep(new ImportWizardStep01_Welcome(this));
            this.AddStep(new ImportWizardStep02_SelectExcelFile(this));            
            this.AddStep(new ImportWizardStep03_CalculationsOverview(this));
            this.AddStep(new ImportWizardStep04_ExportToExcel(this));
        }

        internal EBloxImportResult ImportResult { get; set; }
        internal List<CalculationReport> CalculationReports { get; set; }
        public DirectoryInfo ExportDirectory { get; set; }
        public bool ExportDone { get; set; }
    }
}
