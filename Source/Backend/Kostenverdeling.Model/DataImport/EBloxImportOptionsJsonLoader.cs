using Kostenverdeling.Model.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kostenverdeling.Model.DataImport
{
    public sealed class EBloxImportOptionsJsonLoader : IEBloxImportOptionsLoader
    {
        private FileInfo _jsonFile;

        public EBloxImportOptionsJsonLoader(FileInfo jsonFile) {
            if(!jsonFile.Exists) {
                throw new FileNotFoundException($"Het bestand {jsonFile.FullName} bestaat niet of kan niet geopend worden.");
            }

            _jsonFile = jsonFile;
        }

        public EBloxImportOptions Load() {
            var ebloxImportOptions = JsonConvert.DeserializeObject<EBloxImportOptions>(File.ReadAllText(_jsonFile.FullName));

            if (ebloxImportOptions.Departments == null) {
                ebloxImportOptions.Departments = new List<Department>();
            }
            if(ebloxImportOptions.DepartmentsToIgnore == null) {
                ebloxImportOptions.DepartmentsToIgnore = new List<string>();
            }
            if (ebloxImportOptions.TypesToInclude == null) {
                ebloxImportOptions.TypesToInclude = new List<string>();
            }

            foreach (var department in ebloxImportOptions.Departments) {
                department.IsUnknown = false;
                foreach(var division in department.Divisions) {
                    division.Department = department;
                    division.IsUnknown = false;
                }
            }            

            return ebloxImportOptions;
        }
    }
}
