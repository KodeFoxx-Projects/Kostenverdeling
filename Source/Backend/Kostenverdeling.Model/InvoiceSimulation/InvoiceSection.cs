using System.Collections.Generic;

namespace Kostenverdeling.Model.InvoiceSimulation
{
    public class InvoiceSection
    {
        public string Name { get; set; }
        public List<InvoiceSectionLine> InvoiceSectionLines { get; set; }
    }
}
