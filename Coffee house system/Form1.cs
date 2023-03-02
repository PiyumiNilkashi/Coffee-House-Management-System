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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //login button click
        private void button1_Click(object sender, EventArgs e)
        {

            String phonenumber = phonenumberInput.Text;
            if (phonenumber == "")
            {
                MessageBox.Show("please enter your phone number", "Error");
                return;
            }
            String q = "select * from users where phonenumber = " + phonenumber + " LIMIT 1";
            String q2 = "select * from users where phonenumber = " + phonenumber;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(q2,con);
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >0 ){
                    //user found
                    this.Hide();
                    string usertype = (string)ds.Tables[0].Rows[0]["usertype"];
                    if(usertype == "admin" || usertype == "Admin")
                    {
                        new Form6().Show();
                    }
                    else
                    {
                       new Form9().Show();

                    }
                }
                else{
                    MessageBox.Show("User not found", "Error");
                }

            } catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error");
            } finally{
                con.Close();
            }
        }
        //register button click
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Form2().Show();
        }
        //feedback button click
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void phonenumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().Show();
        }
        //profile update button click
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().Show();
        }
    }
    }

