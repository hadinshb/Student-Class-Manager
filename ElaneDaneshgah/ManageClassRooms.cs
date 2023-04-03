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
    public partial class ManageClassRooms : Form
    {
        public ManageClassRooms()
        {
            InitializeComponent();
        }

        void Data_Load()
        {
            try
            {
                using (var db = new db_elanEntities())
                {



                    dataGridView1.DataSource = (from T in db.tb_classroom select new { شناسه = T.id, نام_کلاس = T.name }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only
               




                }
            }
            catch { }
        }
        private void ManageClassRooms_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //delbut.Image = Properties.Resources.mActionDeleteSelected;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if(e.ColumnIndex==0)//delete clicked
            {
               try
                {
                    using (var db = new db_elanEntities())
                    {
                        int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var item = db.tb_classroom.First(q => q.id == id);  
                        db.tb_classroom.Remove(item);
                        db.SaveChanges();
                        Data_Load();
                        MessageBox.Show("کلاس با موفقیت حذف شد");
                        txtSearch.Text = "";
                        
                    }
                }
               catch { MessageBox.Show("امکان حذف کلاس وجود ندارد،ابتدا برنامه هایی که در ترم جاری برای این کلاس وارد کرده اید را حذف بکنید"); }

            }
            else if (e.ColumnIndex == 1)//edit clicked
            {
                try
                {

                    PanelMain.Enabled = false;;
                    dataGridView1.Enabled = false;
                    txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtEditClassRoomName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    editPanel.Visible = true;
                }
                catch { }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtClassRoomName.Text!="")
                {
                using (var db = new db_elanEntities())
                {
                    tb_classroom cr= new tb_classroom();
                    cr.name=txtClassRoomName.Text;
                    db.tb_classroom.Add(cr);
                    db.SaveChanges();
                   Data_Load();
                    MessageBox.Show("کلاس با موفقیت اضافه شد");
                    txtClassRoomName.Text = "";
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



                    dataGridView1.DataSource = (from T in db.tb_classroom.Where(q =>q.name.Contains(txtSearch.Text)  ) select new { شناسه = T.id, نام_کلاس = T.name }).ToList();
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
                if (txtEditClassRoomName != null)
                {
                    using (var db = new db_elanEntities())
                    {
                        int id = int.Parse(txtID.Text);
                        var item = db.tb_classroom.First(q => q.id == id);
                        item.name = txtEditClassRoomName.Text;
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
