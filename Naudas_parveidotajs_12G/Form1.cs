using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Naudas_parveidotajs_12G
{
    public partial class Registracija : Form
    {

        public Registracija()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData();
        }
        public void InsertData()
        {
            string connectionString = @"Data Source=C:\visual\Naudas_parveidotajs_12G (1)\Naudas_parveidotajs_12G\Naudas_parveidotajs_12G\bin\Debug\NaudaPar.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Registracija (Vards, Uzvards, Epasts, Parole) VALUES (@Vards, @Uzvards, @Epasts, @Parole)";
                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                string vards = txtVards.Text;
                string uzvards = textBox2.Text;
                string epasts = txtEpasts.Text;
                string parole = txtParole.Text;

                command.Parameters.AddWithValue("@Vards", vards);
                command.Parameters.AddWithValue("@Uzvards", uzvards);
                command.Parameters.AddWithValue("@Epasts", epasts);
                command.Parameters.AddWithValue("@Parole", parole);

                command.ExecuteNonQuery();

                connection.Close();
            }

        }
        

       
        private static string Sifrs(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pierakstisanas a1 = new Pierakstisanas();
            a1.ShowDialog();

        }
    }

}

