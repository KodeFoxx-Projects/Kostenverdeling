using Kostenverdeling.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostenverdeling.Model.DataImport
{
    /// <summary>
    /// Represents an imported e-blox record.
    /// </summary>
    public sealed class EBloxRecord {
        public int Group { get; set; }
        public Division Division { get; set; }
        public string OriginalDivisionId { get; set; }
        public Department Department => Division.Department;
        public Employee Employee { get; set; }
        public CostCategory Category { get; set; }
        public double Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Type { get; set; }        
    }
}
