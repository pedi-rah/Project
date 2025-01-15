using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Registration number");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True"))
                {

                    string str = "SELECT * FROM student WHERE std_id = '" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.schoolDataSet.student);
             using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True"))
            {

                string str = "SELECT * FROM student";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
            
        
        }
    }
}
