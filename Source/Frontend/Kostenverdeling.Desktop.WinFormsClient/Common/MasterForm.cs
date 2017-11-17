using Kostenverdeling.Desktop.WinFormsClient.Properties;
using Kostenverdeling.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    public partial class MasterForm : Form
    {
        public MasterForm() {
            InitializeComponent();                                   

            ___headerLogo.Image = null;
            ___headerLogo.BackColor = Color.FromArgb(0, 154, 66);
            __applicationName.Text = Application.ProductName.Trim();            
            __applicationVersion.Text = $"  v.{Utils.RenderVersion(Assembly.GetEntryAssembly())}";
            __applicationName.BackColor = Color.FromArgb(0, 154, 66);
            __applicationVersion.BackColor = Color.FromArgb(0, 154, 66);
            ___headerBar.BackColor = Color.FromArgb(0, 154, 66);            

        }

        private void MasterForm_Resize(object sender, EventArgs e) {
            ___headerBar.Width = this.Width;
            ___footerSplitter.Width = this.Width + 1;
            ___headerSplitter.Width = this.Width + 1;
        }
    }
}
