using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Controls;
using UI.Services;

namespace UI.Forms
{
    public partial class MainForm : Form
    {
        #region Methods
        ShareFile shareFile = new ShareFile();
        private readonly ApiService apiService;
        private bool isUserLoggedIn = false;
        private string currentUserRole = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            DateTime now = DateTime.Now;
            timeLabel.Text = now.ToString("dd/MM/yyyy");
            ToolsControlsPosition();
            exchangeForm.Items.Add("Home Menu" + homePanel);
        }
        private void LockMainButtonPanel(bool lockState)
        {
            foreach (Control control in mainBtnPanel.Controls)
            {
                control.Enabled = !lockState;
            }
        }
        private void SignOut()
        {
            isUserLoggedIn = false;
            signBtn.Text = "Sign in";
            currentUserRole = string.Empty;
            LockMainButtonPanel(true);
            //MessageBox.Show("You have been signed out.");
        }
        public void SetUserLoggedIn(string username, string role)
        {
            isUserLoggedIn = true;
            currentUserRole = role;
            signBtn.Text = "Sign out";
            shareFile.ShowMessage($"Welcome {role} : {username}");
            LockMainButtonPanel(false);
        }
        private void LockPanel()
        {
            fucPanel.Enabled = false;
            mainBtnPanel.Enabled = false;
            homePanel.Enabled = false;
        }
        private void UnlockPanel()
        {
            fucPanel.Enabled = true;
            mainBtnPanel.Enabled = true;
            homePanel.Enabled = true;
        }
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
        private void setBtn_Click(object sender, EventArgs e)
        {
            SettingForm setform = new SettingForm();
            setform.TopLevel = true;
            setform.Show();
        }
        private CustomerControlForm custform;
        private void custCtrlBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref custform, "Customer Control");
            //homePanel.Visible = true;
            //if (custform == null || custform.IsDisposed)
            //{
            //    custform = new CustomerControlForm();
            //    custform.TopLevel = false;
            //    custform.FormClosed += (s, args) => RemoveExchangeItem("Customer Control");
            //    shareFile.SetForm(custform, homePanel);
            //    exchangeForm.Items.Add("Customer Control" + custform);
            //}
            //else
            //{
            //    custform.BringToFront();
            //}
        }
        private ProductControlForm prodform;
        private void prodCtrlBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref prodform, "Product Control");
            //homePanel.Visible = true;
            //if (prodform == null || prodform.IsDisposed)
            //{
            //    prodform = new ProductControlForm();
            //    prodform.TopLevel = false;
            //    prodform.FormClosed += (s, args) => RemoveExchangeItem("Product Control");
            //    shareFile.SetForm(prodform, homePanel);
            //    exchangeForm.Items.Add("Product Control" + prodform);
            //}
            //else
            //{
            //    prodform.BringToFront();
            //}
        }
        private SupplierControlForm suppform;
        private void suppCtrlBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref suppform, "Supplier Control");
            //homePanel.Visible = true;
            //if (suppform == null || suppform.IsDisposed)
            //{
            //    suppform = new SupplierControlForm();
            //    suppform.TopLevel = false;
            //    suppform.FormClosed += (s, args) => RemoveExchangeItem("Supplier Control");
            //    shareFile.SetForm(suppform, homePanel);
            //    exchangeForm.Items.Add("Supplier Control" + suppform);
            //}
            //else
            //{
            //    suppform.BringToFront();
            //}
        }
        private UserControlForm userform;
        private void userCtrlBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref userform, "User Control");
            //homePanel.Visible = true;
            //if (userform == null || userform.IsDisposed)
            //{
            //    userform = new UserControlForm();
            //    userform.TopLevel = false;
            //    userform.FormClosed += (s, args) => RemoveExchangeItem("User Control");
            //    shareFile.SetForm(userform, homePanel);
            //    exchangeForm.Items.Add("User Control" + userform);
            //}
            //else
            //{
            //    userform.BringToFront();
            //}

        }
        private CustomerOrder custord;
        private void cartCtrlBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref custord, "Customer Order");
            //homePanel.Visible = true;
            //if (custord == null || custord.IsDisposed)
            //{
            //    custord = new CustomerOrder();
            //    custord.TopLevel = false;
            //    custord.FormClosed += (s, args) => RemoveExchangeItem("Customer Order");
            //    shareFile.SetForm(custord, homePanel);
            //    exchangeForm.Items.Add("Customer Order" + custord);
            //}
            //else
            //{
            //    custord.BringToFront();
            //}
        }
        private SupplierOrder suppord;
        private void suppOrderBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref suppord, "Supplier Order");
            //homePanel.Visible = true;
            //if (suppord == null || suppord.IsDisposed)
            //{
            //    suppord = new SupplierOrder();
            //    suppord.TopLevel = false;
            //    suppord.FormClosed += (s, args) => RemoveExchangeItem("Supplier Order");
            //    shareFile.SetForm(suppord, homePanel);
            //    exchangeForm.Items.Add("Supplier Order" + suppord);
            //}
            //else
            //{
            //    suppord.BringToFront();
            //}
        }
        private GoodsReceived goodsin;
        private void goodsInBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref goodsin, "Goods Received");
            //homePanel.Visible = true;
            //if (goodsin == null || goodsin.IsDisposed)
            //{
            //    goodsin = new GoodsReceived();
            //    goodsin.TopLevel = false;
            //    goodsin.FormClosed += (s, args) => RemoveExchangeItem("Goods Received");
            //    shareFile.SetForm(goodsin, homePanel);
            //    exchangeForm.Items.Add("Goods Received" + goodsin);
            //}
            //else
            //{
            //    goodsin.BringToFront();
            //}
        }
        private void signBtn_Click(object sender, EventArgs e)
        {
            if (!isUserLoggedIn)
            {
                SignForm signform = new SignForm(this);
                signform.TopLevel = false;
                shareFile.SetForm(signform, homePanelContainer);
            }
            else
            {
                SignOut();
            }
        }
        private TaskMenu tasks;
        private void taskMenuBtn_Click(object sender, EventArgs e)
        {
            ShowForm(ref tasks, "Task Menu");
            //homePanel.Visible = true;
            //if (tasks == null || tasks.IsDisposed)
            //{
            //    tasks = new TaskMenu();
            //    tasks.TopLevel = false;
            //    tasks.FormClosed += (s, args) => RemoveExchangeItem("Task Menu");
            //    shareFile.SetForm(tasks, homePanel);
            //    exchangeForm.Items.Add("Task Menu" + tasks);
            //}
            //else
            //{
            //    tasks.BringToFront();
            //}
        }
        private HelpForm help;
        private void helpLabel_Click(object sender, EventArgs e)
        {
            ShowForm(ref help, "Help");
            //homePanel.Visible = true;
            //if (help == null || help.IsDisposed)
            //{
            //    help = new HelpForm();
            //    help.TopLevel = false;
            //    help.FormClosed += (s, args) => homePanel.Visible = false;
            //    help.FormClosed += (s, args) => RemoveExchangeItem("Help");
            //    shareFile.SetForm(help, homePanel);
            //    exchangeForm.Items.Add("Help" + help);
            //}
            //else
            //{
            //    help.BringToFront();
            //}
        }
        private CalendarForm calendar;
        private void openCalendar_Click(object sender, EventArgs e)
        {
            ShowForm(ref calendar, "Calendar");
            //homePanel.Visible = true;
            //if (calendar == null || calendar.IsDisposed)
            //{
            //    calendar = new CalendarForm();
            //    calendar.TopLevel = false;
            //    calendar.FormClosed += (s, args) => RemoveExchangeItem("Calendar");
            //    shareFile.SetForm(calendar, homePanel);
            //    exchangeForm.Items.Add("Calendar" + calendar);
            //}
            //else
            //{
            //    calendar.BringToFront();
            //}
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
            taskMenuBtn.PerformClick();
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
        private void lockBtn_Click(object sender, EventArgs e)
        {
            lockPanel.Visible = true;
            lockPanel.Location = new Point(
                (mainPanel.Width - lockPanel.Width) / 2,
                (mainPanel.Height - lockPanel.Height) / 2
            );
            LockPanel();
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            lockPanel.Visible = false;
            UnlockPanel();
        }

        private void outLabel_Click(object sender, EventArgs e)
        {
            lockPanel.Visible = false;
            UnlockPanel();
        }
        //private bool isExchangePanelVisible;
        //private bool isCalendarPanelVisible;
        //private bool isCalculatorPanelVisible;
        //private void calendarBtn_Click(object sender, EventArgs e)
        //{
        //    isCalendarPanelVisible = calendarPanel.Visible;
        //    isCalculatorPanelVisible = calculatorPanel.Visible;
        //    //isExchangePanelVisible = exchangePanel.Visible;
        //    if (isCalculatorPanelVisible)
        //    {
        //        if (isCalendarPanelVisible)
        //        {
        //            calendarPanel.Visible = false;
        //            calculatorBtn.Top = calendarBtn.Bottom;
        //            calculatorPanel.Top = calculatorBtn.Bottom;
        //        }
        //        else
        //        {
        //            calendarPanel.Visible = true;
        //            calculatorBtn.Top = calendarPanel.Bottom;
        //            calculatorPanel.Top = calculatorBtn.Bottom;
        //        }
        //    }
        //    else
        //    {
        //        if (isCalendarPanelVisible)
        //        {
        //            calendarPanel.Visible = false;
        //            calculatorBtn.Top = calendarBtn.Bottom;
        //        }
        //        else
        //        {
        //            calendarPanel.Visible = true;
        //            calculatorBtn.Top = calendarPanel.Bottom;
        //        }
        //    }
        //}
        //private void calculatorBtn_Click(object sender, EventArgs e)
        //{
        //    isCalendarPanelVisible = calendarPanel.Visible;
        //    isCalculatorPanelVisible = calculatorPanel.Visible;
        //    if (isCalendarPanelVisible)
        //    {
        //        if (isCalculatorPanelVisible)
        //        {
        //            calculatorPanel.Visible = false;
        //            calculatorBtn.Top = calendarPanel.Bottom;
        //        }
        //        else
        //        {
        //            calculatorPanel.Visible = true;
        //            calculatorBtn.Top = calendarPanel.Bottom;
        //            calculatorPanel.Top = calculatorBtn.Bottom;
        //        }
        //    }
        //    else
        //    {
        //        if (isCalculatorPanelVisible)
        //        {
        //            calculatorPanel.Visible = false;
        //            calculatorBtn.Top = calendarBtn.Bottom;
        //        }
        //        else
        //        {
        //            calculatorPanel.Visible = true;
        //            calculatorBtn.Top = calendarBtn.Bottom;
        //            calculatorPanel.Top = calculatorBtn.Bottom;
        //        }
        //    }
        //}
        //private void exchangeBtn_Click(object sender, EventArgs e)
        //{
        //isCalendarPanelVisible = calendarPanel.Visible;
        //isCalculatorPanelVisible = calculatorPanel.Visible;
        //isExchangePanelVisible = exchangePanel.Visible;
        //if (isCalculatorPanelVisible)
        //{
        //    if (isExchangePanelVisible)
        //    {
        //        exchangePanel.Visible = false;
        //        exchangeBtn.Top = calculatorBtn.Bottom;
        //    }
        //    else
        //    {
        //        exchangePanel.Visible = true;
        //        exchangeBtn.Top = calculatorBtn.Bottom;
        //        exchangePanel.Top = exchangeBtn.Bottom;
        //    }
        //}
        //else if (isCalendarPanelVisible)
        //{
        //    if (isExchangePanelVisible)
        //    {
        //        exchangePanel.Visible = false;
        //        exchangeBtn.Top = calendarBtn.Bottom;
        //    }
        //    else
        //    {
        //        exchangePanel.Visible = true;
        //        exchangeBtn.Top = calendarBtn.Bottom;
        //        exchangePanel.Top = exchangeBtn.Bottom;
        //    }
        //}
        //else
        //{
        //    if (isExchangePanelVisible)
        //    {
        //        exchangePanel.Visible = false;
        //        exchangeBtn.Top = calendarBtn.Bottom;
        //    }
        //    else
        //    {
        //        exchangePanel.Visible = true;
        //        exchangeBtn.Top = calendarBtn.Bottom;
        //        exchangePanel.Top = exchangeBtn.Bottom;
        //    }
        //}
        //}
        #endregion

        #region User Friendly

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
