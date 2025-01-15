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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void teacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
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
                String sql = "INSERT INTO student(name,gender,cast,mobile,email,dob,standard,medium,year,address) VALUES('" + textBox1.Text + "','" + gender + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox7.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                String sql1 = "Select max(std_id) from student";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Dear Student, Your Data Inserted Successfully.. ");
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

        