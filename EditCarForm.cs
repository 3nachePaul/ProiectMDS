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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace ProiectMDS
{
    public partial class EditCarForm : Form
    {
        private string carId;
        public EditCarForm(string carId, string carNumber, string brand, string model, string year, string color)
        {
            InitializeComponent();

            this.carId = carId;
            CarNumberTextBox.Text = carNumber;
            BrandTextBox.Text = brand;
            ModelTextBox.Text = model;
            YearTextBox.Text = year;
            ColorTextBox.Text = color;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string carNumber = CarNumberTextBox.Text;
            string carBrand = BrandTextBox.Text;
            string carModel = ModelTextBox.Text;
            string carYear = YearTextBox.Text;
            string carColor = ColorTextBox.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Cars SET CarNumber = @carNumber, CarBrand = @carBrand, CarModel = @carModel, CarYear = @carYear, CarColor = @carColor WHERE CarID = @carId", con);
                cmd.Parameters.AddWithValue("@carNumber", carNumber);
                cmd.Parameters.AddWithValue("@carBrand", carBrand);
                cmd.Parameters.AddWithValue("@carModel", carModel);
                cmd.Parameters.AddWithValue("@carYear", carYear);
                cmd.Parameters.AddWithValue("@carColor", carColor);
                cmd.Parameters.AddWithValue("@carId", carId);

                cmd.ExecuteNonQuery();

                con.Close();
            }

            this.Close();
        }





    }
}
