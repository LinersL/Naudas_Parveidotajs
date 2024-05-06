using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Naudas_parveidotajs_12G
{
    public partial class Pierakstisanas : Form
    {
        private string connectionString = @"Data Source=C:\visual\Naudas_parveidotajs_12G (1)\Naudas_parveidotajs_12G\Naudas_parveidotajs_12G\bin\Debug\NaudaPar.db;Version=3;";

        public Pierakstisanas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string epasts = txtEPasts.Text;
            string parole = tXtParole.Text;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Registracija WHERE Epasts = @Epasts AND Parole = @Parole";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Epasts", epasts);
                        command.Parameters.AddWithValue("@Parole", parole);

                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Login successful, show appropriate form
                            MessageBox.Show("Login successful!");

                            // Check if admin login
                            if (epasts == "admin@admin" && parole == "123456789")
                            {
                                Form4 b1 = new Form4();
                                b1.ShowDialog();
                            }
                            else
                            {
                                Form3 a1 = new Form3();
                                this.Hide();
                                a1.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show registration form
            Registracija a1 = new Registracija();
            this.Hide();
            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show password in plaintext
            tXtParole.PasswordChar = '\0';
            button4.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hide password characters
            tXtParole.PasswordChar = '*';
            button3.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Show another instance of Form3
            Form3 a1 = new Form3();
            this.Hide();
            a1.ShowDialog();
        }
    }
}
