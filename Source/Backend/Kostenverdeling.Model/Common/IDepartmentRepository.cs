using System.Collections.Generic;

namespace Kostenverdeling.Model.Common
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int id);
        Department GetOrAddDepartment(int id, string name);
        Department GetOrAddUnknownDepartment(int id, string name);

        IEnumerable<Division> GetDivisions();
        Division GetDivision(int id, Department department);
        Division GetDivision(int id, int departmentId);
        Division GetOrAddDivision(int id, string name, Department businessDepartment);
        Division GetOrAddDivision(int id, string name, int businessDepartmentId, string businessDepartmentName);
        Division GetOrAddUnknownDivision(int id, string name, Department businessDepartment);
        Division GetOrAddUnknownDivision(int id, string name, int businessDepartmentId, string businessDepartmentName);

        AccountingDescription GetAccountingDescription(string category, int divisionId, int departmentId);
        AccountingDescription GetAccountingDescription(string category, int divisionId, Department department);
        AccountingDescription GetAccountingDescription(string category, Division division);
        void AddFallbackAccountingDescriptions(IEnumerable<AccountingDescription> accountingDescriptions);
    }
}
