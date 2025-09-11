using Microsoft.Data.SqlClient;
using System.Data;

namespace WFA_CarRental;

public partial class FormCars : Form
{
    // Connection string for the database
    private const string ConnStr = "Server=YOUR_SERVER;Database=CarRentalDB;User Id=USERNAME;Password=PASSWORD;TrustServerCertificate=True";

    public FormCars()
    {
        InitializeComponent();
    }

    private void FormCars_Load(object sender, EventArgs e)
    {
        // Load all cars into DataGridView when the form opens
        LoadCars();

        // Populate FuelType ComboBox
        cmbFuelType.Items.Clear();
        cmbFuelType.Items.Add("Hybrid");
        cmbFuelType.Items.Add("Elektrik");
        cmbFuelType.Items.Add("Dizel");
        cmbFuelType.Items.Add("Benzin");

        // Populate GearType (Transmission) ComboBox
        cmbGearType.Items.Clear();
        cmbGearType.Items.Add("Otomatik");
        cmbGearType.Items.Add("Manuel");
    }

    private void LoadCars()
    {
        // Load cars from database into DataGridView
        using (SqlConnection conn = new(ConnStr))
        {
            SqlDataAdapter da = new("SELECT * FROM Cars", conn);
            DataTable dt = new();
            da.Fill(dt);
            dgvCars.DataSource = dt;
        }
    }

    // ---------------------------
    // ADD a new car
    // ---------------------------
    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new(ConnStr))
        {
            string query = @"INSERT INTO Cars 
                            (Brand, Model, Year, PlateNumber, DailyPrice, Mileage, FuelType, Transmission) 
                            VALUES 
                            (@Brand, @Model, @Year, @PlateNumber, @DailyPrice, @Mileage, @FuelType, @Transmission)";

            SqlCommand sqlCommand = new(query, conn);

            // Add parameters from textboxes and comboboxes
            sqlCommand.Parameters.AddWithValue("@Brand", txtBrand.Text);
            sqlCommand.Parameters.AddWithValue("@Model", txtModel.Text);
            sqlCommand.Parameters.AddWithValue("@Year", Convert.ToInt32(txtYear.Text));
            sqlCommand.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text);
            sqlCommand.Parameters.AddWithValue("@DailyPrice", Convert.ToDecimal(txtDailyPrice.Text));
            sqlCommand.Parameters.AddWithValue("@Mileage", Convert.ToInt32(txtMileAge.Text));
            sqlCommand.Parameters.AddWithValue("@FuelType", cmbFuelType.SelectedItem?.ToString());
            sqlCommand.Parameters.AddWithValue("@Transmission", cmbGearType.SelectedItem?.ToString());

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            // Refresh DataGridView after adding
            LoadCars();
        }
    }

    // ---------------------------
    // UPDATE an existing car
    // ---------------------------
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvCars.SelectedRows.Count > 0)
        {
            // Get selected CarID
            int id = Convert.ToInt32(dgvCars.CurrentRow.Cells["CarID"].Value);

            using (SqlConnection conn = new(ConnStr))
            {
                string query = @"UPDATE Cars SET 
                                    Brand=@Brand, 
                                    Model=@Model, 
                                    Year=@Year, 
                                    PlateNumber=@PlateNumber, 
                                    DailyPrice=@DailyPrice, 
                                    Mileage=@Mileage, 
                                    FuelType=@FuelType, 
                                    Transmission=@Transmission
                                WHERE CarID=@CarID";

                SqlCommand sqlCommand = new(query, conn);

                // Add parameters from UI
                sqlCommand.Parameters.AddWithValue("@Brand", txtBrand.Text);
                sqlCommand.Parameters.AddWithValue("@Model", txtModel.Text);
                sqlCommand.Parameters.AddWithValue("@Year", Convert.ToInt32(txtYear.Text));
                sqlCommand.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text);
                sqlCommand.Parameters.AddWithValue("@DailyPrice", Convert.ToDecimal(txtDailyPrice.Text));
                sqlCommand.Parameters.AddWithValue("@Mileage", Convert.ToInt32(txtMileAge.Text));
                sqlCommand.Parameters.AddWithValue("@FuelType", cmbFuelType.SelectedItem?.ToString());
                sqlCommand.Parameters.AddWithValue("@Transmission", cmbGearType.SelectedItem?.ToString());
                sqlCommand.Parameters.AddWithValue("@CarID", id);

                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                // Refresh DataGridView after update
                LoadCars();
            }
        }
    }

    // ---------------------------
    // DELETE a car
    // ---------------------------
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvCars.SelectedRows.Count > 0)
        {
            // Get selected CarID
            int id = Convert.ToInt32(dgvCars.CurrentRow.Cells["CarID"].Value);

            using (SqlConnection conn = new(ConnStr))
            {
                string query = "DELETE FROM Cars WHERE CarID=@CarID";
                SqlCommand sqlCommand = new(query, conn);
                sqlCommand.Parameters.AddWithValue("@CarID", id);

                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                // Refresh DataGridView after deletion
                LoadCars();
            }
        }
    }
}
