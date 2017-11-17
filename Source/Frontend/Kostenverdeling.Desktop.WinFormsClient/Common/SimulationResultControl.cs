using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kostenverdeling.Model.InvoiceSimulation;

namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    public partial class SimulationResultControl : UserControl
    {
        private readonly List<InvoiceSimulationResult> _results;

        public SimulationResultControl(List<InvoiceSimulationResult> results) {
            InitializeComponent();

            _results = results;
            VisualiseResult();
        }

        private void VisualiseResult() {
            uxInvoiceSimulation.Visible = false;
            var i = 1;
            foreach(var line in _results) {
                uxInvoiceSimulation.Rows.Add(                    
                    line.Line.InvoiceCode,
                    line.Line.Description,
                    line.Value.ToString("0.00")
                );
                if(i % 2 == 0) {
                    uxInvoiceSimulation.Rows[i-1].DefaultCellStyle.BackColor = Color.LightGray;
                }

                if (line.Value != 0) {
                    if (line.Value < 0) {
                        uxInvoiceSimulation.Rows[i - 1].Cells[0].Style.ForeColor = Color.DarkRed;
                        uxInvoiceSimulation.Rows[i - 1].Cells[1].Style.ForeColor = Color.DarkRed;
                        uxInvoiceSimulation.Rows[i - 1].Cells[2].Style.ForeColor = Color.DarkRed;
                    }
                    else {
                        uxInvoiceSimulation.Rows[i - 1].Cells[0].Style.ForeColor = Color.DarkGreen;
                        uxInvoiceSimulation.Rows[i - 1].Cells[1].Style.ForeColor = Color.DarkGreen;
                        uxInvoiceSimulation.Rows[i - 1].Cells[2].Style.ForeColor = Color.DarkGreen;
                    }
                }

                i++;
            }
            uxInvoiceSimulation.Visible = true;
        }
    }
}
