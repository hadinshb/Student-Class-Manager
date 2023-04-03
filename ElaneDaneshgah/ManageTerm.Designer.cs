namespace ElaneDaneshgah
{
    partial class ManageTerm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.txtEditID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEditClassRooms = new System.Windows.Forms.ComboBox();
            this.cmbEditCourses = new System.Windows.Forms.ComboBox();
            this.cmbEditTeacher = new System.Windows.Forms.ComboBox();
            this.cmbEditDay = new System.Windows.Forms.ComboBox();
            this.btnIqnore = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbClassRoom = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editPanel.SuspendLayout();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 92);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "تایید";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(4, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 21);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "جستجو :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ویرایش :";
            // 
            // editPanel
            // 
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPanel.Controls.Add(this.txtEditID);
            this.editPanel.Controls.Add(this.label10);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.dateTimePicker3);
            this.editPanel.Controls.Add(this.label8);
            this.editPanel.Controls.Add(this.label9);
            this.editPanel.Controls.Add(this.dateTimePicker4);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.label6);
            this.editPanel.Controls.Add(this.cmbEditClassRooms);
            this.editPanel.Controls.Add(this.cmbEditCourses);
            this.editPanel.Controls.Add(this.cmbEditTeacher);
            this.editPanel.Controls.Add(this.cmbEditDay);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.btnIqnore);
            this.editPanel.Controls.Add(this.btnEdit);
            this.editPanel.Location = new System.Drawing.Point(16, 174);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(609, 152);
            this.editPanel.TabIndex = 23;
            this.editPanel.Visible = false;
            // 
            // txtEditID
            // 
            this.txtEditID.AutoSize = true;
            this.txtEditID.Location = new System.Drawing.Point(531, 9);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(13, 13);
            this.txtEditID.TabIndex = 31;
            this.txtEditID.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(573, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "اتاق :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "درس:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(277, 62);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker3.TabIndex = 30;
            this.dateTimePicker3.Value = new System.DateTime(2018, 4, 25, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "استاد:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "روز :";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH:mm";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(102, 62);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker4.TabIndex = 29;
            this.dateTimePicker4.Value = new System.DateTime(2018, 4, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ساعت شروع :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ساعت شروع :";
            // 
            // cmbEditClassRooms
            // 
            this.cmbEditClassRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditClassRooms.FormattingEnabled = true;
            this.cmbEditClassRooms.Location = new System.Drawing.Point(448, 63);
            this.cmbEditClassRooms.Name = "cmbEditClassRooms";
            this.cmbEditClassRooms.Size = new System.Drawing.Size(121, 21);
            this.cmbEditClassRooms.TabIndex = 26;
            // 
            // cmbEditCourses
            // 
            this.cmbEditCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCourses.FormattingEnabled = true;
            this.cmbEditCourses.Location = new System.Drawing.Point(16, 30);
            this.cmbEditCourses.Name = "cmbEditCourses";
            this.cmbEditCourses.Size = new System.Drawing.Size(180, 21);
            this.cmbEditCourses.TabIndex = 25;
            // 
            // cmbEditTeacher
            // 
            this.cmbEditTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditTeacher.FormattingEnabled = true;
            this.cmbEditTeacher.Location = new System.Drawing.Point(246, 30);
            this.cmbEditTeacher.Name = "cmbEditTeacher";
            this.cmbEditTeacher.Size = new System.Drawing.Size(152, 21);
            this.cmbEditTeacher.TabIndex = 24;
            this.cmbEditTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbEditTeacher_SelectedIndexChanged);
            // 
            // cmbEditDay
            // 
            this.cmbEditDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditDay.FormattingEnabled = true;
            this.cmbEditDay.Items.AddRange(new object[] {
            "شنبه",
            "یک شنبه",
            "دو شنبه",
            "سه شنبه",
            "چهار شنبه",
            "پنج شنبه",
            "جمعه"});
            this.cmbEditDay.Location = new System.Drawing.Point(448, 31);
            this.cmbEditDay.Name = "cmbEditDay";
            this.cmbEditDay.Size = new System.Drawing.Size(121, 21);
            this.cmbEditDay.TabIndex = 23;
            // 
            // btnIqnore
            // 
            this.btnIqnore.Location = new System.Drawing.Point(13, 121);
            this.btnIqnore.Name = "btnIqnore";
            this.btnIqnore.Size = new System.Drawing.Size(75, 23);
            this.btnIqnore.TabIndex = 8;
            this.btnIqnore.Text = "انصراف";
            this.btnIqnore.UseVisualStyleBackColor = true;
            this.btnIqnore.Click += new System.EventHandler(this.btnIqnore_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.dateTimePicker1);
            this.PanelMain.Controls.Add(this.dateTimePicker2);
            this.PanelMain.Controls.Add(this.label14);
            this.PanelMain.Controls.Add(this.label13);
            this.PanelMain.Controls.Add(this.label12);
            this.PanelMain.Controls.Add(this.cmbClassRoom);
            this.PanelMain.Controls.Add(this.label11);
            this.PanelMain.Controls.Add(this.cmbCourses);
            this.PanelMain.Controls.Add(this.label4);
            this.PanelMain.Controls.Add(this.cmbTeacher);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Controls.Add(this.cmbDay);
            this.PanelMain.Controls.Add(this.txtSearch);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.btnADD);
            this.PanelMain.Location = new System.Drawing.Point(6, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(630, 151);
            this.PanelMain.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 25, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.Value = new System.DateTime(2018, 4, 25, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(210, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "ساعت شروع :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(382, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "ساعت شروع :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "اتاق :";
            // 
            // cmbClassRoom
            // 
            this.cmbClassRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassRoom.FormattingEnabled = true;
            this.cmbClassRoom.Location = new System.Drawing.Point(467, 40);
            this.cmbClassRoom.Name = "cmbClassRoom";
            this.cmbClassRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbClassRoom.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "درس:";
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(11, 7);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(180, 21);
            this.cmbCourses.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "استاد:";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(251, 7);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(152, 21);
            this.cmbTeacher.TabIndex = 12;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "روز :";
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "شنبه",
            "یک شنبه",
            "دو شنبه",
            "سه شنبه",
            "چهار شنبه",
            "پنج شنبه",
            "جمعه"});
            this.cmbDay.Location = new System.Drawing.Point(467, 8);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 21);
            this.cmbDay.TabIndex = 10;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(25, 37);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(78, 23);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "افزودن";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 159);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(629, 208);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManageTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximizeBox = false;
            this.Name = "ManageTerm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت برنامه هفتگی ترم جاری";
            this.Load += new System.EventHandler(this.ManageTerm_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button btnIqnore;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbClassRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEditClassRooms;
        private System.Windows.Forms.ComboBox cmbEditCourses;
        private System.Windows.Forms.ComboBox cmbEditTeacher;
        private System.Windows.Forms.ComboBox cmbEditDay;
        private System.Windows.Forms.Label txtEditID;
    }
}