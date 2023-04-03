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
    public partial class ManageException : Form
    {
        public ManageException()
        {
            InitializeComponent();
        }

        void Data_Load()
        {
            try
            {
                using (var db = new db_elanEntities())
                {



                    dataGridView1.DataSource = (from T in db.tb_exception select new { شناسه = T.id,مورخ = T.date, نام_درس = T.tb_term.tbl_course.name, نام_استاد = T.tb_term.tb_teacher.Name, اتاق = T.tb_classroom.name,شروع_کلاس = T.Start_time, پایان_کلاس = T.end_time,توضیحات=T.Description }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
            catch { }
        }


        void getItems_in_Term(string day)
        {
            try
            {
                using (var db = new db_elanEntities())
                {

                    cmbItems_in_term.Items.Clear();
                   
                    if(day=="all")
                    {
                         var items = (from T in db.tb_term select new { ID = T.id,day=T.Day,teacher_name = T.tb_teacher.Name, course_name = T.tbl_course.name, classRoom = T.tb_classroom.name, start_time = T.Start_time, end_Time = T.end_time }).OrderBy(o=>o.day).ToList();
                         for (int i = 0; i < items.Count; i++)
                         {
                             ComboboxItem ci = new ComboboxItem();
                             ci.Text = items[i].day+"-"+items[i].teacher_name + "-" + items[i].course_name + "-" + items[i].classRoom + "     " + items[i].start_time + "-" + items[i].end_Time;
                             ci.Value = items[i].ID;
                             cmbItems_in_term.Items.Add(ci);
                            
                         }
                        
                       
                    }
                    else
                    {
                         var items = (from T in db.tb_term.Where(q=>q.Day==day) select new { ID = T.id, teacher_name = T.tb_teacher.Name, course_name = T.tbl_course.name, classRoom = T.tb_classroom.name, start_time = T.Start_time, end_Time = T.end_time }).OrderBy(o=>o.teacher_name).ToList();
                         for (int i = 0; i < items.Count; i++)
                         {
                             ComboboxItem ci = new ComboboxItem();
                             ci.Text = items[i].teacher_name + "-" + items[i].course_name + "-" + items[i].classRoom + "     " + items[i].start_time + "-" + items[i].end_Time;
                             ci.Value = items[i].ID;
                             cmbItems_in_term.Items.Add(ci);

                         }
                    }
                    

                   





                }
            }
            catch { }
        }
        private void ManageException_Load(object sender, EventArgs e)
        {
            try
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
            using (var db = new db_elanEntities())
            {
                var classRooms = (from T in db.tb_classroom select new { id = T.id, name = T.name }).ToList();
           

               
                cmbClassRoom.Items.Clear();
              
                for (int i = 0; i < classRooms.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = classRooms[i].name;
                    item.Value = classRooms[i].id;
                    cmbClassRoom.Items.Add(item);

                }
            }


            ckbLimit.Text = " کلاس های " + dateTimePickerX1.GetSelectedDateInPersianDateTime().ToStringFormat("dddd");
            if (ckbAll.Checked)
            {
                getItems_in_Term("all");
            }
            else
            {
                getItems_in_Term(dateTimePickerX1.GetSelectedDateInPersianDateTime().ToStringFormat("dddd").ToString());
            }
            }
            catch{}

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
                        var item = db.tb_exception.First(q => q.id == id);
                        db.tb_exception.Remove(item);
                        db.SaveChanges();
                        Data_Load();
                        MessageBox.Show(" با موفقیت حذف شد");
                        txtSearch.Text = "";

                    }
                }
                catch { MessageBox.Show("حذف  انجام نشد،ابتدا برنامه هایی که در  استثناعات برای این گزینه وارد کرده اید را حذف کنید"); }
            }
            else if (e.ColumnIndex == 1)//edit clicked
            {
                try
                {

                    PanelMain.Enabled = false; ;
                    dataGridView1.Enabled = false;
                    using (var db = new db_elanEntities())
                    {

                        int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var item = db.tb_exception.First(q => q.id == id);
                        txtEditID.Text = id.ToString();

                        string[] date = item.date.Split('/');
                        dateTimePickerX2.SetSelectedDate(new BehComponents.PersianDateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])));

                        cmb_edit_room.Items.Clear();
                        var classRooms = (from T in db.tb_classroom select new { id = T.id, name = T.name }).ToList();
                        for (int i = 0; i < classRooms.Count; i++)
                        {
                            ComboboxItem item_r = new ComboboxItem();
                            item_r.Text = classRooms[i].name;
                            item_r.Value = classRooms[i].id;
                            cmb_edit_room.Items.Add(item_r);

                        }


                        for (int i = 0; i < cmb_edit_room.Items.Count; i++)
                        {
                            if (item.tb_classroom.name == cmb_edit_room.Items[i].ToString())
                            {
                                cmb_edit_room.SelectedIndex = i;
                                break;
                            }
                        }

                        edit_starttime.Text = item.Start_time;
                        edit_endtime.Text = item.end_time;
                        edit_description.Text = item.Description;


                    }

                    editPanel.Visible = true;
                }
                catch { }
            }
        }

        private void dateTimePickerX1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerX1_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            ckbLimit.Text = " کلاس های " + dateTimePickerX1.GetSelectedDateInPersianDateTime().ToStringFormat("dddd");
            if(ckbAll.Checked)
            {
                getItems_in_Term("all");
            }
            else
            {
                getItems_in_Term(dateTimePickerX1.GetSelectedDateInPersianDateTime().ToStringFormat("dddd").ToString());
            }
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
           if(ckbAll.Checked)
           {
               ckbLimit.Checked = false;
               getItems_in_Term("all");
           }
           else
           {
               ckbLimit.Checked = true;
               getItems_in_Term( dateTimePickerX1.GetSelectedDateInPersianDateTime().ToStringFormat("dddd").ToString());
           }
            
        }

        private void ckbLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLimit.Checked)
            { 
            ckbAll.Checked = false;

           
            }
            else
            {
                ckbAll.Checked = true;
            }
          
        }

        private void cmbItems_in_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new db_elanEntities())
                {
                    int id_term = int.Parse((cmbItems_in_term.SelectedItem as ComboboxItem).Value.ToString());
                    var item = db.tb_term.First(q => q.id == id_term);
                    dateTimePicker1.Text = item.Start_time.ToString();
                    dateTimePicker2.Text = item.end_time.ToString();
                    for (int i = 0; i < cmbClassRoom.Items.Count; i++)
                    {
                        string temp_classroomid=(cmbClassRoom.Items[i] as ComboboxItem).Value.ToString();
                        if(temp_classroomid==item.classroomID.ToString())
                        {
                            cmbClassRoom.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                using (var db = new db_elanEntities())
                {
                    int id_term = int.Parse((cmbItems_in_term.SelectedItem as ComboboxItem).Value.ToString());
                    tb_exception te = new tb_exception();
                    te.id_term = id_term;
                    te.classroomID = int.Parse((cmbClassRoom.SelectedItem as ComboboxItem).Value.ToString());
                    te.Description = txtDescription.Text + " ";
                    te.Start_time = dateTimePicker1.Text;
                    te.end_time = dateTimePicker2.Text;
                    te.date = dateTimePickerX1.GetSelectedDateInPersianDateTime().ToShortDateString();
                    db.tb_exception.Add(te);
                    db.SaveChanges();
                    Data_Load();
                    MessageBox.Show("با موفقیت افزوده شد");



                }
            }
            catch { MessageBox.Show("اطلاعات را تکمیل و سپس اقدام کنید"); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new db_elanEntities())
                {



                    dataGridView1.DataSource = (from T in db.tb_exception.Where(q => q.date.Contains(txtSearch.Text) || q.tb_term.tb_teacher.Name.Contains(txtSearch.Text) || q.tb_term.tbl_course.name.Contains(txtSearch.Text) || q.tb_term.tb_classroom.name.Contains(txtSearch.Text) || q.Description.Contains(txtSearch.Text)) select new { شناسه = T.id, مورخ = T.date, نام_درس = T.tb_term.tbl_course.name, نام_استاد = T.tb_term.tb_teacher.Name, اتاق = T.tb_classroom.name, شروع_کلاس = T.Start_time, پایان_کلاس = T.end_time, توضیحات = T.Description }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
            catch { }
        }

        private void btnIqnore_Click(object sender, EventArgs e)
        {
            PanelMain.Enabled = true; ;
            dataGridView1.Enabled = true;
            
            editPanel.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                using (var db = new db_elanEntities())
                {
                    int id_exp = int.Parse(txtEditID.Text);
                    var item_in_exp = db.tb_exception.First(q => q.id == id_exp);

                    item_in_exp.classroomID = int.Parse((cmb_edit_room.SelectedItem as ComboboxItem).Value.ToString());
                    item_in_exp.Description = edit_description.Text + " ";
                    item_in_exp.Start_time = edit_starttime.Text;
                    item_in_exp.end_time = edit_endtime.Text;
                    item_in_exp.date = dateTimePickerX2.GetSelectedDateInPersianDateTime().ToShortDateString();

                    db.SaveChanges();


                    PanelMain.Enabled = true; ;
                    dataGridView1.Enabled = true;

                    editPanel.Visible = false;

                    Data_Load();

                }
            }
            catch {  }
           
        }
    }
}
