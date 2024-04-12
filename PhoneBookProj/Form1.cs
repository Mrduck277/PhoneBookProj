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

namespace PhoneBookProj
{
    public partial class Form1 : Form
    {
        private static bool CheckingHowMany(string thingToCheck, string RowNeeded)
        {
            bool Exist;
            var con = new SqlConnection("data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=PhoneBookData;integrated security=True;Encrypt=False");
            con.Open();
            string insertString = $"select count(*) from PhoneBook where ([{RowNeeded}] = '{thingToCheck}');";

            SqlCommand CheckNumber = new SqlCommand(insertString, con);
            CheckNumber.Parameters.AddWithValue(RowNeeded, thingToCheck);
            int NumberExist = (int)CheckNumber.ExecuteScalar();

            if (NumberExist > 0)
            {
                Exist = true;
            }
            else
            {
                Exist = false;
            }
            con.Close(); 

            return Exist;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection("data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=PhoneBookData;integrated security=True;Encrypt=False");
            
            var builder = new StringBuilder();
            int count = 0;


            
            if (FirstNamein.Text == " " || LastNameIn.Text == " " || FirstNamein.Text == "" || LastNameIn.Text == "")
            {
                label5.Visible = true;
            }
            else if (PhoneNumIn.Text.Length == 9)
            {
                ToLongError.Visible = true;
            }
            else
            {
                foreach (var c in PhoneNumIn.Text)
                {
                    if (count == 0)
                    {
                        builder.Append("(");
                    }
                    else if (count == 3)
                    {
                        builder.Append(")");
                    }
                    else if (count == 6)
                    {
                        builder.Append("-");
                    }
                    else if (PhoneNumIn.Text == " ")
                    {
                        continue;
                    }
                    builder.Append(c); count++;
                }

                string insertString = $"insert into PhoneBook (Firstname, LastName, PhoneNumber) values ('{FirstNamein.Text}', '{LastNameIn.Text}', '{builder.ToString()}');";


                bool IfExist = CheckingHowMany(builder.ToString(), "PhoneNumber");

                if (IfExist)
                {
                    ErrorExist.Visible = true;
                    PhoneNumIn.Clear();
                    PhoneNumIn.Focus();
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(insertString, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        label6.Visible = true;
                        FirstNamein.Clear();
                        LastNameIn.Clear();
                        PhoneNumIn.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
