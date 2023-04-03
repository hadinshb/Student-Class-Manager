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
    public partial class ManageTeachers : Form
    {
        public ManageTeachers()
        {
            InitializeComponent();
        }

        string GetCourses(string ID)
        {
            
                using (var db = new db_elanEntities())
                {
                    string courses = "";
                    var courses_list = (from T in db.tb_teacher_course.Where(q => q.teacherID == ID) select new { courses = T.tbl_course.name }).ToList();
                    if (courses_list.Count == 1)
                    {
                        courses = courses_list[0].courses;
                    }
                    else

                        for (int i = 0; i < courses_list.Count; i++)
                        {
                            courses = courses_list[i].courses+"|"+courses;
                        }
                    return courses;
                    
                }
    
        }
    
        void Data_Load()
        {
             try
            {
                using (var db = new db_elanEntities())
                {
                    lstCourses.Items.Clear();

                    for (int i = 0; i < db.tbl_course.ToList().Count; i++)
                    {
                        lstCourses.Items.Add(db.tbl_course.ToList()[i].id+"|"+ db.tbl_course.ToList()[i].name);
                    }




                    dataGridView1.DataSource = (from T in db.tb_teacher.AsEnumerable() select new { کدملی = T.id, استاد = T.Name, دروس_ارائه_شده = this.GetCourses(T.id) }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





                }
            }
           catch { }
        }
        private void ManageTeachers_Load(object sender, EventArgs e)
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

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCodeMeli.Text != ""&&txtName.Text!=""&&lstCourses.SelectedItems.Count!=0)
                {
                    using (var db = new db_elanEntities())
                    {
                        tb_teacher tt = new tb_teacher();
                        tt.id = txtCodeMeli.Text;
                        tt.Name = txtName.Text;

                        db.tb_teacher.Add(tt);


                        for (int i = 0; i < lstCourses.SelectedItems.Count; i++)
                        {
                            int id_course = Int32.Parse(lstCourses.SelectedItems[i].ToString().Split('|')[0].Trim());
                            tb_teacher_course tc = new tb_teacher_course();
                            tc.teacherID = txtCodeMeli.Text;
                            tc.courseID = id_course;
                            db.tb_teacher_course.Add(tc);
                        }


                        db.SaveChanges();
                        Data_Load();
                       MessageBox.Show("اطلاعات استاد با موفقیت ذخیره شد");
                       txtCodeMeli.Text = "";
                       txtSearch.Text = "";
                       txtName.Text = "";
                       lstCourses.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("اطلاعات اولیه و دروس ارائه شده را تکمیل کنید");
                }

            }


           catch { MessageBox.Show("اطلاعات وارد شده معتبر نبوده یا فردی با این کد ملی قبلا در سیستم ثبت شده است"); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new db_elanEntities())
                {
                   


                    dataGridView1.DataSource = (from T in db.tb_teacher.AsEnumerable().Where(q=>q.Name.Contains(txtSearch.Text)||q.id.Contains(txtSearch.Text)) select new { کدملی = T.id, استاد = T.Name, دروس_ارائه_شده = this.GetCourses(T.id) }).ToList();
                    dataGridView1.Columns[2].ReadOnly = true; //make the id column read only





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
                        string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        var itemAll = db.tb_teacher_course.Where(q => q.teacherID == id).ToList();
                        for (int i = 0; i < itemAll.Count; i++)
                        {
                            db.tb_teacher_course.Remove(itemAll[i]);
                        }
                      
                        var item = db.tb_teacher.First(q => q.id == id);
                        db.tb_teacher.Remove(item);
                      
                     
                        db.SaveChanges();
                        Data_Load();
                        MessageBox.Show("استاد مربوطه با موفقیت حذف شد");
                        txtSearch.Text = "";

                    }
                }
                 catch { MessageBox.Show("امکان حذف استاد وجود ندارد،ابتدا برنامه هایی که این استاد در ترم جاری دارند را حذف بکنید"); }
            }
            else if (e.ColumnIndex == 1)//edit clicked
            {
                try
                {

                    PanelMain.Enabled = false; ;
                    dataGridView1.Enabled = false;
                  
                   txtEditCodemeli.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                   txtEditName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                   lstEditCourse.Items.Clear();
                   using (var db = new db_elanEntities())
                   {
                       for (int i = 0; i < db.tbl_course.ToList().Count; i++)
                       {
                           lstEditCourse.Items.Add(db.tbl_course.ToList()[i].id + "|" + db.tbl_course.ToList()[i].name);
                       }
                   }
                   string[] courses = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Split('|') ;
                   for (int i = 0; i < courses.Count(); i++)
                   {
                       if(courses[i].Trim()!="")
                       { 
                       for (int j = 0; j < lstEditCourse.Items.Count; j++)
                       {
                           if(lstEditCourse.Items[j].ToString().Contains(courses[i]))
                           {
                               lstEditCourse.SelectedIndex = j;
                           }
                       }
                       }
                   }
                    editPanel.Visible = true;
                }
                catch { }
            }
        }

       

        private void btnIqnore_Click_2(object sender, EventArgs e)
        {
            PanelMain.Enabled = true; ;
            dataGridView1.Enabled = true;


            editPanel.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtEditName.Text != "" && lstEditCourse.SelectedItems.Count != 0)
                {
                    using (var db = new db_elanEntities())
                    {
                        string id = txtEditCodemeli.Text;
                        var item = db.tb_teacher.First(q => q.id == id);
                        item.Name = txtEditName.Text;
                        
                        db.SaveChanges();


                        var courses_in_db = (from T in db.tb_teacher_course.Where(q => q.teacherID == id) select T).ToList();
                        int[] courses_in_EditList = new int[lstEditCourse.SelectedItems.Count];

                        for (int i = 0; i < lstEditCourse.SelectedItems.Count; i++)
                        {
                           courses_in_EditList[i]=  Int32.Parse(lstEditCourse.SelectedItems[i].ToString().Split('|')[0].Trim());
                           
                        }

                        for (int i = 0; i < courses_in_db.Count(); i++)
                        {
                            int count = 0;
                            for (int j = 0; j < courses_in_EditList.Length; j++)
                            {
                                if(courses_in_db[i].courseID==courses_in_EditList[j])
                                { count++; }
                                
                            }
                            if (count == 0) { db.tb_teacher_course.Remove(courses_in_db[i]);  }
                           
                        }
                       

                        for (int i = 0; i < courses_in_EditList.Length; i++)
                        {
                            int count = 0;
                            for (int J = 0; J <  courses_in_db.Count(); J++)
                            {
                                if(courses_in_EditList[i]==courses_in_db[J].courseID)
                                { count++; }
                            }
                            if(count==0)
                            {
                                tb_teacher_course tc = new tb_teacher_course();
                                tc.courseID = courses_in_EditList[i];
                                tc.teacherID = id;
                                db.tb_teacher_course.Add(tc); 
                            }
                           
                        }


                        db.SaveChanges();



                        db.SaveChanges();
                        Data_Load();
                        MessageBox.Show("اطلاعات استاد با موفقیت ذخیره شد");
                        PanelMain.Enabled = true; ;
                        dataGridView1.Enabled = true;


                        editPanel.Visible = false;
                    
                    }
                }
                else
                {
                    MessageBox.Show("اطلاعات اولیه و دروس ارائه شده را تکمیل کنید");
                }

            }


            catch { MessageBox.Show("خطایی رخ داده است.احتمالا برای درس ارایه شده توسط این استاد برنامه هفتگی ایجاد کرده اید"); }
        }
    }
}
