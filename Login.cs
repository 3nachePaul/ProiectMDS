using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ProiectMDS
{
    public partial class Login : Form
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public Login()
        {
            InitializeComponent();
            UpdateLogDataXml();
        }

        public void UpdateLogDataXml()
        {
            XDocument doc = XDocument.Load("C:\\Users\\Paul\\source\\repos\\ProiectMDS\\LogData.xml");

            doc.Root.Elements("User").Where(user => user.Element("Username").Value != "admin").Remove();

            using (SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Prenume, Nume FROM Users WHERE Prenume != 'admin'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string password = reader.GetString(1);

                            string hashedPassword = HashPassword(password);

                            doc.Root.Add(new XElement("User",
                                new XElement("Username", name),
                                new XElement("Password", hashedPassword)
                            ));
                        }
                    }
                }

                con.Close();
            }

            doc.Save("C:\\Users\\Paul\\source\\repos\\ProiectMDS\\LogData.xml");
        }



        private void UsrLogButton_Click(object sender, EventArgs e)
        {

            string name = UsrNameBox.Text;
            string password = UsrPassBox.Text;

            string hashedPassword = HashPassword(password);

            XDocument doc = XDocument.Load("C:\\Users\\Paul\\source\\repos\\ProiectMDS\\LogData.xml");

            bool isValidUser = doc.Root.Elements("User").Any(user =>
                user.Element("Username").Value == name && user.Element("Password").Value == hashedPassword
            );

            if (isValidUser)
            {
                if (name == "admin")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    Form1 form1 = new Form1(); 
                    MapForm mapForm = new MapForm(form1);
                    mapForm.Show();

                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
