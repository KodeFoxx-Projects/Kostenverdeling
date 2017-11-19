using Kostenverdeling.Model.Common;
using System;
using System.Collections.Generic;

namespace Kostenverdeling.Model.Calculation
{
    public class CalculationReport
    {
        public Department Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }   
        public string OriginalInvoiceTotal { get; set; }        

        public List<CalculationSubReport> SubReports { get; set; }
    }
}
