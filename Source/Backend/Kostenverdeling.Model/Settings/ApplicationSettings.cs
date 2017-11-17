using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostenverdeling.Model.Settings
{
    public class ApplicationSettings
    {
        private static ApplicationSettings _current = null;
        public static ApplicationSettings Current {
            get {
                if (_current == null) {
                    _current = Load(new FileInfo(@"Settings\ApplicationSettings.json"));
                }
                return _current;
            }
            set {
                _current = value;
                Save();
            }
        }

        public static ApplicationSettings Load(FileInfo jsonFile) {
            if (!jsonFile.Exists) {
                throw new FileNotFoundException($"Het bestand {jsonFile.FullName} bestaat niet of kan niet geopend worden.");
            }

            return JsonConvert.DeserializeObject<ApplicationSettings>(File.ReadAllText(jsonFile.FullName));            
        }

        public static void Save(ApplicationSettings applicationSettings = null, FileInfo jsonFile = null) {
            var settings = applicationSettings == null
                ? Current
                : applicationSettings;
            var file = jsonFile == null
                ? new FileInfo(@"Settings\ApplicationSettings.json")
                : jsonFile;

            File.WriteAllText(file.FullName, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }

        public string DefaultExportLocation { get; set; }
    }
}
