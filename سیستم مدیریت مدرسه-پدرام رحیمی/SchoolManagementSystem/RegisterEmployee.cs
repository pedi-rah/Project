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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string gender = string.Empty;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";
                }
                try
                {
                    string str = " INSERT INTO employee(username,full_name,password,gender,email,mobile,address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();



                    string str1 = "select max(emp_id) from employee ;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Dear Employee, Your Id is '" + dr.GetInt32(0) + "'. Your are Registered Successfully .. ");
                        this.Hide();
                        Home obj2 = new Home();
                        obj2.ShowDialog();
                    }
                    this.Close();
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            
        }
    }
}
