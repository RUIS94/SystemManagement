using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;
using UI.Services;

namespace UI.Controls
{
    public partial class MainProgram : UserControl
    {
        #region Methods
        ShareFile shareFile = new ShareFile();
        private readonly ApiService apiService;
        private bool isUserLoggedIn = false;
        private string? currentUserRole = string.Empty;
        private string? currentUserPassword;
        private string? currentUsername;
        public MainProgram()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
            this.Dock = DockStyle.Fill;
            StartProgram();
        }
        private void StartProgram()
        {
            shareFile.BindTextBoxEvent(this);
            DateTime now = DateTime.Now;
            timeLabel.Text = now.ToString("dd/MM/yyyy");
            ToolsControlsPosition();
            exchangeForm.Items.Add("Home Menu" + homePanel);
            SignOut();
        }
        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    shareFile.BindTextBoxEvent(this);
        //    DateTime now = DateTime.Now;
        //    timeLabel.Text = now.ToString("dd/MM/yyyy");
        //    ToolsControlsPosition();
        //    exchangeForm.Items.Add("Home Menu" + homePanel);
        //    SignOut();
        //}
        private void SigninConfirm()
        {
            if (shareFile.ConfirmAction("Please Sign in first", "Sign In"))
            {
                signBtn.PerformClick();
            }
        }
        private void SignOut()
        {
            isUserLoggedIn = false;
            signBtn.Text = "Sign in";
            currentUserRole = string.Empty;
            currentUserPassword = string.Empty;
            currentUsername = string.Empty;
            lockBtn.Visible = false;

        }
        public async void SetUserLoggedIn(string username, string role)
        {
            SignForm sign = new SignForm(this);
            isUserLoggedIn = true;
            currentUserRole = role;
            signBtn.Text = "Sign out";
            shareFile.ShowMessage($"Welcome {role} : {username}");
            currentUserRole = role;
            currentUsername = username;
            await apiService.InsertActionAsync(shareFile.RecodeAction($"{currentUsername} log in"));
            lockBtn.Visible = true;
        }
        public string CurrentUser()
        {
            return currentUsername;
        }
        private void CloseAllForm(object sender, EventArgs e)
        {
            foreach (Control child in homePanel.Controls)
            {
                if (child is Form)
                {
                    ((Form)child).Close();
                }
            }
        }
        //private void LockPanel()
        //{
        //    fucPanel.Enabled = false;
        //    mainBtnPanel.Enabled = false;
        //    homePanel.Enabled = false;
        //}
        //private void UnlockPanel()
        //{
        //    fucPanel.Enabled = true;
        //    mainBtnPanel.Enabled = true;
        //    homePanel.Enabled = true;
        //}
        private void ShowForm<T>(ref T form, string formName) where T : Form, new()
        {
            homePanel.Visible = true;

            if (form == null || form.IsDisposed)
            {
                form = new T();
                form.TopLevel = false;
                form.FormClosed += (s, args) => RemoveExchangeItem(formName);
                shareFile.SetForm(form, homePanel);
                exchangeForm.Items.Add(formName + form);
            }
            else
            {
                form.BringToFront();
            }
        }
        private void RemoveExchangeItem(string itemName)
        {
            for (int i = 0; i < exchangeForm.Items.Count; i++)
            {
                if (exchangeForm.Items[i].ToString().Contains(itemName))
                {
                    exchangeForm.Items.RemoveAt(i);
                    break;
                }
            }
            if (exchangeForm.Items.Count == 1 && exchangeForm.Items[0].ToString().Contains("Home Menu"))
            {
                homePanel.Visible = false;
            }
        }
        private void OnWallpaperChanged(string wallpaperPath)
        {
            if (File.Exists(wallpaperPath))
            {
                Image originalImage = Image.FromFile(wallpaperPath);
                homePanelContainer.BackgroundImage = originalImage;
                homePanelContainer.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                shareFile.ShowMessage($"Wallpaper file not found: {wallpaperPath}");
            }
        }
        private void ToolsControlsPosition()
        {
            shareFile.ResetControlPosition(RenewToolsControlList(), startY: 40, spacing: 2);
        }
        private List<Control> RenewToolsControlList()
        {
            List<Control> controls = new List<Control>
            {
                helpLabel, calendarBtn, calendarPanel, calculatorBtn, calculatorPanel, emailBtn, exchangeBtn, exchangePanel, wallpaperBtn
            };

            if (!calendarPanel.Visible)
            {
                controls.Remove(calendarPanel);
            }
            if (!calculatorPanel.Visible)
            {
                controls.Remove(calculatorPanel);
            }
            if (!exchangePanel.Visible)
            {
                controls.Remove(exchangePanel);
            }
            return controls;
        }
        private void MainBtnPosition()
        {
            shareFile.ResetControlPosition(RenewMainsBtnList(), startY: 40, spacing: 2);
        }
        private List<Control> RenewMainsBtnList()
        {
            List<Control> controls = new List<Control>
            {
                panel1, controlsBtnPanel, panel2, ordersBtnPanel, panel3, adminBtnPanel
            };

            if (!controlsBtnPanel.Visible)
            {
                controls.Remove(controlsBtnPanel);
            }
            if (!ordersBtnPanel.Visible)
            {
                controls.Remove(ordersBtnPanel);
            }
            if (!adminBtnPanel.Visible)
            {
                controls.Remove(adminBtnPanel);
            }
            return controls;
        }
        #endregion

        #region Forms Control
        //private void setBtn_Click(object sender, EventArgs e)
        //{
        //    mainPanel.Enabled = false;
        //    SettingForm setform = new SettingForm();
        //    setform.TopLevel = true;
        //    setform.FormClosed += (s, args) => mainPanel.Enabled = true;
        //    setform.ShowDialog();
        //    //setform.Show();
        //}
        private CustomerControlForm custform;
        private void custCtrlBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref custform, "Customer Control");
            }
            else
            {
                SigninConfirm();
            }
        }
        private ProductControlForm prodform;
        private void prodCtrlBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref prodform, "Product Control");
            }
            else
            {
                SigninConfirm();
            }
        }
        private SupplierControlForm suppform;
        private void suppCtrlBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref suppform, "Supplier Control");
            }
            else
            {
                SigninConfirm();
            }
        }
        private UserControlForm userform;
        private void userCtrlBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                if (currentUserRole == "manager")
                {
                    ShowForm(ref userform, "User Control");
                }
                else
                {
                    shareFile.ShowMessage("Sorry, you can not access this...");
                }
            }
            else
            {
                SigninConfirm();
            }

        }
        private CustomerOrder custord;
        private void cartCtrlBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref custord, "Customer Order");
            }
            else
            {
                SigninConfirm();
            }
        }
        private SupplierOrder suppord;
        private void suppOrderBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref suppord, "Supplier Order");
            }
            else
            {
                SigninConfirm();
            }
        }
        private GoodsReceived goodsin;
        private void goodsInBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref goodsin, "Goods Received");
            }
            else
            {
                SigninConfirm();
            }
        }
        private async void signBtn_Click(object sender, EventArgs e)
        {
            if (!isUserLoggedIn)
            {
                SignForm signform = new SignForm(this);
                signform.TopLevel = false;
                signform.FormClosed += (s, args) => currentUserPassword = signform.SetPassword();
                shareFile.SetForm(signform, homePanelContainer);
            }
            else
            {
                await apiService.InsertActionAsync(shareFile.RecodeAction($"{currentUsername} log out"));
                SignOut();
                CloseAllForm(sender, e);
            }
        }
        private TaskMenu tasks;
        private void taskMenuBtn_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                ShowForm(ref tasks, "Task Menu");
            }
            else
            {
                SigninConfirm();
            }
        }
        private HelpForm help;
        private void helpLabel_Click(object sender, EventArgs e)
        {
            ShowForm(ref help, "Help");
        }
        private CalendarForm calendar;
        private void openCalendar_Click(object sender, EventArgs e)
        {
            ShowForm(ref calendar, "Calendar");
        }
        private WallPaperForm wallpaper;
        private void wallpaperBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            if (wallpaper == null || wallpaper.IsDisposed)
            {
                wallpaper = new WallPaperForm();
                wallpaper.TopLevel = false;
                wallpaper.FormClosed += (s, args) => RemoveExchangeItem("Wallpaper");
                shareFile.SetForm(wallpaper, homePanel);
                exchangeForm.Items.Add("Wallpaper" + wallpaper);
                wallpaper.WallpaperChanged += OnWallpaperChanged;
            }
            else
            {
                wallpaper.BringToFront();
            }
        }
        private EmailForm email;
        private void emailBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            if (email == null || email.IsDisposed)
            {
                email = new EmailForm(null);
                email.TopLevel = false;
                email.FormClosed += (s, args) => RemoveExchangeItem("Email");
                shareFile.SetForm(email, homePanel);
                exchangeForm.Items.Add("Email" + email);
            }
            else
            {
                email.BringToFront();
            }
        }
        #endregion

        #region Other Action
        private void titleButton_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                taskMenuBtn.PerformClick();
            }
            else
            {
                SigninConfirm();
            }
        }
        private void controlsDisplayBtn_Click(object sender, EventArgs e)
        {
            if (!controlsBtnPanel.Visible)
            {
                controlsDisplayBtn.Text = "^";
                controlsBtnPanel.Visible = true;
                MainBtnPosition();
            }
            else
            {
                controlsDisplayBtn.Text = "v";
                controlsBtnPanel.Visible = false;
                MainBtnPosition();
            }
        }

        private void ordersDisplayBtn_Click(object sender, EventArgs e)
        {
            if (!ordersBtnPanel.Visible)
            {
                ordersDisplayBtn.Text = "^";
                ordersBtnPanel.Visible = true;
                MainBtnPosition();
            }
            else
            {
                ordersDisplayBtn.Text = "v";
                ordersBtnPanel.Visible = false;
                MainBtnPosition();
            }
        }

        private void adminDisplayBtn_Click(object sender, EventArgs e)
        {
            if (!adminBtnPanel.Visible)
            {
                adminDisplayBtn.Text = "^";
                adminBtnPanel.Visible = true;
                MainBtnPosition();
            }
            else
            {
                adminDisplayBtn.Text = "v";
                adminBtnPanel.Visible = false;
                MainBtnPosition();
            }
        }
        private void exchangeForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = exchangeForm.SelectedIndex;
            Object selectedItem = exchangeForm.SelectedItem;
            if (selectedItem != null)
            {
                if (selectedItem.ToString().Contains("Home Menu"))
                {
                    homePanel.Visible = false;
                }
                else if (selectedItem.ToString().Contains("Customer Control"))
                {
                    custCtrlBtn_Click(sender, e);
                }
                else if (selectedItem.ToString().Contains("Product Control"))
                {
                    prodCtrlBtn_Click(sender, e);
                }
            }
        }
        private Lock lockC;
        private void lockBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Enabled = false;
            lockC = new Lock(currentUserPassword, currentUsername);
            lockC.LogoutRequested += Lock_LogoutRequested;
            this.ControlRemoved += (s, args) => mainPanel.Enabled = true;
            shareFile.SetForm(lockC, this);
            lockC.BringToFront();
        }
        private void Lock_LogoutRequested(object sender, EventArgs e)
        {
            SignOut();
        }
        #endregion

        #region Tools Management
        /// <summary>
        /// open/close tools panel
        /// </summary>
        private int containerWidth;
        private void closetoolsPanel_Click(object sender, EventArgs e)
        {
            containerWidth = homePanelContainer.Width;
            toolsPanel.Visible = false;
            smalltoolsPanel.Visible = true;
            homePanelContainer.Width = containerWidth + 113;
        }

        private void opentoolsPanel_Click(object sender, EventArgs e)
        {
            containerWidth = homePanelContainer.Width;
            toolsPanel.Visible = true;
            smalltoolsPanel.Visible = false;
            homePanelContainer.Width = containerWidth - 113;
        }
        /// <summary>
        /// Calendar control
        /// </summary>
        private void calendarBtn_Click(object sender, EventArgs e)
        {
            if (!calendarPanel.Visible)
            {
                calendarPanel.Visible = true;
                ToolsControlsPosition();
            }
            else
            {
                calendarPanel.Visible = false;
                ToolsControlsPosition();
            }
        }
        private smallCalendar sc;
        private void calendarPanel_Paint(object sender, PaintEventArgs e)
        {
            sc = new smallCalendar();
            calendarPanel.Controls.Add(sc);
        }
        private void calendarP_Click(object sender, EventArgs e)
        {
            openCalendar_Click(sender, e);
        }
        /// <summary>
        /// Calculator control
        /// </summary>
        private Calculator calcu;
        private void calculatorPanel_Paint(object sender, PaintEventArgs e)
        {
            calcu = new Calculator();
            calculatorPanel.Controls.Add(calcu);
        }
        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            if (!calculatorPanel.Visible)
            {
                calculatorPanel.Visible = true;
                ToolsControlsPosition();
            }
            else
            {
                calculatorPanel.Visible = false;
                ToolsControlsPosition();
            }
        }
        private void calculatorP_Click(object sender, EventArgs e)
        {
            if (!capanel1.Visible)
            {
                capanel1.Visible = true;
            }
            else
            {
                capanel1.Visible = false;
            }
        }
        private void capanel2_Paint(object sender, PaintEventArgs e)
        {
            calcu = new Calculator();
            capanel2.Controls.Add(calcu);
        }

        private void caCloseL_Click(object sender, EventArgs e)
        {
            calculatorP_Click(sender, e);
        }
        /// <summary>
        /// Currency Exchange control
        /// </summary>
        private CurrencyExchange ce;
        private void exchangePanel_Paint(object sender, PaintEventArgs e)
        {
            ce = new CurrencyExchange();
            shareFile.SetForm(ce, exchangePanel);
        }
        private void exchangeBtn_Click(object sender, EventArgs e)
        {
            if (!exchangePanel.Visible)
            {
                exchangePanel.Visible = true;
                ToolsControlsPosition();
            }
            else
            {
                exchangePanel.Visible = false;
                ToolsControlsPosition();
            }
        }
        /// <summary>
        /// Email control
        /// </summary>    
        private void emailP_Click(object sender, EventArgs e)
        {
            emailBtn_Click(sender, e);
        }
        #endregion
    }
}
