using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace UI.Controls
{
    public partial class CurrencyExchange : UserControl
    {
        private const string API_URL = "http://api.exchangeratesapi.io/v1/latest?access_key=18cae1fba0dd8e8b1cb39bc37dc82e03";
        ShareFile sf = new ShareFile();
        public CurrencyExchange()
        {
            InitializeComponent();
        }
        public class Currency
        {
            public string Code { get; set; }
            public string Rate { get; set; }
        }

        private void CurrencyExchange_Load(object sender, EventArgs e)
        {
            SetComboBox();
        }
        private string[] codeList;
        private string[] CodeList()
        {
            return codeList = ["AUD", "CAD", "CNY", "EUR", "GBP", "HKD", "JPY", "KRW", "NZD", "USD", "WST"];
        }
        private void SetComboBox()
        {
            CodeList();
            fromBox.Items.Add("GBP");
            foreach (string code in codeList)
            {
                //fromBox.Items.Add(code);
                toBox.Items.Add(code);
            }
        }

        private async void formTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fromBox.SelectedItem == null || toBox.SelectedItem == null) 
            {
                return;
            }
            if (decimal.TryParse(fromTextBox.Text, out decimal amount))
            {
                string fromCurrency = fromBox.SelectedItem.ToString();
                string toCurrency = toBox.SelectedItem.ToString();
                decimal result = await ConvertCurrency(amount, fromCurrency, toCurrency);
                toTextBox.Text = result.ToString("F4");
            }
            else
            {
                sf.ShowMessage("Error");
            }
        }
        private async Task<decimal> ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            //string url = $"{API_URL}&base={fromCurrency}&symbols={toCurrency}";
            string url = $"{API_URL}&symbols={toCurrency}";
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(url);
                JObject json = JObject.Parse(response);

                decimal rate = (decimal)json["rates"][toCurrency];
                return amount * rate;
            }
        }
    }
}
