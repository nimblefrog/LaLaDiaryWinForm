namespace LaLaDiary
{
    partial class DailyRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTargetP = new System.Windows.Forms.Label();
            this.lbTargetF = new System.Windows.Forms.Label();
            this.lbTargetC = new System.Windows.Forms.Label();
            this.lbTargetCal = new System.Windows.Forms.Label();
            this.lbTodayP = new System.Windows.Forms.Label();
            this.lbTodayF = new System.Windows.Forms.Label();
            this.lbTodayC = new System.Windows.Forms.Label();
            this.lbTodayCal = new System.Windows.Forms.Label();
            this.lbSurplusP = new System.Windows.Forms.Label();
            this.lbSurplusF = new System.Windows.Forms.Label();
            this.lbSurplusC = new System.Windows.Forms.Label();
            this.lbSurplusCal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRecord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.UnitP,
            this.UnitF,
            this.UnitC,
            this.UnitCal,
            this.Unit,
            this.TotalP,
            this.TotalF,
            this.TotalC,
            this.TotalCal});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(3, 102);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowTemplate.Height = 24;
            this.dgvRecord.Size = new System.Drawing.Size(704, 294);
            this.dgvRecord.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.90636F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.09363F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 93);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 87);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTargetP, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbTargetF, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbTargetC, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbTargetCal, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbTodayP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTodayF, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTodayC, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTodayCal, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbSurplusP, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbSurplusF, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbSurplusC, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbSurplusCal, 4, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(521, 87);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "目標";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "今日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "剩餘";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "蛋白質";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "脂肪";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "碳水";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "熱量";
            // 
            // lbTargetP
            // 
            this.lbTargetP.AutoSize = true;
            this.lbTargetP.Location = new System.Drawing.Point(107, 21);
            this.lbTargetP.Name = "lbTargetP";
            this.lbTargetP.Size = new System.Drawing.Size(11, 12);
            this.lbTargetP.TabIndex = 7;
            this.lbTargetP.Text = "0";
            // 
            // lbTargetF
            // 
            this.lbTargetF.AutoSize = true;
            this.lbTargetF.Location = new System.Drawing.Point(211, 21);
            this.lbTargetF.Name = "lbTargetF";
            this.lbTargetF.Size = new System.Drawing.Size(11, 12);
            this.lbTargetF.TabIndex = 8;
            this.lbTargetF.Text = "0";
            // 
            // lbTargetC
            // 
            this.lbTargetC.AutoSize = true;
            this.lbTargetC.Location = new System.Drawing.Point(315, 21);
            this.lbTargetC.Name = "lbTargetC";
            this.lbTargetC.Size = new System.Drawing.Size(11, 12);
            this.lbTargetC.TabIndex = 9;
            this.lbTargetC.Text = "0";
            // 
            // lbTargetCal
            // 
            this.lbTargetCal.AutoSize = true;
            this.lbTargetCal.Location = new System.Drawing.Point(419, 21);
            this.lbTargetCal.Name = "lbTargetCal";
            this.lbTargetCal.Size = new System.Drawing.Size(11, 12);
            this.lbTargetCal.TabIndex = 10;
            this.lbTargetCal.Text = "0";
            // 
            // lbTodayP
            // 
            this.lbTodayP.AutoSize = true;
            this.lbTodayP.Location = new System.Drawing.Point(107, 42);
            this.lbTodayP.Name = "lbTodayP";
            this.lbTodayP.Size = new System.Drawing.Size(11, 12);
            this.lbTodayP.TabIndex = 11;
            this.lbTodayP.Text = "0";
            // 
            // lbTodayF
            // 
            this.lbTodayF.AutoSize = true;
            this.lbTodayF.Location = new System.Drawing.Point(211, 42);
            this.lbTodayF.Name = "lbTodayF";
            this.lbTodayF.Size = new System.Drawing.Size(11, 12);
            this.lbTodayF.TabIndex = 12;
            this.lbTodayF.Text = "0";
            // 
            // lbTodayC
            // 
            this.lbTodayC.AutoSize = true;
            this.lbTodayC.Location = new System.Drawing.Point(315, 42);
            this.lbTodayC.Name = "lbTodayC";
            this.lbTodayC.Size = new System.Drawing.Size(11, 12);
            this.lbTodayC.TabIndex = 13;
            this.lbTodayC.Text = "0";
            // 
            // lbTodayCal
            // 
            this.lbTodayCal.AutoSize = true;
            this.lbTodayCal.Location = new System.Drawing.Point(419, 42);
            this.lbTodayCal.Name = "lbTodayCal";
            this.lbTodayCal.Size = new System.Drawing.Size(11, 12);
            this.lbTodayCal.TabIndex = 14;
            this.lbTodayCal.Text = "0";
            // 
            // lbSurplusP
            // 
            this.lbSurplusP.AutoSize = true;
            this.lbSurplusP.Location = new System.Drawing.Point(107, 63);
            this.lbSurplusP.Name = "lbSurplusP";
            this.lbSurplusP.Size = new System.Drawing.Size(11, 12);
            this.lbSurplusP.TabIndex = 15;
            this.lbSurplusP.Text = "0";
            // 
            // lbSurplusF
            // 
            this.lbSurplusF.AutoSize = true;
            this.lbSurplusF.Location = new System.Drawing.Point(211, 63);
            this.lbSurplusF.Name = "lbSurplusF";
            this.lbSurplusF.Size = new System.Drawing.Size(11, 12);
            this.lbSurplusF.TabIndex = 16;
            this.lbSurplusF.Text = "0";
            // 
            // lbSurplusC
            // 
            this.lbSurplusC.AutoSize = true;
            this.lbSurplusC.Location = new System.Drawing.Point(315, 63);
            this.lbSurplusC.Name = "lbSurplusC";
            this.lbSurplusC.Size = new System.Drawing.Size(11, 12);
            this.lbSurplusC.TabIndex = 17;
            this.lbSurplusC.Text = "0";
            // 
            // lbSurplusCal
            // 
            this.lbSurplusCal.AutoSize = true;
            this.lbSurplusCal.Location = new System.Drawing.Point(419, 63);
            this.lbSurplusCal.Name = "lbSurplusCal";
            this.lbSurplusCal.Size = new System.Drawing.Size(11, 12);
            this.lbSurplusCal.TabIndex = 18;
            this.lbSurplusCal.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 31);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "項目";
            this.ItemName.Name = "ItemName";
            // 
            // UnitP
            // 
            this.UnitP.HeaderText = "蛋白質";
            this.UnitP.Name = "UnitP";
            this.UnitP.Width = 70;
            // 
            // UnitF
            // 
            this.UnitF.HeaderText = "脂肪";
            this.UnitF.Name = "UnitF";
            this.UnitF.Width = 60;
            // 
            // UnitC
            // 
            this.UnitC.HeaderText = "碳水";
            this.UnitC.Name = "UnitC";
            this.UnitC.Width = 60;
            // 
            // UnitCal
            // 
            this.UnitCal.HeaderText = "熱量";
            this.UnitCal.Name = "UnitCal";
            this.UnitCal.Width = 60;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "單位";
            this.Unit.Name = "Unit";
            this.Unit.Width = 60;
            // 
            // TotalP
            // 
            this.TotalP.HeaderText = "蛋白質";
            this.TotalP.Name = "TotalP";
            this.TotalP.Width = 70;
            // 
            // TotalF
            // 
            this.TotalF.HeaderText = "脂肪";
            this.TotalF.Name = "TotalF";
            this.TotalF.Width = 60;
            // 
            // TotalC
            // 
            this.TotalC.HeaderText = "碳水";
            this.TotalC.Name = "TotalC";
            this.TotalC.Width = 60;
            // 
            // TotalCal
            // 
            this.TotalCal.HeaderText = "熱量";
            this.TotalCal.Name = "TotalCal";
            this.TotalCal.Width = 60;
            // 
            // DailyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DailyRecord";
            this.Text = "DailyRecord";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitF;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTargetP;
        private System.Windows.Forms.Label lbTargetF;
        private System.Windows.Forms.Label lbTargetC;
        private System.Windows.Forms.Label lbTargetCal;
        private System.Windows.Forms.Label lbTodayP;
        private System.Windows.Forms.Label lbTodayF;
        private System.Windows.Forms.Label lbTodayC;
        private System.Windows.Forms.Label lbTodayCal;
        private System.Windows.Forms.Label lbSurplusP;
        private System.Windows.Forms.Label lbSurplusF;
        private System.Windows.Forms.Label lbSurplusC;
        private System.Windows.Forms.Label lbSurplusCal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}