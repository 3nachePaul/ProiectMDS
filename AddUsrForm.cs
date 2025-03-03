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

namespace ProiectMDS
{
    public partial class AddUsrForm : Form
    {
        public AddUsrForm()
        {
            InitializeComponent();
            button1.Click += button1_Click_1;
            button2.Click += button2_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddUsrForm_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = NameTB.Text;
            string prenume = PrenumeTB.Text;
            string telefon = TelefonTB.Text;
            string mail = MailTB.Text;
            string carId = CarIDTB.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE CarID = @carId", con))
                {
                    cmd.Parameters.AddWithValue("@carId", carId);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("The CarID doesn't exist!");
                        return;
                    }
                }
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True"))
            { 
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Nume, Prenume, NrTelefon, Email, CarID) VALUES (@name, @prenume, @telefon, @mail, @carId)", con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@prenume", prenume);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@carId", carId);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
