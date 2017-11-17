using Kostenverdeling.Model.Common;
using System.Collections.Generic;

namespace Kostenverdeling.Model.DataImport
{
    public class EBloxImportOptions
    {
        public List<Department> Departments { get; set; }
        public List<string> DepartmentsToIgnore { get; set; }
        public List<string> TypesToInclude { get; set; }
        public List<AccountingDescription> AccountingDescriptions { get; set; }
    }
}
