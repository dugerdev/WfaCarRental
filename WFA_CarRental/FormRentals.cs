using Microsoft.Data.SqlClient;
using System.Data;

namespace WFA_CarRental;

public partial class FormRentals : Form
{
    private const string ConnStr = "Server=YOUR_SERVER;Database=CarRentalDB;User Id=USERNAME;Password=PASSWORD;TrustServerCertificate=True";

    public FormRentals()
    {
        InitializeComponent();
    }

    private void FormRentals_Load(object sender, EventArgs e)
    {
        LoadRentals();
        LoadCustomers();
        LoadCars();
        LoadEmployees();
    }

    // Load employees into the ComboBox
    private void LoadEmployees()
    {
        using (SqlConnection conn = new(ConnStr))
        {
            SqlDataAdapter da = new("SELECT EmployeeID, FirstName + ' ' + LastName AS FullName FROM Employees", conn);
            DataTable dt = new();
            da.Fill(dt);

            cmbEmployee.DataSource = dt;
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeID";
        }
    }

    // Load rentals into the DataGridView
    private void LoadRentals()
    {
        using (SqlConnection conn = new(ConnStr))
        {
            SqlDataAdapter da = new("SELECT * FROM Rentals", conn);
            DataTable dt = new();
            da.Fill(dt);
            dgvRentals.DataSource = dt;
        }
    }

    // Load customers into the ComboBox
    private void LoadCustomers()
    {
        using (SqlConnection conn = new(ConnStr))
        {
            string query = "SELECT CustomerID, FirstName + ' ' + LastName AS FullName FROM Customers";
            SqlDataAdapter da = new(query, conn);
            DataTable dt = new();
            da.Fill(dt);

            cmbCustomer.DataSource = dt;
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "CustomerID";
        }
    }

    // Load cars into the ComboBox
    private void LoadCars()
    {
        using (SqlConnection conn = new(ConnStr))
        {
            string query = "SELECT CarID, Brand + ' ' + Model AS CarName FROM Cars";
            SqlDataAdapter da = new(query, conn);
            DataTable dt = new();
            da.Fill(dt);

            cmbCar.DataSource = dt;
            cmbCar.DisplayMember = "CarName";
            cmbCar.ValueMember = "CarID";
        }
    }

    // ---------- ADD RENTAL ----------
    private void btnAddRental_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new(ConnStr))
        {
            string query = @"INSERT INTO Rentals 
                            (CustomerID, CarID, EmployeeID, RentDate, ExpectedReturnDate, ActualReturnDate, TotalAmount, Status)
                             VALUES (@CustomerID, @CarID, @EmployeeID, @RentDate, @ExpectedReturnDate, @ActualReturnDate, @TotalAmount, @Status)";

            SqlCommand cmd = new(query, conn);

            // Parameters
            cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(cmbCustomer.SelectedValue));
            cmd.Parameters.AddWithValue("@CarID", Convert.ToInt32(cmbCar.SelectedValue));
            cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(cmbEmployee.SelectedValue));
            cmd.Parameters.AddWithValue("@RentDate", dtpRentDate.Value);
            cmd.Parameters.AddWithValue("@ExpectedReturnDate", dtpExpectedReturnDate.Value);

            // ActualReturnDate (always set to a date for now)
            cmd.Parameters.AddWithValue("@ActualReturnDate", dtpActualReturnDate.Value);

            // TotalAmount with safe conversion
            decimal amount = 0;
            decimal.TryParse(txtTotalAmount.Text, out amount);
            cmd.Parameters.AddWithValue("@TotalAmount", amount);

            // Status (if empty, default to "Pending")
            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString() ?? "Pending");

            // Execute query
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(rows > 0 ? "Record added" : "Failed to add record");
            LoadRentals();
        }
    }

    // ---------- UPDATE RENTAL ----------
    private void btnUpdateRental_Click(object sender, EventArgs e)
    {
        if (dgvRentals.SelectedRows.Count > 0)
        {
            int id = Convert.ToInt32(dgvRentals.CurrentRow.Cells["RentalID"].Value);

            using (SqlConnection conn = new(ConnStr))
            {
                string query = @"UPDATE Rentals SET 
                                CustomerID=@CustomerID, CarID=@CarID, EmployeeID=@EmployeeID, RentDate=@RentDate,
                                ExpectedReturnDate=@ExpectedReturnDate, ActualReturnDate=@ActualReturnDate,
                                TotalAmount=@TotalAmount, Status=@Status
                                WHERE RentalID=@RentalID";

                SqlCommand cmd = new(query, conn);

                // Parameters
                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(cmbCustomer.SelectedValue));
                cmd.Parameters.AddWithValue("@CarID", Convert.ToInt32(cmbCar.SelectedValue));
                cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(cmbEmployee.SelectedValue));
                cmd.Parameters.AddWithValue("@RentDate", dtpRentDate.Value);
                cmd.Parameters.AddWithValue("@ExpectedReturnDate", dtpExpectedReturnDate.Value);
                cmd.Parameters.AddWithValue("@ActualReturnDate", dtpActualReturnDate.Value);

                decimal amount = 0;
                decimal.TryParse(txtTotalAmount.Text, out amount);
                cmd.Parameters.AddWithValue("@TotalAmount", amount);

                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString() ?? "Pending");
                cmd.Parameters.AddWithValue("@RentalID", id);

                // Execute query
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rows > 0 ? "Record updated" : "Failed to update record");
                LoadRentals();
            }
        }
    }

    // ---------- DELETE RENTAL ----------
    private void btnDeleteRental_Click(object sender, EventArgs e)
    {
        if (dgvRentals.SelectedRows.Count > 0)
        {
            int id = Convert.ToInt32(dgvRentals.CurrentRow.Cells["RentalID"].Value);

            using (SqlConnection conn = new(ConnStr))
            {
                string query = "DELETE FROM Rentals WHERE RentalID=@RentalID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@RentalID", id);

                // Execute query
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rows > 0 ? "Record deleted" : "Failed to delete record");
                LoadRentals();
            }
        }
    }
}
