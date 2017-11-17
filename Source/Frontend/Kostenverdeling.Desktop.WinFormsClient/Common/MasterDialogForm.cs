using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    public partial class MasterDialogForm : Form
    {

        public DialogResult Result { get; private set; }

        public static Color ElegastGreen { get { return Color.FromArgb(0, 154, 66); } }
        public static Color ElegastWhiteOnGreen { get { return Color.White; } }

        public static Color Question { get { return Color.FromArgb(153, 153, 0); ; } }
        public static Color QuestionWhiteOnDarkYellow { get { return Color.White; } }

        public static Color Error { get { return Color.DarkRed; } }
        public static Color ErrorWhiteOnDarkRed { get { return Color.White; } }

        public static Color Info { get { return Color.DarkBlue; } }
        public static Color InfoWhiteOnDarkBlue { get { return Color.White; } }

        private Color? _headerColor;
        public Color? HeaderColor {
            get { return _headerColor; }
            set {
                _headerColor = value;
                Visualise();
            }
        }
        private Color? _headerTitleColor;
        public Color? HeaderTitleColor {
            get { return _headerTitleColor; }
            set {
                _headerTitleColor = value;
                Visualise();
            }
        }
        private string _headerTitle;
        public String HeaderTitle {
            get { return _headerTitle; }
            set {
                _headerTitle = value;
                Visualise();
            }
        }        
        public Label InfoText { get { return this.uxTextInfo; } }

        private bool _showCancelButton = false;
        private Form _parent;        

        public void AppendText(string text) {
            uxTextInfo.Text += text;
            Visualise();
        }

        public MasterDialogForm(Form parent, bool showCancelButton = false) {
            InitializeComponent();

            _showCancelButton = showCancelButton;            
            _parent = parent;
            uxTextInfo.Text = "";            

            Result = DialogResult.None;

            Visualise();
        }        

        private void Visualise() {

            ___headerBody.BackColor = HeaderColor.HasValue ? HeaderColor.Value : ElegastGreen;
            ___headerBar.BackColor = HeaderColor.HasValue ? HeaderColor.Value : ElegastGreen;
            __applicationName.Text = HeaderTitle;
            __applicationName.BackColor = HeaderColor.HasValue ? HeaderColor.Value : ElegastGreen;
            __applicationName.ForeColor = HeaderTitleColor.HasValue ? HeaderTitleColor.Value : ElegastWhiteOnGreen;
            uxCancel.Visible = _showCancelButton;
            Text = _parent.Text;
            Height = 199 + uxTextInfo.Height;
            Width = 771;

            uxCopyToClipboard.Visible = __applicationName.BackColor == Error;

            this.CenterToScreen();
        }

        private void uxOk_Click(object sender, EventArgs e) {
            Result = DialogResult.OK;
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e) {
            Result = DialogResult.Cancel;
            Close();
        }

        private void uxTextInfo_Enter(object sender, EventArgs e) {
            Cursor = Cursors.Default;
            __applicationName.Focus();            
        }

        private void uxTextInfo_Leave(object sender, EventArgs e) {
            Cursor = Cursors.Default;
        }

        private void uxTextInfo_TextChanged(object sender, EventArgs e) {
            //Visualise();
        }

        private void uxCopyToClipboard_Click(object sender, EventArgs e) {            
            Clipboard.SetText(uxTextInfo.Text);

            using (var dialog = new MasterDialogForm(this) {
                HeaderColor = MasterDialogForm.Info,
                HeaderTitleColor = MasterDialogForm.InfoWhiteOnDarkBlue,
                HeaderTitle = "Foutmelding gekopieerd naar klembord"
            }) {
                dialog.AppendText($"De foutmelding werd gekopieerd naar het klembord (via plakken of de toetsencombinatie CTRL+V kan u de tekst in een word-document, e-mail plakken).{Environment.NewLine}Mogen wij u verzoeken deze informatie te delen met de applicatieontwikkelaar, eventueel met een screenshot en een korte beschrijving van de actie die u aan het uitvoeren was.");
                dialog.ShowDialog(this);                
            }
        }
    }
}
