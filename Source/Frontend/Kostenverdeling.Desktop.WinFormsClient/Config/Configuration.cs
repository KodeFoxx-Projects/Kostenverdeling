using Kostenverdeling.Desktop.WinFormsClient.Common;
using Kostenverdeling.Model;
using Kostenverdeling.Model.Settings;
using System.Reflection;
using System;
using System.Windows.Forms;
using System.IO;
using Kostenverdeling.Model.DataImport;
using Kostenverdeling.Model.Common;

namespace Kostenverdeling.Desktop.WinFormsClient.Config
{
    public partial class Configuration : MasterForm
    {
        ApplicationSettings _applicationSettings;
        EBloxImportOptionsJsonLoader _ebloxImportOptionsLoader;
        EBloxImportOptions _ebloxImportOptions;

        public Configuration() {
            InitializeComponent();

            _applicationSettings = ApplicationSettings.Current;
            _ebloxImportOptionsLoader = new EBloxImportOptionsJsonLoader(new FileInfo("Settings/EBloxImportOptions.json"));
            SetupApplicationSettings();
            SetupEbloxImportOptions();

            this.Text = this.Text.Replace("%version%", $"{Utils.RenderVersion(Assembly.GetEntryAssembly())}");
            __applicationName.Text = $"Instellingen {__applicationName.Text }";            
        }

        private void SetupEbloxImportOptions() {
            _ebloxImportOptions = _ebloxImportOptionsLoader.Load();
            FillEbloxImportOptions();
        }

        private void FillEbloxImportOptions() {
            uxDepartments.DataSource = _ebloxImportOptions.Departments;
            uxDepartments.SelectedIndexChanged += (x, y) => {
                uxDivisions.DataSource = ((Department)uxDepartments.SelectedItem).Divisions;
                FillDepartmentDetails(((Department)uxDepartments.SelectedItem));
            };

            uxDivisions.SelectedIndexChanged += (x, y) => {
                FillDivisionDetails(((Division)uxDivisions.SelectedItem));
            };

            uxDepartments.SelectedIndex = 0;
            uxDivisions.DataSource = ((Department)uxDepartments.SelectedItem).Divisions;
            FillDepartmentDetails(((Department)uxDepartments.SelectedItem));
        }

        private void FillDivisionDetails(Division selectedItem) {
            uxDivisionIds.Text = String.Join(", ", selectedItem.Ids);
            uxDivisionName.Text = selectedItem.Name;
        }

        private void FillDepartmentDetails(Department selectedItem) {
            uxDepartmentId.Text = selectedItem.Id.ToString();
            uxDepartmentName.Text = selectedItem.Name;            
        }

        private void SetupApplicationSettings() {
            FillApplicationSettings();
            uxDefaultExportLocationButton.Click += (x, y) => {
                using (var browseFolderDialog = new FolderBrowserDialog() {
                    SelectedPath = uxDefaultExportLocationButton.Text,
                    ShowNewFolderButton = true
                }) {
                    var result = browseFolderDialog.ShowDialog();
                    if(result == DialogResult.OK && Directory.Exists(browseFolderDialog.SelectedPath)) {
                        uxDefaultExportLocation.Text = browseFolderDialog.SelectedPath;
                        _applicationSettings.DefaultExportLocation = uxDefaultExportLocation.Text;
                        ApplicationSettings.Save(_applicationSettings);
                    } else {
                        MessageBox.Show(this, $"Het opgegeven pad '{browseFolderDialog.SelectedPath}' bestaat niet, of u bent niet gemachtigd om dit pad te gebruiken.", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };
        }

        private void FillApplicationSettings() {
            uxDefaultExportLocation.Text = ApplicationSettings.Current.DefaultExportLocation;
        }

        private void uxOk_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
