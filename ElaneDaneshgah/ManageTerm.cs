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
    public partial class ManageTerm : Form
    {
        public ManageTerm()
        {
            InitializeComponent();
        }

        void Data_Load()
        {
            try
            {
                using (var db = new db_elanEntities())
                {



                    dataGridView1.DataSource = (from T in db.tb_term select new { شناسه = T.id,روزهای=T.Day, نام_درس = T.tbl_course.name, نام_استاد = T.tb_teacher.Name, اتاق = T.tb_classroom.name, شروع_کلاس = T.Start_time, پایان_کلاس = T.end_time }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
            catch { }
        }
        private void ManageTerm_Load(object sender, EventArgs e)
        {
            try
            {

                using(var db =new db_elanEntities())
                {
                    var teachers = (from T in db.tb_teacher select new {id=T.id,name=T.Name }).ToList();
                    var classRooms = (from T in db.tb_classroom select new { id = T.id, name = T.name}).ToList();

                    for (int i = 0; i < teachers.Count; i++)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = teachers[i].name;
                        item.Value = teachers[i].id;
                        cmbTeacher.Items.Add(item);
                    
                    }

                    for (int i = 0; i < classRooms.Count; i++)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = classRooms[i].name;
                        item.Value = classRooms[i].id;
                        cmbClassRoom.Items.Add(item);

                    }

                }

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
            catch { }
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
        
 
          try
            {

                using (var db = new db_elanEntities())
                {
                    string teacherID = (cmbTeacher.SelectedItem as ComboboxItem).Value.ToString();

                    var courses = (from T in db.tb_teacher_course.Where(q => q.teacherID == teacherID) select new { id = T.courseID, name = T.tbl_course.name }).ToList();
                    cmbCourses.Items.Clear();

                    for (int i = 0; i < courses.Count; i++)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = courses[i].name;
                        item.Value = courses[i].id;

                        cmbCourses.Items.Add(item);

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



                    dataGridView1.DataSource = (from T in db.tb_term.AsEnumerable().Where(q => q.Day.Contains(txtSearch.Text) || q.tb_teacher.Name.Contains(txtSearch.Text) || q.tbl_course.name.Contains(txtSearch.Text) || q.tb_classroom.name.Contains(txtSearch.Text)) select new { شناسه = T.id, روزهای = T.Day, نام_درس = T.tbl_course.name, نام_استاد = T.tb_teacher.Name, اتاق = T.tb_classroom.name, شروع_کلاس = T.Start_time, پایان_کلاس = T.end_time }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
            catch { }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
         try
            {
                if (cmbDay.SelectedIndex >=0 && cmbTeacher.SelectedIndex >=0 && cmbCourses.SelectedIndex >=0 && cmbClassRoom.SelectedIndex >=0)
             {
                using (var db = new db_elanEntities())
                {



                    tb_term tt = new tb_term();
                    tt.Start_time = dateTimePicker1.Text;
                    tt.end_time = dateTimePicker2.Text;
                    tt.courseID = int.Parse((cmbCourses.SelectedItem as ComboboxItem).Value.ToString());
                    tt.classroomID = int.Parse((cmbClassRoom.SelectedItem as ComboboxItem).Value.ToString());
                    tt.teacherID = (cmbTeacher.SelectedItem as ComboboxItem).Value.ToString();
                    tt.Day = cmbDay.SelectedItem.ToString();
                    db.tb_term.Add(tt);
                    db.SaveChanges();
                       MessageBox.Show("اطلاعات آموزشی اضافه شد");
                       Data_Load();



                }
             }
             else
             {
                 MessageBox.Show("اطلاعات آموزشی را کامل و سپس اقدام کنید");
             }
            }
           catch { }
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
                        var item = db.tb_term.First(q => q.id == id);
                        db.tb_term.Remove(item);
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
                        var teachers = (from T in db.tb_teacher select new { id = T.id, name = T.Name }).ToList();
                        var classRooms = (from T in db.tb_classroom select new { id = T.id, name = T.name }).ToList();
                        cmbEditTeacher.Items.Clear();

                        cmbEditCourses.Items.Clear();
                        cmbEditClassRooms.Items.Clear();
                        for (int i = 0; i < teachers.Count; i++)
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = teachers[i].name;
                            item.Value = teachers[i].id;
                            cmbEditTeacher.Items.Add(item);

                        }

                        for (int i = 0; i < classRooms.Count; i++)
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = classRooms[i].name;
                            item.Value = classRooms[i].id;
                            cmbEditClassRooms.Items.Add(item);

                        }



                        dateTimePicker3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                        dateTimePicker4.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                        string course = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                        for (int i = 0; i < cmbEditClassRooms.Items.Count; i++)
                        {
                            if (course == cmbEditClassRooms.Items[i].ToString())
                            {
                                cmbEditClassRooms.SelectedIndex = i;
                                break;
                            }
                        }
                        string day = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        for (int i = 0; i < cmbEditDay.Items.Count; i++)
                        {
                            if (day == cmbEditDay.Items[i].ToString())
                            {
                                cmbEditDay.SelectedIndex = i;
                                break;
                            }
                        }


                        int id_term = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        txtEditID.Text = id_term.ToString();

                        var teacher_id = (from T in db.tb_term.Where(q=>q.id==id_term) select new { id_techer = T.teacherID}).ToList();

                        for (int i = 0; i < cmbEditTeacher.Items.Count; i++)
                        {
                            string teacher_id_in_list=(cmbEditTeacher.Items[i] as ComboboxItem).Value.ToString();
                             if (teacher_id[0].id_techer == teacher_id_in_list)
                            {
                              cmbEditTeacher.SelectedIndex = i;
                                break;
                            }
                        }



                        var course_id = (from T in db.tb_term.Where(q => q.id == id_term) select new { id_course = T.courseID }).ToList();

                        for (int i = 0; i < cmbEditCourses.Items.Count; i++)
                        {
                            int course_id_in_list = int.Parse((cmbEditCourses.Items[i] as ComboboxItem).Value.ToString());
                            if (course_id[0].id_course == course_id_in_list)
                            {
                                cmbEditCourses.SelectedIndex = i;
                                break;
                            }
                        }





                    }

                    editPanel.Visible = true;
                }
                catch { }
            }
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
                using (var db = new db_elanEntities())
                {
                    int item_id = int.Parse(txtEditID.Text);
                    var item_in_term =  db.tb_term.First(q=>q.id==item_id);
                    item_in_term.Day = cmbEditDay.SelectedItem.ToString();
                    item_in_term.teacherID = (cmbEditTeacher.SelectedItem as ComboboxItem).Value.ToString();
                    item_in_term.courseID = int.Parse((cmbEditCourses.SelectedItem as ComboboxItem).Value.ToString());
                    item_in_term.classroomID = int.Parse((cmbEditClassRooms.SelectedItem as ComboboxItem).Value.ToString());
                    item_in_term.Start_time = dateTimePicker3.Text;
                    item_in_term.end_time = dateTimePicker4.Text;

                    db.SaveChanges();
                   

                    editPanel.Visible = false;
                    PanelMain.Enabled = true;
                    dataGridView1.Enabled = true;
                    Data_Load();

                }

              
            }
            catch { }
        }

        private void cmbEditTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                using (var db = new db_elanEntities())
                {
                    string teacherID = (cmbEditTeacher.SelectedItem as ComboboxItem).Value.ToString();

                    var courses = (from T in db.tb_teacher_course.Where(q => q.teacherID == teacherID) select new { id = T.courseID, name = T.tbl_course.name }).ToList();
                    cmbEditCourses.Items.Clear();

                    for (int i = 0; i < courses.Count; i++)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = courses[i].name;
                        item.Value = courses[i].id;

                        cmbEditCourses.Items.Add(item);

                    }


                }
            }
            catch { }
        }
    }
}
