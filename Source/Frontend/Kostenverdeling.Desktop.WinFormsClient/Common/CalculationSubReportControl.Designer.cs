namespace Kostenverdeling.Desktop.WinFormsClient.Common
{
    partial class CalculationSubReportControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uxLog = new System.Windows.Forms.ListBox();
            this.uxDivisionView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // uxLog
            // 
            this.uxLog.FormattingEnabled = true;
            this.uxLog.Location = new System.Drawing.Point(180, 6);
            this.uxLog.Name = "uxLog";
            this.uxLog.Size = new System.Drawing.Size(507, 238);
            this.uxLog.TabIndex = 1;
            // 
            // uxDivisionView
            // 
            this.uxDivisionView.Location = new System.Drawing.Point(3, 6);
            this.uxDivisionView.Name = "uxDivisionView";
            this.uxDivisionView.Size = new System.Drawing.Size(171, 238);
            this.uxDivisionView.TabIndex = 2;
            this.uxDivisionView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uxDivisionView_AfterSelect);
            // 
            // CalculationSubReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxDivisionView);
            this.Controls.Add(this.uxLog);
            this.MaximumSize = new System.Drawing.Size(690, 250);
            this.MinimumSize = new System.Drawing.Size(690, 250);
            this.Name = "CalculationSubReportControl";
            this.Size = new System.Drawing.Size(690, 250);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox uxLog;
        private System.Windows.Forms.TreeView uxDivisionView;
    }
}
