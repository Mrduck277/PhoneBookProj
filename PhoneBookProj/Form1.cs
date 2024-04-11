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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection("data source=PC22\\SQLEXPRESS;initial catalog=NewPhoneBook;integrated security=True;Encrypt=False");
            string insertString = $"insert into PhoneBookData (Firstname, LastName, PhoneNumber) values ('{FirstNamein.Text}', '{LastNameIn.Text}', '{PhoneNumIn.Text}');";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(insertString, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
