using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kostenverdeling.Model.Calculation;

namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    public partial class CalculationSubReportControl : UserControl
    {
        public CalculationSubReportControl(List<CalculationSubReport> subReports) {
            InitializeComponent();            

            foreach (var subReport in subReports) {
                var treeNode = new TreeNode($"{subReport.Division.Name}: €{subReport.Value.ToString("0.00")}");
                treeNode.Tag = subReport.CalculationDiary;
                uxDivisionView.Nodes.Add(treeNode);
            }
        }

        private void uxDivisionView_AfterSelect(object sender, TreeViewEventArgs e) {
            if(uxDivisionView.SelectedNode != null) {
                uxLog.Items.Clear();
                foreach(var entry in (uxDivisionView.SelectedNode.Tag as List<string>)) {
                    uxLog.Items.Add(entry);
                }
            }
        }
    }
}
