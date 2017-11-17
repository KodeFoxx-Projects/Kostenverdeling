namespace Kostenverdeling.Desktop.WinFormsClient.Config
{
    partial class Configuration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uxOk = new System.Windows.Forms.Button();
            this.uxTab = new System.Windows.Forms.TabControl();
            this.uxApplicationSettings = new System.Windows.Forms.TabPage();
            this.uxDefaultExportLocationButton = new System.Windows.Forms.Button();
            this.uxDefaultExportLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxBedrijvenEnProjecten = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.uxDivisionName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uxDivisionIds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uxDepartmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxDepartmentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxDivisions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxDepartments = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.___contentBody.SuspendLayout();
            this.___footerBody.SuspendLayout();
            this.uxTab.SuspendLayout();
            this.uxApplicationSettings.SuspendLayout();
            this.uxBedrijvenEnProjecten.SuspendLayout();
            this.SuspendLayout();
            // 
            // ___contentBody
            // 
            this.___contentBody.Controls.Add(this.uxTab);
            this.___contentBody.Size = new System.Drawing.Size(1063, 551);
            // 
            // ___footerBody
            // 
            this.___footerBody.Controls.Add(this.uxOk);
            this.___footerBody.Location = new System.Drawing.Point(0, 641);
            // 
            // uxOk
            // 
            this.uxOk.Location = new System.Drawing.Point(972, 19);
            this.uxOk.Margin = new System.Windows.Forms.Padding(4);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(100, 28);
            this.uxOk.TabIndex = 6;
            this.uxOk.Text = "Ok";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // uxTab
            // 
            this.uxTab.Controls.Add(this.uxApplicationSettings);
            this.uxTab.Controls.Add(this.uxBedrijvenEnProjecten);
            this.uxTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTab.Location = new System.Drawing.Point(0, 0);
            this.uxTab.Name = "uxTab";
            this.uxTab.SelectedIndex = 0;
            this.uxTab.Size = new System.Drawing.Size(1063, 551);
            this.uxTab.TabIndex = 0;
            // 
            // uxApplicationSettings
            // 
            this.uxApplicationSettings.Controls.Add(this.uxDefaultExportLocationButton);
            this.uxApplicationSettings.Controls.Add(this.uxDefaultExportLocation);
            this.uxApplicationSettings.Controls.Add(this.label1);
            this.uxApplicationSettings.Location = new System.Drawing.Point(4, 25);
            this.uxApplicationSettings.Name = "uxApplicationSettings";
            this.uxApplicationSettings.Padding = new System.Windows.Forms.Padding(3);
            this.uxApplicationSettings.Size = new System.Drawing.Size(1055, 522);
            this.uxApplicationSettings.TabIndex = 1;
            this.uxApplicationSettings.Text = "Algemeen";
            this.uxApplicationSettings.UseVisualStyleBackColor = true;
            // 
            // uxDefaultExportLocationButton
            // 
            this.uxDefaultExportLocationButton.Location = new System.Drawing.Point(948, 29);
            this.uxDefaultExportLocationButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxDefaultExportLocationButton.Name = "uxDefaultExportLocationButton";
            this.uxDefaultExportLocationButton.Size = new System.Drawing.Size(100, 28);
            this.uxDefaultExportLocationButton.TabIndex = 6;
            this.uxDefaultExportLocationButton.Text = "Bladeren...";
            this.uxDefaultExportLocationButton.UseVisualStyleBackColor = true;
            // 
            // uxDefaultExportLocation
            // 
            this.uxDefaultExportLocation.Location = new System.Drawing.Point(9, 32);
            this.uxDefaultExportLocation.Name = "uxDefaultExportLocation";
            this.uxDefaultExportLocation.ReadOnly = true;
            this.uxDefaultExportLocation.Size = new System.Drawing.Size(932, 22);
            this.uxDefaultExportLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standaard export locatie:";
            // 
            // uxBedrijvenEnProjecten
            // 
            this.uxBedrijvenEnProjecten.Controls.Add(this.label8);
            this.uxBedrijvenEnProjecten.Controls.Add(this.button3);
            this.uxBedrijvenEnProjecten.Controls.Add(this.button4);
            this.uxBedrijvenEnProjecten.Controls.Add(this.uxDivisionName);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label6);
            this.uxBedrijvenEnProjecten.Controls.Add(this.uxDivisionIds);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label7);
            this.uxBedrijvenEnProjecten.Controls.Add(this.button2);
            this.uxBedrijvenEnProjecten.Controls.Add(this.button1);
            this.uxBedrijvenEnProjecten.Controls.Add(this.uxDepartmentName);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label5);
            this.uxBedrijvenEnProjecten.Controls.Add(this.uxDepartmentId);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label4);
            this.uxBedrijvenEnProjecten.Controls.Add(this.uxDivisions);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label3);
            this.uxBedrijvenEnProjecten.Controls.Add(this.uxDepartments);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label2);
            this.uxBedrijvenEnProjecten.Controls.Add(this.label9);
            this.uxBedrijvenEnProjecten.Location = new System.Drawing.Point(4, 25);
            this.uxBedrijvenEnProjecten.Name = "uxBedrijvenEnProjecten";
            this.uxBedrijvenEnProjecten.Padding = new System.Windows.Forms.Padding(3);
            this.uxBedrijvenEnProjecten.Size = new System.Drawing.Size(1055, 522);
            this.uxBedrijvenEnProjecten.TabIndex = 2;
            this.uxBedrijvenEnProjecten.Text = "Bedrijven & Projecten";
            this.uxBedrijvenEnProjecten.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "-------------------------------------";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 427);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(435, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Geselecteerd project aanpassen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 463);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(435, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "Nieuw project aanmaken";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // uxDivisionName
            // 
            this.uxDivisionName.Location = new System.Drawing.Point(613, 129);
            this.uxDivisionName.Name = "uxDivisionName";
            this.uxDivisionName.Size = new System.Drawing.Size(436, 22);
            this.uxDivisionName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Naam:";
            // 
            // uxDivisionIds
            // 
            this.uxDivisionIds.Location = new System.Drawing.Point(613, 84);
            this.uxDivisionIds.Name = "uxDivisionIds";
            this.uxDivisionIds.Size = new System.Drawing.Size(436, 22);
            this.uxDivisionIds.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(610, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ids (gescheiden door komma, bvb: 4300, 4800, 4500):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 427);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Geselecteerd bedrijf aanpassen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nieuw bedrijf aanmaken";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uxDepartmentName
            // 
            this.uxDepartmentName.Location = new System.Drawing.Point(24, 396);
            this.uxDepartmentName.Name = "uxDepartmentName";
            this.uxDepartmentName.Size = new System.Drawing.Size(264, 22);
            this.uxDepartmentName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Naam:";
            // 
            // uxDepartmentId
            // 
            this.uxDepartmentId.Location = new System.Drawing.Point(24, 351);
            this.uxDepartmentId.Name = "uxDepartmentId";
            this.uxDepartmentId.Size = new System.Drawing.Size(264, 22);
            this.uxDepartmentId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id:";
            // 
            // uxDivisions
            // 
            this.uxDivisions.FormattingEnabled = true;
            this.uxDivisions.ItemHeight = 16;
            this.uxDivisions.Location = new System.Drawing.Point(311, 64);
            this.uxDivisions.Name = "uxDivisions";
            this.uxDivisions.Size = new System.Drawing.Size(293, 436);
            this.uxDivisions.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projecten:";
            // 
            // uxDepartments
            // 
            this.uxDepartments.FormattingEnabled = true;
            this.uxDepartments.ItemHeight = 16;
            this.uxDepartments.Location = new System.Drawing.Point(9, 32);
            this.uxDepartments.Name = "uxDepartments";
            this.uxDepartments.Size = new System.Drawing.Size(296, 292);
            this.uxDepartments.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bedrijven:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "|";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 703);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Configuration";
            this.Text = "Verdeling Facturatie [ Elegast vzw ] - v%version%";
            this.___contentBody.ResumeLayout(false);
            this.___footerBody.ResumeLayout(false);
            this.uxTab.ResumeLayout(false);
            this.uxApplicationSettings.ResumeLayout(false);
            this.uxApplicationSettings.PerformLayout();
            this.uxBedrijvenEnProjecten.ResumeLayout(false);
            this.uxBedrijvenEnProjecten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxOk;
        private System.Windows.Forms.TabControl uxTab;
        private System.Windows.Forms.TabPage uxApplicationSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxDefaultExportLocationButton;
        private System.Windows.Forms.TextBox uxDefaultExportLocation;
        private System.Windows.Forms.TabPage uxBedrijvenEnProjecten;
        private System.Windows.Forms.ListBox uxDivisions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox uxDepartments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxDepartmentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxDepartmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox uxDivisionName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxDivisionIds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}