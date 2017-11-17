using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostenverdeling.Model.Settings
{
    public class CalculationSettingsJsonLoader : ICalculationSettingsLoader
    {
        private FileInfo _jsonFile;

        public CalculationSettingsJsonLoader(FileInfo jsonFile) {
            if (!jsonFile.Exists) {
                throw new FileNotFoundException($"Het bestand {jsonFile.FullName} bestaat niet of kan niet geopend worden.");
            }

            _jsonFile = jsonFile;
        }

        public CalculationSettings Load() {
            var calculationSettings = JsonConvert.DeserializeObject<CalculationSettings>(File.ReadAllText(_jsonFile.FullName));

            if(calculationSettings.AdvanceTaxPayment.CodesToIgnore == null) {
                calculationSettings.AdvanceTaxPayment.CodesToIgnore = new List<string>();
            }
            if (calculationSettings.ManagementCosts.CodesToIgnore == null) {
                calculationSettings.ManagementCosts.CodesToIgnore = new List<string>();
            }
            if (calculationSettings.SocialSecurity.CodesToIgnore == null) {
                calculationSettings.SocialSecurity.CodesToIgnore = new List<string>();
            }
            if (calculationSettings.SocialSecurityProvision.CodesToIgnore == null) {
                calculationSettings.SocialSecurityProvision.CodesToIgnore = new List<string>();
            }
            if (calculationSettings.WageGarnishmentManagement.CodesToIgnore == null) {
                calculationSettings.WageGarnishmentManagement.CodesToIgnore = new List<string>();
            }

            return calculationSettings;
        }
    }
}
