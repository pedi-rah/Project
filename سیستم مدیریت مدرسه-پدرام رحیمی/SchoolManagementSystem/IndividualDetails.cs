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
    public partial class IndividualDetails : Form
    {
        public IndividualDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,mother,gender,cast,mobile,email,dob,standard,medium,privious_school,year,address from student where std_id=" + Convert.ToInt32(textBox1.Text) + " ;";      // saving new custmer info

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label15.Text = dr.GetValue(0).ToString();
                        label16.Text = dr.GetValue(1).ToString();
                        label17.Text = dr.GetValue(2).ToString();
                        label18.Text = dr.GetValue(3).ToString();
                        label19.Text = dr.GetValue(4).ToString();
                        label20.Text = dr.GetValue(5).ToString();
                        label21.Text = dr.GetValue(6).ToString();
                        label22.Text = dr.GetValue(7).ToString();
                        label23.Text = dr.GetValue(8).ToString();
                        label24.Text = dr.GetValue(9).ToString();
                        label25.Text = dr.GetValue(10).ToString();
                        label26.Text = dr.GetValue(11).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This Registration Id is Invalide, Please Insert Correct Id");
                        textBox1.Text = "";

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IndividualDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
