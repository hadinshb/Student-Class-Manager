using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElaneDaneshgah
{
    public partial class ManageCourses : Form
    {
        public ManageCourses()
        {
            InitializeComponent();
        }


        void Data_Load()
        {
            try
            {
                using (var db = new db_elanEntities())
                {



                    dataGridView1.DataSource = (from T in db.tbl_course select new { شناسه = T.id, نام_درس = T.name }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
            catch { }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void editPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageCourses_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            DataGridViewImageColumn Editbut = new DataGridViewImageColumn();
            delbut.Image = Properties.Resources.mActionDeleteSelected;

            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(delbut);
            Editbut.Image = Properties.Resources.yellow_edit_512;
            Editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(Editbut);
            Data_Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//delete clicked
            {
                try
                {
                    using (var db = new db_elanEntities())
                    {
                        int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var item = db.tbl_course.First(q => q.id == id);
                        db.tbl_course.Remove(item);
                        db.SaveChanges();
                        Data_Load();
                        MessageBox.Show("درس با موفقیت حذف شد");
                        txtSearch.Text = "";

                    }
                }
                catch { MessageBox.Show("حذف درس انجام نشد،ابتدا برنامه هایی که در ترم جاری برای این درس وارد کرده اید را حذف کنید"); }
            }
            else if (e.ColumnIndex == 1)//edit clicked
            {
                try
                {

                    PanelMain.Enabled = false; ;
                    dataGridView1.Enabled = false;
                    txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtEditCourseName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    editPanel.Visible = true;
                }
                catch { }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCourseName.Text != "")
                {
                    using (var db = new db_elanEntities())
                    {
                       tbl_course tc = new tbl_course();
                        tc.name = txtCourseName.Text;
                        db.tbl_course.Add(tc);
                        db.SaveChanges();
                        Data_Load();
                        MessageBox.Show("درس با موفقیت اضافه شد");
                        txtCourseName.Text = "";
                    }
                }

            }


            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new db_elanEntities())
                {



                    dataGridView1.DataSource = (from T in db.tbl_course.Where(q => q.name.Contains(txtSearch.Text)) select new { شناسه = T.id, نام_درس = T.name }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
            catch { }
        }

        private void btnIqnore_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;
            PanelMain.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEditCourseName != null)
                {
                    using (var db = new db_elanEntities())
                    {
                        int id = int.Parse(txtID.Text);
                        var item = db.tbl_course.First(q => q.id == id);
                        item.name = txtEditCourseName.Text;
                        db.SaveChanges();
                        Data_Load();
                        editPanel.Visible = false;
                        PanelMain.Enabled = true;
                        dataGridView1.Enabled = true;


                    }
                }
            }
            catch { }
        }
    }
}
