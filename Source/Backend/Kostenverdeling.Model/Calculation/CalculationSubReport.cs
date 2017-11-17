using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.DataImport;
using Kostenverdeling.Model.Settings;
using System.Collections.Generic;

namespace Kostenverdeling.Model.Calculation
{
    public class CalculationSubReport {
        public CalculationSubReport() {
            CalculationDiary = new List<string>();
            EBloxRecordDiary = new Dictionary<int, EBloxRecord>();
        }

        public string Category { get; set; }
        public double CategoryTaxMultiplier { get; set; }
        public CalculationSettingsElement CategoryElement { get; set; }
        public bool IncludeInExcelReport { get; set; }
        public bool IncludeInExcelDetailReport { get; set; }
        public Division Division { get; set; }
        public double Value { get; set; }
        public List<string> CalculationDiary { get; }
        public Dictionary<int, EBloxRecord> EBloxRecordDiary { get; }

        public void AddEBloxRecord(EBloxRecord record) {
            var cnt = EBloxRecordDiary.Keys.Count + 1;
            EBloxRecordDiary.Add(cnt, record);
        }
    }
}
