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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Coffee_house_system
{
    public partial class Form5 : Form
    {
        bool[] opinion = new bool[3];


        public Form5()
        {
            InitializeComponent();
            opinion[0] = false; //isPoor
            opinion[1] = false; //isNormal
            opinion[2] = false; //isExcellent

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        //exit button click
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
        //submit button click
        private void button1_Click(object sender, EventArgs e)
        {
            string phoennumber = ph.Text;
            string suggestions = SugInput.Text;
            string opinionToDB = "No Opinion";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HP\SOURCE\REPOS\COFFEE HOUSE SYSTEM\COFFEE HOUSE SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30");
            for (int i = 0; i <opinion.Length;i++)
            {
                if (opinion[i])
                {
                    if(i == 0)
                    {
                        opinionToDB = "Poor";

                    }else if (i == 1)
                    {
                        opinionToDB = "Normal";
                    }else if (i == 2)
                    {
                        opinionToDB = "Excellent";
                    }

                    string qry = "INSERT INTO feedback(comment,phoneNumber,opinion) values ('" + suggestions + "', '" + phoennumber + "', '" + opinionToDB + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thank you for sharing your opinion", "Info");
                        this.Hide();
                        new Form1().Show();

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
                    break;
                }

            }


               
            
        }

        private void SugInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void poorRadio_CheckedChanged(object sender, EventArgs e)
        {
           RadioButton radio = (RadioButton)sender;
           if (radio != null)
            {
                opinion[0] = radio.Checked;

            }
        }

        private void normalRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio != null)
            {
                opinion[1] = radio.Checked;
            }
        }

        private void exRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio != null)
            {
                opinion[2] = radio.Checked;
                
            }
        }
    }
    }
