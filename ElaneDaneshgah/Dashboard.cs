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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            ScreenPanel sr = new ScreenPanel();
            sr.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            ManageClassRooms mc = new ManageClassRooms();
            mc.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ManageCourses mc = new ManageCourses();
            mc.ShowDialog();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ManageTeachers mc = new ManageTeachers();
            mc.ShowDialog();
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            ManageTerm mc = new ManageTerm();
            mc.ShowDialog();
        }

        private void btnExceptions_Click(object sender, EventArgs e)
        {
            ManageException mc = new ManageException();
            mc.ShowDialog();
        }
    }
}
