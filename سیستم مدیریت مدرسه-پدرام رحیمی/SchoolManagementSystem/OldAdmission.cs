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
    public partial class OldAdmission : Form
    {
        public OldAdmission()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                string str = " Update student set standard ='" + comboBox2.Text + "' where standard='" + comboBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(std_id) from student ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("All Student Which are in '"+comboBox1.Text+"' are Enter into class '"+comboBox2.Text+"' Successfully..");
                    this.Hide();

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
