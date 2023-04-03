using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ElaneDaneshgah
{
    public partial class ScreenPanel : Form
    {
        public ScreenPanel()
        {
            InitializeComponent();
        }

        string PersianDate(DateTime DateTime1)
        {
            PersianCalendar PersianCalendar1 = new PersianCalendar();
                        return string.Format(@"{0}/{1}/{2}",
                         PersianCalendar1.GetYear(DateTime1),
                         PersianCalendar1.GetMonth(DateTime1),
                         PersianCalendar1.GetDayOfMonth(DateTime1));
        }
        private int xpos = 0, ypos = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime t_date = DateTime.Now;
            String Today_en = t_date.ToString("dddd").ToLower().Trim();
            String Today_fa = "";
            switch (Today_en)
            {
                case "saturday": Today_fa = "شنبه"; break;
                case "sunday": Today_fa = "یک شنبه"; break;
                case "monday": Today_fa = "دو شنبه"; break;
                case "tuesday": Today_fa = "سه شنبه"; break;
                case "wednesday": Today_fa = "چهار شنبه"; break;
                case "thursday": Today_fa = "پنج شنبه"; break;
                case "friday": Today_fa = "جمعه"; break;

            
                         
           }

            String date_fa = PersianDate(DateTime.Now).ToString();
          
            MainGrid.ColumnHeadersDefaultCellStyle.Font = new Font("B Mitra", 18F, FontStyle.Bold);
        
            clock.Start();
            xpos = this.lblGesarText.Location.X;
       

            ypos = this.lblGesarText.Location.Y;
            JomalatGesar.Start();
            this.FormBorderStyle = FormBorderStyle.None;

            // hide max,min and close button at top right of Window
            this.FormBorderStyle = FormBorderStyle.None;
            // fill the screen
            this.Bounds = Screen.PrimaryScreen.Bounds;

            using (var db = new db_elanEntities()) // object of Database ( context class )  
            {

                 var queryTerm = (from T in db.tb_term.Where(T => T.Day == Today_fa)
                                 join E in db.tb_exception.Where(E => E.date.ToString().Contains(date_fa))
                  on T.id equals E.id_term into TE

      

                                 from EXP in TE.DefaultIfEmpty()//for outer join 

                                 
                                 select new
                                    {
                                        درس = T.tbl_course.name,
                                        استاد = T.tb_teacher.Name,

                                        کلاس = EXP.classroomID == null ? T.tb_classroom.name : EXP.tb_classroom.name,

                                        شروع = EXP.Start_time == null ? T.Start_time : EXP.Start_time,
                                        پایان = EXP.end_time == null ? T.end_time : EXP.end_time,
                                        توضیحات = EXP.Description == null ? T.Description : EXP.Description

                                    }
                                   ).OrderBy(i => i.شروع).ToList();







                 MainGrid.DataSource = queryTerm;
                MainGrid.Columns["درس"].Width = 300;
                MainGrid.Columns["استاد"].Width = 200;
                MainGrid.Columns["کلاس"].Width = 100;
                MainGrid.Columns["شروع"].Width = 100;
                MainGrid.Columns["پایان"].Width = 100;
                MainGrid.Columns["توضیحات"].Width = 600; 
 
            }  
 
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            txtClock.Text = DateTime.Now.ToString("H:mm:ss");
            lblTodayDay.Text = PersianDate(DateTime.Now).ToString() ;
            
        }

        private void txtClock_Click(object sender, EventArgs e)
        {

        }

        private void JomalatGesar_Tick(object sender, EventArgs e)
        {
            if (this.Width <= xpos)
            {

                this.lblGesarText.Location = new System.Drawing.Point(-618, ypos);

                xpos = -618;
                
            }

            else
            {
                
                this.lblGesarText.Location = new System.Drawing.Point(xpos, ypos);

                xpos += 5;

            }
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       


    }
}
