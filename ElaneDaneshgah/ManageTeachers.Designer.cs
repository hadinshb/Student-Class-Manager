namespace ElaneDaneshgah
{
    partial class ManageTeachers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodeMeli = new System.Windows.Forms.TextBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lstEditCourse = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditCodemeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIqnore = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 230);
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
            this.dataGridView1.Size = new System.Drawing.Size(658, 162);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "جستجو :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 201);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 21);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(390, 189);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(157, 23);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "افزودن";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد ملی :";
            // 
            // txtCodeMeli
            // 
            this.txtCodeMeli.Location = new System.Drawing.Point(390, 17);
            this.txtCodeMeli.Name = "txtCodeMeli";
            this.txtCodeMeli.Size = new System.Drawing.Size(157, 21);
            this.txtCodeMeli.TabIndex = 1;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.label7);
            this.PanelMain.Controls.Add(this.txtSearch);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.lstCourses);
            this.PanelMain.Controls.Add(this.label6);
            this.PanelMain.Controls.Add(this.txtName);
            this.PanelMain.Controls.Add(this.btnADD);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.txtCodeMeli);
            this.PanelMain.Location = new System.Drawing.Point(3, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(658, 227);
            this.PanelMain.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "دروس ارائه شده :";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(390, 75);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCourses.Size = new System.Drawing.Size(157, 108);
            this.lstCourses.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "نام و نام خانوادگی :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(390, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 21);
            this.txtName.TabIndex = 6;
            // 
            // editPanel
            // 
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPanel.Controls.Add(this.label8);
            this.editPanel.Controls.Add(this.lstEditCourse);
            this.editPanel.Controls.Add(this.label9);
            this.editPanel.Controls.Add(this.txtEditName);
            this.editPanel.Controls.Add(this.label10);
            this.editPanel.Controls.Add(this.txtEditCodemeli);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.btnIqnore);
            this.editPanel.Controls.Add(this.btnEdit);
            this.editPanel.Location = new System.Drawing.Point(97, 235);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(475, 152);
            this.editPanel.TabIndex = 20;
            this.editPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "دروس ارائه شده :";
            // 
            // lstEditCourse
            // 
            this.lstEditCourse.FormattingEnabled = true;
            this.lstEditCourse.Location = new System.Drawing.Point(129, 63);
            this.lstEditCourse.Name = "lstEditCourse";
            this.lstEditCourse.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstEditCourse.Size = new System.Drawing.Size(157, 82);
            this.lstEditCourse.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "نام و نام خانوادگی :";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(129, 34);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(157, 21);
            this.txtEditName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "کد ملی :";
            // 
            // txtEditCodemeli
            // 
            this.txtEditCodemeli.Enabled = false;
            this.txtEditCodemeli.Location = new System.Drawing.Point(129, 5);
            this.txtEditCodemeli.Name = "txtEditCodemeli";
            this.txtEditCodemeli.Size = new System.Drawing.Size(157, 21);
            this.txtEditCodemeli.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ویرایش";
            // 
            // btnIqnore
            // 
            this.btnIqnore.Location = new System.Drawing.Point(7, 77);
            this.btnIqnore.Name = "btnIqnore";
            this.btnIqnore.Size = new System.Drawing.Size(75, 23);
            this.btnIqnore.TabIndex = 8;
            this.btnIqnore.Text = "انصراف";
            this.btnIqnore.UseVisualStyleBackColor = true;
            this.btnIqnore.Click += new System.EventHandler(this.btnIqnore_Click_2);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "تایید";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ManageTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximizeBox = false;
            this.Name = "ManageTeachers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اساتید";
            this.Load += new System.EventHandler(this.ManageTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeMeli;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstEditCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditCodemeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIqnore;
        private System.Windows.Forms.Button btnEdit;
    }
}