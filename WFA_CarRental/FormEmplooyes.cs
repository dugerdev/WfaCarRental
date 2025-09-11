using Microsoft.Data.SqlClient;
using System.Data;

namespace WFA_CarRental;

public partial class FormEmplooyes : Form
{
    // Database connection string
    private const string ConnStr = "Server=YOUR_SERVER;Database=CarRentalDB;User Id=USERNAME;Password=PASSWORD;TrustServerCertificate=True";

    public FormEmplooyes()
    {
        InitializeComponent();
    }

    private void FormEmplooyes_Load(object sender, EventArgs e)
    {
        // Load employees when form loads
        EmployeesLoad();
    }

    // ---------- LOAD EMPLOYEES ----------
    private void EmployeesLoad()
    {
        using (SqlConnection conn = new(ConnStr))
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Employees", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Bind data to DataGridView
            dgvEmployees.DataSource = dt;
        }
    }

    // ---------- ADD EMPLOYEE ----------
    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new(ConnStr))
        {
            string query = "INSERT INTO Employees (FirstName,LastName,Position) VALUES (@FirstName, @LastName, @Position)";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            // Add parameters from textboxes
            sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@Position", txtPosition.Text);

            // Execute insert
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            // Refresh data
            EmployeesLoad();
        }
    }

    // ---------- UPDATE EMPLOYEE ----------
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvEmployees.SelectedRows.Count > 0)
        {
            // Get selected employee ID
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            using (SqlConnection conn = new(ConnStr))
            {
                string query = "Update Employees SET FirstName = @FirstName , LastName=@LastName, Position=@Position Where EmployeeID = @EmployeeID ";
                SqlCommand sqlCommand = new(query, conn);

                // Add parameters from textboxes
                sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                sqlCommand.Parameters.AddWithValue("@Position", txtPosition.Text);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", id);

                // Execute update
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                // Refresh data
                EmployeesLoad();
            }
        }
    }

    // ---------- DELETE EMPLOYEE ----------
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvEmployees.SelectedRows.Count > 0)
        {
            // Get selected employee ID
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            using (SqlConnection conn = new(ConnStr))
            {
                string query = "DELETE FROM Employees Where EmployeeID = @EmployeeID";
                SqlCommand sqlCommand = new(query, conn);

                // Add parameter
                sqlCommand.Parameters.AddWithValue("@EmployeeID", id);

                // Execute delete
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                // Refresh data
                EmployeesLoad();
            }
        }
    }
}
