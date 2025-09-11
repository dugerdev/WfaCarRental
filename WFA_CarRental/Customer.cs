using Microsoft.Data.SqlClient;
using System.Data;

namespace WFA_CarRental
{
    public partial class Customer : Form
    {
        // Database connection string
        private const string ConnStr = "Server=YOUR_SERVER;Database=CarRentalDB;User Id=USERNAME;Password=PASSWORD;TrustServerCertificate=True";

        public Customer()
        {
            InitializeComponent();
        }

        // ---------- LOAD CUSTOMERS ----------
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(ConnStr))
            {
                SqlDataAdapter da = new("Select * From Customers", conn);
                DataTable dt = new();
                da.Fill(dt);

                // Bind data to DataGridView
                dgvCustomers.DataSource = dt;
            }
        }

        // ---------- ADD CUSTOMER ----------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(ConnStr))
            {
                string query = "INSERT INTO Customers (FirstName, LastName, Phone, Email, DriverLicense) VALUES (@FirstName, @LastName, @Phone, @Email, @DriverLicense)";
                SqlCommand sqlCommand = new(query, conn);

                // Add parameters from textboxes
                sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text);
                sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCommand.Parameters.AddWithValue("@DriverLicense", txtDriverLicense.Text);

                // Execute insert
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                // Refresh customer list
                btnLoad_Click(null, null);
            }
        }

        // ---------- UPDATE CUSTOMER ----------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                // Get selected customer ID
                int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

                using (SqlConnection conn = new(ConnStr))
                {
                    string query = "UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, Phone=@Phone, Email=@Email, DriverLicense=@DriverLicense WHERE CustomerID=@CustomerID";
                    SqlCommand sqlCommand = new(query, conn);

                    // Add parameters from textboxes
                    sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@DriverLicense", txtDriverLicense.Text);
                    sqlCommand.Parameters.AddWithValue("@CustomerID", id);

                    // Execute update
                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();

                    // Refresh customer list
                    btnLoad_Click(null, null);
                }
            }
        }

        // ---------- DELETE CUSTOMER ----------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                // Get selected customer ID
                int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

                using (SqlConnection conn = new(ConnStr))
                {
                    string query = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                    SqlCommand sqlCommand = new(query, conn);

                    // Add parameter
                    sqlCommand.Parameters.AddWithValue("@CustomerID", id);

                    // Execute delete
                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();

                    // Refresh customer list
                    btnLoad_Click(null, null);
                }
            }
        }

        // ---------- OPEN EMPLOYEES FORM ----------
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmplooyes formEmplooyes = new();
            formEmplooyes.ShowDialog();
        }

        // ---------- OPEN CARS FORM ----------
        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCars formCars = new();
            formCars.ShowDialog();
        }

        // ---------- OPEN RENTALS FORM ----------
        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRentals formRentals = new();
            formRentals.ShowDialog();
        }
    }
}
