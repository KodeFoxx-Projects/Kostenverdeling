using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostenverdeling.Model.Settings
{
    public class CalculationSettingsElement
    {
        public string Name { get; set; }
        public List<string> Codes { get; set; }
        public List<string> CodesToIgnore { get; set; }
        public double TaxMultiplier { get; set; }
        public bool IncludeInExcelReport { get; set; }
        public bool IncludeInTotalsExcelReport { get; set; }
        public bool IncludeInExcelDetailReport { get; set; }
    }
}
