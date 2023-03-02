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
    public partial class Form9 : Form
    {
/*
        string[] orderItems = new string[6];
        int[] orderQty = new int[6];
        int[] Prices = new int[6];
        int[] Total = new int[6];
        String phonenumber;*/

        public Form9()
        {
            InitializeComponent();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        string orderItems;
        int orderQty;
        int Price;
        int Total;
        String phonenumber;

  

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (ChkBox1.Checked)
            {
                orderItems = "Espresso";
                int orderQty = int.Parse(EspressoQuantity.Value.ToString());
                Price = 250;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);
            }
            if (ChkBox2.Checked)
            {
                orderItems = "Americano Reg";
                int orderQty = int.Parse(numericUpDown2.Value.ToString());
                Price = 400;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);
            }
            if (ChkBox3.Checked)
            {
                orderItems = "Cappuccino Reg";
                int orderQty = int.Parse(numericUpDown3.Value.ToString());
                Price = 500;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);
            }
            if (ChkBox4.Checked)
            {
                orderItems = "Cafe Latte";
                int orderQty = int.Parse(numericUpDown4.Value.ToString());
                Price = 500;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);
            }
            if (ChkBox5.Checked)
            {
                orderItems = "Flate White";
                int orderQty = int.Parse(numericUpDown5.Value.ToString());
                Price = 450;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);
            }
            if (ChkBox6.Checked)
            {
                orderItems = "Hot Chocolate";
                int orderQty = int.Parse(numericUpDown6.Value.ToString());
                Price = 250;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);
            }

            int sum = 0;

            for (int row = 0; row <  dataGridView1.Rows.Count; row++)
                {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            txtSum.Text = sum.ToString();





            int grandTotalPrice = 0;
            for (int i = 0; i < orderItems.Length; i++)
            {
                String orderItemName = orderItems;
                int orderQuatityPerItem = orderQty;
                int totalPrice = Price * orderQuatityPerItem;
                grandTotalPrice += totalPrice;

                if (orderQuatityPerItem > 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");
                    string qry = "INSERT INTO UserOrders (phoneNumber,itemName,itemQuantity,totalPrice) values ('" + phonenumber + "', '" + orderItemName + "', '" + orderQuatityPerItem.ToString() + "', '" + totalPrice.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
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
            
        } 
        } 

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void ChkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ChkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            new Form7().Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //if (ChkBox1.Checked)
            {
              /*  orderItems = "Espresso";
                int orderQty = int.Parse(EspressoQuantity.Value.ToString());
                Price = 250;
                Total = Price * orderQty;
                this.dataGridView1.Rows.Add(orderItems, Price, orderQty, Total);*/
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CnclBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PrivBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();

        }
    }
}
