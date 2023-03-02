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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            String name = nameInput.Text;
            String email = emailInput.Text;
            String phoneNumber = pnInput.Text;
            String type = typeInput.Text;

            if (name == "")
            {
                MessageBox.Show("please enter your name", "Error");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("please enter your email", "Error");
                return;
            }

            if (phoneNumber == "")
            {
                MessageBox.Show("please enter your phone Number", "Error");
                return;
            }

            if (type == "")
            {
                MessageBox.Show("please enter your type", "Error");
                return;
            }

            String q2 = "select * from users where phonenumber = " + phoneNumber;
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd1 = new SqlCommand(q2, con1);
            try
            {
                con1.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("phone number already exists", "INFO");
                    return;
                }
             

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error");
            }
            finally
            {
                con1.Close();
            }


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO Users(name,email,usertype,phonenumber) values ('" + name + "', '" + email + "', '" + type + "', '" + phoneNumber + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("User registration successfull");
                MessageBox.Show("User registration successfull", "Info");
                this.Hide();
                new Form9().Show();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                MessageBox.Show(error.ToString(), "error");
            }
            finally
            {
                con.Close();
            }

        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
