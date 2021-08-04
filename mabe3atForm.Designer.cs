namespace jaimeMarket
{
    partial class mabe3atForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mabe3atForm));
            this.soldView = new System.Windows.Forms.DataGridView();
            this.yearcheakbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthcheckBox = new System.Windows.Forms.CheckBox();
            this.daycheckBox = new System.Windows.Forms.CheckBox();
            this.yearCBox = new System.Windows.Forms.ComboBox();
            this.monthCBox = new System.Windows.Forms.ComboBox();
            this.dayCBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ta3delatView = new System.Windows.Forms.DataGridView();
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateta3del = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeta3del = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMortg3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.soldView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ta3delatView)).BeginInit();
            this.SuspendLayout();
            // 
            // soldView
            // 
            this.soldView.AllowUserToAddRows = false;
            this.soldView.AllowUserToDeleteRows = false;
            this.soldView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellingID,
            this.id,
            this.name,
            this.number,
            this.cash,
            this.isMortg3,
            this.date,
            this.time});
            this.soldView.Location = new System.Drawing.Point(12, 120);
            this.soldView.Name = "soldView";
            this.soldView.ReadOnly = true;
            this.soldView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.soldView.Size = new System.Drawing.Size(908, 531);
            this.soldView.TabIndex = 7;
            this.soldView.Visible = false;
            // 
            // yearcheakbox
            // 
            this.yearcheakbox.AutoSize = true;
            this.yearcheakbox.Checked = true;
            this.yearcheakbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yearcheakbox.Enabled = false;
            this.yearcheakbox.Location = new System.Drawing.Point(89, 19);
            this.yearcheakbox.Name = "yearcheakbox";
            this.yearcheakbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yearcheakbox.Size = new System.Drawing.Size(50, 17);
            this.yearcheakbox.TabIndex = 8;
            this.yearcheakbox.Text = "السنة";
            this.yearcheakbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "عرض الجرد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthcheckBox
            // 
            this.monthcheckBox.AutoSize = true;
            this.monthcheckBox.Location = new System.Drawing.Point(87, 44);
            this.monthcheckBox.Name = "monthcheckBox";
            this.monthcheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthcheckBox.Size = new System.Drawing.Size(52, 17);
            this.monthcheckBox.TabIndex = 11;
            this.monthcheckBox.Text = "الشهر";
            this.monthcheckBox.UseVisualStyleBackColor = true;
            this.monthcheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // daycheckBox
            // 
            this.daycheckBox.AutoSize = true;
            this.daycheckBox.Location = new System.Drawing.Point(92, 71);
            this.daycheckBox.Name = "daycheckBox";
            this.daycheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.daycheckBox.Size = new System.Drawing.Size(47, 17);
            this.daycheckBox.TabIndex = 12;
            this.daycheckBox.Text = "اليوم";
            this.daycheckBox.UseVisualStyleBackColor = true;
            // 
            // yearCBox
            // 
            this.yearCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCBox.FormattingEnabled = true;
            this.yearCBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.yearCBox.Location = new System.Drawing.Point(6, 15);
            this.yearCBox.Name = "yearCBox";
            this.yearCBox.Size = new System.Drawing.Size(77, 21);
            this.yearCBox.TabIndex = 13;
            // 
            // monthCBox
            // 
            this.monthCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCBox.FormattingEnabled = true;
            this.monthCBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthCBox.Location = new System.Drawing.Point(6, 42);
            this.monthCBox.Name = "monthCBox";
            this.monthCBox.Size = new System.Drawing.Size(77, 21);
            this.monthCBox.TabIndex = 14;
            // 
            // dayCBox
            // 
            this.dayCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCBox.FormattingEnabled = true;
            this.dayCBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayCBox.Location = new System.Drawing.Point(6, 69);
            this.dayCBox.Name = "dayCBox";
            this.dayCBox.Size = new System.Drawing.Size(77, 21);
            this.dayCBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yearCBox);
            this.groupBox1.Controls.Add(this.totalTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dayCBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.daycheckBox);
            this.groupBox1.Controls.Add(this.yearcheakbox);
            this.groupBox1.Controls.Add(this.monthCBox);
            this.groupBox1.Controls.Add(this.monthcheckBox);
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(283, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الجارد";
            // 
            // ta3delatView
            // 
            this.ta3delatView.AllowUserToAddRows = false;
            this.ta3delatView.AllowUserToDeleteRows = false;
            this.ta3delatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ta3delatView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dateta3del,
            this.timeta3del});
            this.ta3delatView.Location = new System.Drawing.Point(12, 120);
            this.ta3delatView.Name = "ta3delatView";
            this.ta3delatView.ReadOnly = true;
            this.ta3delatView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ta3delatView.Size = new System.Drawing.Size(908, 531);
            this.ta3delatView.TabIndex = 17;
            this.ta3delatView.Visible = false;
            // 
            // totalTextbox
            // 
            this.totalTextbox.Location = new System.Drawing.Point(145, 69);
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.ReadOnly = true;
            this.totalTextbox.Size = new System.Drawing.Size(75, 20);
            this.totalTextbox.TabIndex = 19;
            this.totalTextbox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = ":المجموع";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(559, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 98);
            this.button2.TabIndex = 20;
            this.button2.Text = "عرض التعديلات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "التعديل";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 570;
            // 
            // dateta3del
            // 
            this.dateta3del.HeaderText = "التاريخ";
            this.dateta3del.Name = "dateta3del";
            this.dateta3del.ReadOnly = true;
            // 
            // timeta3del
            // 
            this.timeta3del.HeaderText = "الوقت";
            this.timeta3del.Name = "timeta3del";
            this.timeta3del.ReadOnly = true;
            // 
            // sellingID
            // 
            this.sellingID.HeaderText = "sellingID";
            this.sellingID.Name = "sellingID";
            this.sellingID.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "الإسم";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 230;
            // 
            // number
            // 
            this.number.HeaderText = "العدد";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // cash
            // 
            this.cash.HeaderText = "المطلوب";
            this.cash.Name = "cash";
            this.cash.ReadOnly = true;
            // 
            // isMortg3
            // 
            this.isMortg3.HeaderText = "مرتجع";
            this.isMortg3.Name = "isMortg3";
            this.isMortg3.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "التاريخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "الوقت";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // mabe3atForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 663);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ta3delatView);
            this.Controls.Add(this.soldView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mabe3atForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات - لمسة فون";
            this.Load += new System.EventHandler(this.mabe3atForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soldView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ta3delatView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView soldView;
        private System.Windows.Forms.CheckBox yearcheakbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox monthcheckBox;
        private System.Windows.Forms.CheckBox daycheckBox;
        private System.Windows.Forms.ComboBox yearCBox;
        private System.Windows.Forms.ComboBox monthCBox;
        private System.Windows.Forms.ComboBox dayCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ta3delatView;
        private System.Windows.Forms.TextBox totalTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn isMortg3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateta3del;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeta3del;
    }
}