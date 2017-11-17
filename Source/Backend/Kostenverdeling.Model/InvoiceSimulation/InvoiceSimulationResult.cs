using Kostenverdeling.Model.Common;
using System.Collections.Generic;

namespace Kostenverdeling.Model.InvoiceSimulation
{
    public class InvoiceSimulationResult
    {
        public Department Department { get; set; }
        public InvoiceSectionLine Line { get; set; }
        public double Value { get; set; }
    }
}
