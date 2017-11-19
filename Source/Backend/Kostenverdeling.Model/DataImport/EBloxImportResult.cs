using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.Settings;
using Kostenverdeling.Model.InvoiceSimulation;

namespace Kostenverdeling.Model.DataImport
{
    public sealed class EBloxImportResult {

        public EBloxImportResult() {
        }

        public FileInfo OriginalImportFile { get; internal set; }

        public EBloxImportOptions ImportOptions { get; internal set; }
        public CalculationSettings CalculationSettings { get; internal set; }
        public InvoiceSimulationSettings InvoiceSimulationSettings { get; set; }

        public List<EBloxRecord> Records { get; set; }
        public List<Department> UnknownDepartments => Records.Select(r => r.Department).Distinct().Where(d => d.IsUnknown).ToList();
        public bool HasUnknownDepartments => UnknownDepartments.Count() != 0;
        public List<Division> UnknownDivisions => Records.Select(r => r.Division).Where(d => d.IsUnknown).ToList();
        public bool HasUnknownDivisions => UnknownDivisions.Count() != 0;
        public DateTime StartDate => Records.Select(r => r.StartDate).Min();
        public DateTime StartDateCorrection { get; set; }
        public DateTime EndDate => Records.Select(r => r.EndDate).Max();
        public DateTime EndDateCorrection { get; set; }
        public List<DateTime> InvoiceDates => Records.Select(r => r.InvoiceDate).Distinct().ToList();
        public DateTime MostFrequentInvoiceDate => Records.Select(r => r.InvoiceDate)
            .GroupBy(d => d)
            .OrderByDescending(g => g.Count())
            .Take(1)
            .Select(g => g.Key)
            .SingleOrDefault();
        public DateTime SelectedInvoiceDate { get; set; }
        

        public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public ICostCategoryRepository CostCategoryRepository { get; set; }
    }
}
