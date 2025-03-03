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
            GA = 10;
            GB = 10;
            GC = 10;
            SearchButton.Click += SearchButton_Click;
            SearchBox.KeyPress += SearchBox_KeyPress;
            AddButton.Click += AddButton_Click;
            DeleteCarButton.Click += DeleteCarButton_Click;
            EditButton.Click += EditButton_Click;
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
            dataGridView1.Refresh();
            con.Close();
        }

        public void showusers(string search = "")
        {
            con.Open();
            SqlCommand cmd;
            if (string.IsNullOrEmpty(search))
            {
                cmd = new SqlCommand("SELECT * FROM users", con);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM users WHERE CAST(UserID AS VARCHAR(10)) LIKE @search OR Username LIKE @search", con);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            UsersPanel.BringToFront();
            UsersPanel.Visible = true;
            CarsPanel.Visible = false;
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
                e.Handled = true; 
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Owner = this; 
            addCarForm.Show();
        }
        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this car?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    string carId = dataGridView1.SelectedRows[0].Cells["CarID"].Value.ToString();

                
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Cars WHERE CarID = @carId", con);
                    cmd.Parameters.AddWithValue("@carId", carId);

                    cmd.ExecuteNonQuery();

                    con.Close();

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
            UsersPanel.Visible = false;
            showcars();
            showusers();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CarsPanel.Visible = true;
            UsersPanel.Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int GA { get; set; }
        public int GB { get; set; }
        public int GC { get; set; }

        /*public int VA { get; set; }
        private int VB { get; set; }
        private int VC { get; set; }*/
        public int RA { get; set; }
        public int RB { get; set; }
        public int RC { get; set; }



        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string carId = dataGridView1.SelectedRows[0].Cells["CarID"].Value.ToString();
                string carNumber = dataGridView1.SelectedRows[0].Cells["CarNumber"].Value.ToString();
                string carBrand = dataGridView1.SelectedRows[0].Cells["CarBrand"].Value.ToString();
                string carModel = dataGridView1.SelectedRows[0].Cells["CarModel"].Value.ToString();
                string carYear = dataGridView1.SelectedRows[0].Cells["CarYear"].Value.ToString();
                string carColor = dataGridView1.SelectedRows[0].Cells["CarColor"].Value.ToString();

                EditCarForm editCarForm = new EditCarForm(carId, carNumber, carBrand, carModel, carYear, carColor);
                editCarForm.Owner = this;
                editCarForm.ShowDialog();

                showcars();
            }
            else
            {
                MessageBox.Show("Please select a car to edit.");
            }
        }

        private void AddUserBTN_Click(object sender, EventArgs e)
        {
            AddUsrForm addUsrForm = new AddUsrForm();
            addUsrForm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


    }
}
