using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProiectMDS
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=POL-LAPTOP\SQLEXPRESS;Initial Catalog=AppParcare;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            SearchButton.Click += SearchButton_Click;
            SearchBox.KeyPress += SearchBox_KeyPress;
            AddButton.Click += AddButton_Click; // Add this line
            DeleteCarButton.Click += DeleteCarButton_Click; // Add this line
        }

        public void showcars(string search = "")
        {
            con.Open();
            SqlCommand cmd;
            if (string.IsNullOrEmpty(search))
            {
                cmd = new SqlCommand("SELECT * FROM Cars", con);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM Cars WHERE CAST(CarID AS VARCHAR(10)) LIKE @search OR CarNumber LIKE @search", con);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            showcars(SearchBox.Text);
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                showcars(SearchBox.Text);
                e.Handled = true; // Prevent the beep
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Owner = this; // Set the owner of the AddCarForm instance to this Form1 instance
            addCarForm.Show();
        }
        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Display a confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this car?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Get the CarID of the selected car
                    string carId = dataGridView1.SelectedRows[0].Cells["CarID"].Value.ToString();

                    // Open the connection
                    con.Open();

                    // Create a SQL DELETE command
                    SqlCommand cmd = new SqlCommand("DELETE FROM Cars WHERE CarID = @carId", con);
                    cmd.Parameters.AddWithValue("@carId", carId);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Close the connection
                    con.Close();

                    // Refresh the DataGridView
                    showcars();
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarsPanel.Visible = false;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Show panel1 and hide panel2
            CarsPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
