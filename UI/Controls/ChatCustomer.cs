using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace UI.Controls
{
    public partial class ChatCustomer : UserControl
    {
        ShareFile sf = new ShareFile();
        private HubConnection connection;
        public ChatCustomer()
        {
            InitializeComponent();
            InitializeSignalR();
            chatBox.SelectionAlignment = HorizontalAlignment.Left;
        }
        private async void InitializeSignalR()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7207/chatHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Invoke(new Action(() =>
                {
                    chatBox.AppendText($"{user}: {message}{Environment.NewLine}");
                }));
            });
            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                sf.HandleException(ex);
            }
        }
        private async void sendBtn_Click(object sender, EventArgs e)
        {
            string user = "Support";
            string userInput = inputBox.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                sf.ShowMessage("Please enter some text.");
                return;
            }
            await connection.SendAsync("SendMessage", user, userInput);
            AppendMessage(userInput, HorizontalAlignment.Right);
            inputBox.Clear();
        }
        private void AppendMessage(string message, HorizontalAlignment alignment)
        {
            chatBox.SelectionAlignment = alignment;
            chatBox.AppendText($"{message}{Environment.NewLine}{Environment.NewLine}");
            chatBox.ScrollToCaret();
        }
        private async Task<string> GetResponseAsync()
        {
            var fromCust = string.Empty;
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                fromCust = $"{user}: {message}";
            });
            return fromCust;
        }
        private void caCloseL_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
