using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Naudas_parveidotajs_12G
{
    public partial class Form3 : Form
    {
        private const string ApiBaseUrl = "https://api.exchangeratesapi.io/latest";
        public Form3()
        {
            InitializeComponent();

            // Populate currency dropdowns with common currencies
            comboBoxSourceCurrency.Items.AddRange(new[] { "USD", "EUR", "GBP", "JPY" });
            comboBoxTargetCurrency.Items.AddRange(new[] { "USD", "EUR", "GBP", "JPY" });

            // Set default currencies
            comboBoxSourceCurrency.SelectedItem = "USD";
            comboBoxTargetCurrency.SelectedItem = "EUR";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private async void buttonConvert_Click(object sender, EventArgs e)
        {
            string sourceCurrency = comboBoxSourceCurrency.SelectedItem.ToString();
            string targetCurrency = comboBoxTargetCurrency.SelectedItem.ToString();

            if (string.IsNullOrEmpty(textBoxAmount.Text))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            decimal amount;
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            try
            {
                string apiUrl = $"{ApiBaseUrl}?base={sourceCurrency}&symbols={targetCurrency}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Extract the exchange rate from the response body (assuming fixed response format)
                    int startIndex = responseBody.IndexOf(targetCurrency) + targetCurrency.Length + 3;
                    int endIndex = responseBody.IndexOf("}", startIndex);

                    string exchangeRateStr = responseBody.Substring(startIndex, endIndex - startIndex);
                    decimal exchangeRate = decimal.Parse(exchangeRateStr);

                    decimal convertedAmount = amount * exchangeRate;

                    labelResult.Text = $"{amount} {sourceCurrency} = {convertedAmount} {targetCurrency}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    


    }
}
