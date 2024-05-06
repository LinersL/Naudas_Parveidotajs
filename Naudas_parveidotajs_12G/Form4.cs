using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Naudas_parveidotajs_12G
{
    public partial class Form4 : Form
    {
        private string connectionString = @"Data Source=C:\visual\Naudas_parveidotajs_12G (1)\Naudas_parveidotajs_12G\Naudas_parveidotajs_12G\bin\Debug\NaudaPar.db;Version=3;";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView on form load
            LoadDataRegistracija();
        }

        private void LoadDataRegistracija()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Registracija";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind DataTable to DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadDataNauda()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Dati";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind DataTable to DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void buttonLoadRegistracija_Click(object sender, EventArgs e)
        {
            LoadDataRegistracija();
        }

        private void buttonLoadNauda_Click(object sender, EventArgs e)
        {
            LoadDataNauda();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the value of the primary key column (assuming it's named "Lietotaja_ID")
                    int lietotajaId = Convert.ToInt32(selectedRow.Cells["Lietotaja_ID"].Value);

                    // Delete the row from the DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    // Delete the row from the database
                    DeleteRowFromDatabase(lietotajaId);

                    MessageBox.Show("Row deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting row: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void DeleteRowFromDatabase(int lietotajaId)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Registracija WHERE Lietotaja_ID = @Lietotaja_ID";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Lietotaja_ID", lietotajaId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting row from database: " + ex.Message);
            }
        }
    }
}
