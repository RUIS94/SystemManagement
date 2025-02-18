using System.Net.Http;
using Model;
using UI.Controls;
using UI.Forms;
using UI.Services;

namespace UI
{
    public partial class SignForm : Form
    {
        //private MainForm main;
        private MainProgram main;
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        public string userPassword { get; private set; }
        //public SignForm(MainForm main)
        public SignForm(MainProgram main)
        {
            InitializeComponent();
            this.main = main;
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
            usernameBox.Text = "admin";
            passwordBox.Text = "admin";
        }

        private void cancelBrn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void okBtn_Click(object sender, EventArgs e)
        {
            IsValid isValid = new IsValid();
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            if (!isValid.NullVal(username) || !isValid.NullVal(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }
            try
            {
                bool match = await apiService.PasswordMatch(username, password);
                if (match)
                {
                    string role = await apiService.GetRoleAsync(username, password);
                    main.SetUserLoggedIn(username, role);
                    userPassword = password;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
        }
        public string SetPassword()
        {
            return userPassword;
        }
        private void SignForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
        }
    }
}
