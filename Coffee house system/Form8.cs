using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_house_system
{
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HP\\source\\repos\\Coffee house system\\Coffee house system\\Database1.mdf\";Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }
        //go to Form3
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 newform = new Form9();
            newform.ShowDialog();
            this.Show();
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Form1().Show();

        }

        private void button1_Click(object sender, EventArgs e)

        {

          /*  for (int item = 0; item <= dataGridView1.Rows.Count - 1; item++)
            {
                SqlCommand cmd2 = new SqlCommand("Update Users set name=@Name , email=@Email , usertype=@UserType , phonenumber=@phoneNumber ", con);
                cmd2.Parameters.AddWithValue("@Name", dataGridView1.Rows[item].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@Email", dataGridView1.Rows[item].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@UserType", dataGridView1.Rows[item].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@phoneNumber", dataGridView1.Rows[item].Cells[3].Value);

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Updated Successfully");*/








            }
            private void Form8_Load(object sender, EventArgs e)
            {

            }

            private void DisplyBtn_Click(object sender, EventArgs e)
            {
               /* SqlCommand cmd = new SqlCommand("select name , email , usertype , phonenumber from Users where phonenumber =@parm1", con);
                cmd.Parameters.AddWithValue("@parm1", txtPhone.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;*/




            }
        }
    }
