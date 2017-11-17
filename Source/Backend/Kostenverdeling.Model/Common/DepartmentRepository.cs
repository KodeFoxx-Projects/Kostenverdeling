using System;
using System.Linq;
using System.Collections.Generic;
using Kostenverdeling.Model.DataImport;

namespace Kostenverdeling.Model.Common
{
    public sealed class DepartmentRepository : IDepartmentRepository
    {
        private List<Department> Departments { get; } = new List<Department>();
        private List<Division> Divisions => Departments.SelectMany(b => b.Divisions).ToList();
        private List<AccountingDescription> FallbackAccountingDescriptions { get; set; }

        public DepartmentRepository(IEnumerable<Department> departments = null) {
            if(departments != null) {
                Departments = departments.ToList();
            }
            FallbackAccountingDescriptions = new List<AccountingDescription>();
        }

        public Department GetDepartment(int id) {
            return Departments.Where(b => b.Id == id).SingleOrDefault();
        }

        public Department GetOrAddDepartment(int id, string name) {
            var department = GetDepartment(id);

            if(department == null) {                
                department = new Department {
                    Id = id,
                    Name = name,
                    Divisions = new List<Division>()
                };
                Departments.Add(department);
            } 

            return department;
        }

        public Division GetDivision(int id, Department department) {
            return Divisions.Where(d => d.Ids.Any(i => i == id) && d.Department.Id == department.Id).SingleOrDefault();
        }

        public Division GetDivision(int id, int departmentId) {
            return Divisions.Where(d => d.Ids.Any(i => i == id) && d.Department.Id == departmentId).SingleOrDefault();
        }        

        public Division GetOrAddDivision(int id, string name, int departmentId, string departmentName) {
            var division = GetDivision(id, departmentId);

            if(division == null) {
                var department = GetOrAddDepartment(departmentId, departmentName);
                division = new Division {
                    Department = department,                    
                    Name = name
                };
                division.Ids.Add(id);
                department.Divisions.Add(division);
            }

            return division;
        }

        public Division GetOrAddDivision(int id, string name, Department department) {
            return GetOrAddDivision(id, name, department.Id, department.Name);
        }

        public Department GetOrAddUnknownDepartment(int id, string name) {
            var department = GetOrAddDepartment(id, name);
            department.IsUnknown = true;
            return department;
        }

        public Division GetOrAddUnknownDivision(int id, string name, Department department) {
            return GetOrAddUnknownDivision(id, name, department.Id, department.Name);
        }

        public Division GetOrAddUnknownDivision(int id, string name, int departmentId, string departmentName) {
            var division = GetOrAddDivision(id, name, departmentId, departmentName);
            division.IsUnknown = true;
            return division;
        }

        public IEnumerable<Department> GetDepartments() {
            return Departments.ToList();
        }

        public IEnumerable<Division> GetDivisions() {
            return Divisions.ToList();
        }

        public AccountingDescription GetAccountingDescription(string category, int divisionId, int departmentId) {
            AccountingDescription accountingDescription = null;

            try {
                accountingDescription =
                    GetDivisions().Where(d => d.Department.Id == departmentId && d.Id == divisionId)
                    .SingleOrDefault()
                    ?.AccountingDescriptions
                    .Where(ad => ad.Category == category)
                    .SingleOrDefault();
            } catch(Exception ex) {
                // throw new Exception($"{ex.Message}. On GetDivisions() => Where category='{category}', divisionId='{divisionId}' and departmentId='{departmentId}'", ex);
            }

            try {
                if (accountingDescription == null) {
                    accountingDescription = FallbackAccountingDescriptions.
                        Where(ad => ad.Category == category)
                        .SingleOrDefault();
                }
            }
            catch (Exception ex) {
                // throw new Exception($"{ex.Message}. On FallbackAccountingDescriptions => Where category='{category}', divisionId='{divisionId}' and departmentId='{departmentId}'", ex);
            }

           try {
                if (accountingDescription == null) {
                    accountingDescription = new AccountingDescription {
                        Category = category,
                        Description = divisionId.ToString()
                    };
                }
            }
            catch (Exception ex) {
                // throw new Exception($"{ex.Message}. On FallbackAccountingDescriptions => Where category='{category}', divisionId='{divisionId}' and departmentId='{departmentId}'", ex);
            }

            if (accountingDescription == null) {
                accountingDescription = new AccountingDescription {
                    Category = category,
                    Description = "??? (nog manueel in te vullen)"
                };
            }

            return accountingDescription;
        }

        public AccountingDescription GetAccountingDescription(string category, int divisionId, Department department) {
            return GetAccountingDescription(category, divisionId, department.Id);
        }

        public AccountingDescription GetAccountingDescription(string category, Division division) {
            return GetAccountingDescription(category, division.Id, division.Department.Id);
        }

        public void AddFallbackAccountingDescriptions(IEnumerable<AccountingDescription> accountingDescriptions) {
            FallbackAccountingDescriptions.AddRange(accountingDescriptions);
        }
    }
}
