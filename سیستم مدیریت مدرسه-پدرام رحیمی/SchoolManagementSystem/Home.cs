using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void oldAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees obj2 = new Fees();
            obj2.ShowDialog();
        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAdmission obj1 = new NewAdmission();
            obj1.ShowDialog();
        }

        private void searchStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchStudent obj3 = new SearchStudent();
            obj3.ShowDialog();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails obj4 = new IndividualDetails();
            obj4.ShowDialog();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent obj5 = new DeleteStudent();
            obj5.ShowDialog();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCollege obj6 = new AboutCollege();
            obj6.ShowDialog();
        }

        private void aboutSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oldAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OldAdmission obj7 = new OldAdmission();
            obj7.ShowDialog();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tEACHERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aDDINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher obj1 = new teacher();
            obj1.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchTeacher obj2 = new searchTeacher();
            obj2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
