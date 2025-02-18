using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using UI;

namespace UI.Controls
{
    public partial class ChatAI : UserControl
    {
        ShareFile sf = new ShareFile();
        public ChatAI()
        {
            InitializeComponent();
            chatBox.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void caCloseL_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        private async void sendBtn_Click(object sender, EventArgs e)
        {
            string userInput = inputBox.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                sf.ShowMessage("Please enter some text.");
                return;
            }
            AppendMessage(userInput, HorizontalAlignment.Right);
            inputBox.Clear();
            try
            {
                string aiResponse = await GetAIResponseAsync(userInput);
                AppendMessage(aiResponse, HorizontalAlignment.Left);
            }
            catch (Exception ex)
            {
                sf.HandleException(ex);
            }
        }
        private void AppendMessage(string message, HorizontalAlignment alignment)
        {
            chatBox.SelectionAlignment = alignment;
            chatBox.AppendText($"{message}{Environment.NewLine}{Environment.NewLine}");
            chatBox.ScrollToCaret();
        }
        private async Task<string> GetAIResponseAsync(string prompt)
        {
            var openAIClient = new OpenAIClient();
            return await openAIClient.GetResponseAsync(prompt);
        }
    }
}
public class OpenAIClient
{
    private static readonly HttpClient client = new HttpClient();
    private string ApiKey;
    private const string ApiUrl = "https://api.openai.com/v1/chat/completions";
    ShareFile sf = new ShareFile();
    public OpenAIClient()
    {
        LoadSensitiveInfo();
    }
    private void LoadSensitiveInfo()
    {
        string rp = sf.RP();
        string xmlFilePath = $"{rp}UI\\SensitiveInfo.xml";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        ApiKey = xmlDoc.SelectSingleNode("/SensitiveInfo/ApiKey").InnerText;
    }
    public async Task<string> GetResponseAsync(string prompt)
    {
        var requestBody = new
        {
            model = "gpt-4o-mini",
            store = true,
            messages = new[]
            {
                new { role = "user", content = prompt }
            }
        };

        var json = JsonConvert.SerializeObject(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ApiKey);

        var response = await client.PostAsync(ApiUrl, content);
        var responseString = await response.Content.ReadAsStringAsync();

        var responseObject = JsonConvert.DeserializeObject<dynamic>(responseString);
        string aiMessage = responseObject.choices[0].message.content;

        return aiMessage;
    }
}