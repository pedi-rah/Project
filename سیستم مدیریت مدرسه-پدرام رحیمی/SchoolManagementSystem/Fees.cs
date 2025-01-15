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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            try
            {
                string str = " INSERT INTO fees VALUES('"+textBox1.Text+"','"+textBox2.Text+"')";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Your Fees Submitted..");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\school.mdf;Integrated Security=True;User Instance=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,standard,medium from student where std_id=" + Convert.ToInt32(textBox1.Text) + " ;";      // saving new custmer info

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label9.Text = dr.GetValue(0).ToString();
                        label6.Text = dr.GetValue(1).ToString();
                        label7.Text = dr.GetValue(2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This Registration Id is Invalid, Please Insert Correct Id");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }
    }
}
