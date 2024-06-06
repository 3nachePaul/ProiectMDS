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
using System.Text.RegularExpressions;


namespace ProiectMDS
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
            SaveCarButton.Click += SaveCarButton_Click;
            CancelCarButton.Click += CancelCarButton_Click;

        }
        private void SaveCarButton_Click(object sender, EventArgs e)
        {
            string carNumber = AddCarNumberTB.Text;
            string carBrand = AddCarBrandTB.Text;
            string carModel = AddCarModelTB.Text;
            string carColor = AddCarColorTB.Text;
            string carYear = AddCarYearTB.Text;

            // Check if car number is in correct format
            Regex pattern = new Regex(@"^[A-Z]{2} \d{2} [A-Z]{3}$");
            if (!pattern.IsMatch(carNumber))
            {
                MessageBox.Show("The number you introduced is not correct!");
                return;
            }

            // Check if car number already exists in the database
            using (SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE CarNumber = @carNumber", con);
                cmd.Parameters.AddWithValue("@carNumber", carNumber);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("The number you introduced already exists!");
                    MessageBox.Show("Closing form...");
                    this.Close();
                    return;
                }
            }

            // Add new car to the database
            using (SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cars (CarNumber, CarBrand, CarModel, CarColor, CarYear) VALUES (@carNumber, @carBrand, @carModel, @carColor, @carYear)", con);
                cmd.Parameters.AddWithValue("@carNumber", carNumber);
                cmd.Parameters.AddWithValue("@carBrand", carBrand);
                cmd.Parameters.AddWithValue("@carModel", carModel);
                cmd.Parameters.AddWithValue("@carColor", carColor);
                cmd.Parameters.AddWithValue("@carYear", carYear);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Your car was added!");

            // Refresh the data grid view
            ((Form1)this.Owner).showcars();

            this.Close();
        }

        private void CancelCarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Owner = this; // Set the owner of the AddCarForm instance to this Form1 instance
            addCarForm.Show();
        }*/

    }
}
