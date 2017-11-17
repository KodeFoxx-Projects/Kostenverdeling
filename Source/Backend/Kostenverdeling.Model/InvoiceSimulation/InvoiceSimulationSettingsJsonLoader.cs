using Kostenverdeling.Model.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kostenverdeling.Model.InvoiceSimulation
{
    public class InvoiceSimulationSettingsJsonLoader : IInvoiceSimulationSettingsLoader
    {
        private FileInfo _jsonFile;

        public InvoiceSimulationSettingsJsonLoader(FileInfo jsonFile) {
            if (!jsonFile.Exists) {
                throw new FileNotFoundException($"Het bestand {jsonFile.FullName} bestaat niet of kan niet geopend worden.");
            }

            _jsonFile = jsonFile;
        }

        public InvoiceSimulationSettings Load() {
            var invoiceSimulationSettings = JsonConvert.DeserializeObject<InvoiceSimulationSettings>(File.ReadAllText(_jsonFile.FullName));            

            foreach(var line in invoiceSimulationSettings.InvoiceSections.SelectMany(s => s.InvoiceSectionLines)) {
                if(line.CodesToInclude == null || line.CodesToInclude?.Count == 0) {
                    line.CodesToInclude = new List<String>();
                    line.CodesToInclude.Add($"{line.InvoiceCode}*");
                }
                if(line.CodesToIgnore == null) {
                    line.CodesToIgnore = new List<string>();
                }
            }

            return invoiceSimulationSettings;
        }
    }
}
