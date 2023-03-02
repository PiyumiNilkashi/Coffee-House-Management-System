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
    public partial class Form6 : Form

    {

        public Form6()
        {
            InitializeComponent();
            loadData2();
            loadData();

            /*InitializeComponent();
            loadData();
            loadData2();

            userfeedback.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            userfeedback.Columns.Insert(3, buttoncolumn);
            buttoncolumn.HeaderText = "Delete Row";
            buttoncolumn.Width = 100;
            buttoncolumn.Text = "Delete";
            buttoncolumn.UseColumnTextForButtonValue = true;*/
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
            //userorders
            //users
        }

        private void loadData2()
        {

            string sql = "SELECT * FROM feedback";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");

            //dataGridView1
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                userfeedback.DataSource = dt;
                //  DataGridViewRow dr = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                // dr.Cells[0].Value = grandTotal.ToString();
                //dataGridView2.Rows.Add(dr); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
            finally
            {
                con.Close();

            }

        }

        private void loadData()
        {

            string sql = "SELECT * FROM UserOrders";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");

            //dataGridView1
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                userorders.DataSource = dt;
                //  DataGridViewRow dr = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                // dr.Cells[0].Value = grandTotal.ToString();
                //dataGridView2.Rows.Add(dr); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERror");
            }
            finally
            {
                con.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userfeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = userfeedback.Rows[e.RowIndex];
                if (MessageBox.Show(String.Format("Do you want Delete this Feedback?", row.Cells["phoneNumber"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {

                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30")) 
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from feedback where phoneNumber-@phoneNumber", con)) 
                        {
                            cmd.Parameters.AddWithValue("phoneNumber", row.Cells["phoneNumber"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        
    
                    }

                }
            }*/
        }

        private void btnFeedack_Click(object sender, EventArgs e)
        {
           

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void userorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

           

        
        
    
    



