using System.Collections.Generic;

namespace Kostenverdeling.Model.InvoiceSimulation
{
    public class InvoiceSectionLine
    {
        public InvoiceSectionLine() {
            TaxMultiplier = 0;
            IncludeOriginalValue = true;
        }

        public string Description { get; set; }
        public string InvoiceCode { get; set; }
        public List<string> CodesToInclude { get; set; }
        public List<string> CodesToIgnore { get; set; }
        public double TaxMultiplier { get; set; }
        public bool IncludeOriginalValue { get; set; }
    }
}
