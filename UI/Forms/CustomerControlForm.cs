using Model;
using UI.Controls;
using UI.Forms;
using UI.Services;
using static Model.DTO;

namespace UI
{
    public partial class CustomerControlForm : Form
    {
        #region Generic class
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        public CustomerControlForm()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        private void TextReadOnlyControlOn()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                nameBox, phoneBox, emailBox, address1Box,
                address2Box, drawerBox, bankBox, bsbBox, bankaccBox,
                branchBox, notesBox
            }, true);
        }
        private void TextReadOnlyAccountOn()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                acctBox, passwordBox, balanceBox, pointsBox
            }, true);
        }
        private void TextReadOnlyControlOff()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                nameBox, phoneBox, emailBox, address1Box,
                address2Box, drawerBox, bankBox, bsbBox, bankaccBox,
                branchBox, notesBox
            }, false);
        }
        private void TextReadOnlyAccountOff()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                acctBox, passwordBox, balanceBox, pointsBox
            }, false);
        }
        private void TextBoxClear()
        {
            shareFile.ClearTextBoxes(new Control[]
            {
                searchBox, idBox, nameBox, phoneBox, emailBox, address1Box,
                address2Box, drawerBox, bankBox, bsbBox, bankaccBox,
                branchBox, acctBox, passwordBox, balanceBox, pointsBox, notesBox
            });
        }
        //private MainForm main;
        private MainProgram main;
        private string GetUser()
        {
            //MainForm form = new MainForm();
            main = new MainProgram();
            return main.CurrentUser();
        }
        #endregion

        #region Process
        private bool isopen;
        private async void ShowSearchForm(string searchTerm)
        {
            if (apiService == null)
            {
                MessageBox.Show("ApiService is not initialized.");
                return;
            }
            SearchForm searchForm = new SearchForm("Customer", apiService);
            searchForm.OnItemSelect += (rowData) =>
            {
                var bindings = new Dictionary<string, TextBox>
                {
                    {"CustomerID", idBox},
                    {"ContactName", nameBox},
                    {"Phone", phoneBox},
                    {"Email", emailBox},
                    {"Address1", address1Box},
                    {"Address2", address2Box },
                    {"Notes", notesBox}
                };
                shareFile.BindRowDataToTextBoxes(bindings, searchForm.GetColumnNames(), rowData);
                nameBox.Focus();
            };
            searchForm.OnIsAddNew += (isadd) =>
            {
                if (isadd)
                {
                    isopen = true;
                }
            };
            searchForm.FormClosed += (sender, e) =>
            {
                homePanel.Enabled = true;
                if (isopen)
                { 
                    ClickAddBtn();
                }
            };
            try
            {
                searchForm.TopLevel = false;
                shareFile.SetForm(searchForm, this);
                searchForm.BringToFront();
                searchForm.LoadSearchResults(searchTerm);
                homePanel.Enabled = false;
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
        }
        private void ClickAddBtn()
        {
            addBtn.PerformClick();
        }
        private void CustomerControlForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            searchBox.Focus();
            TextReadOnlyControlOn();
            TextReadOnlyAccountOn();
        }
        private async void ShowTransForm(string custID)
        {
            TransactionForm transForm = new TransactionForm("Customer", custID);
            transForm.TopLevel = false;
            transForm.Location = new Point(
                (homePanel.Width - transForm.Width) / 2,
                (homePanel.Height - transForm.Height) / 2
                );
            homePanel.Controls.Add(transForm);
            transForm.Show();
            transForm.BringToFront();
            transForm.LoadSearchResults(custID);
        }
        private async Task CreateNewAccount(string CustomerID)
        {
            int newId = await shareFile.GenerateId(apiService, "Accounts", "AccountNumber");
            Account newAccount = new Account
            {
                AccountNumber = newId.ToString("D10"),
                AccountPassword = "123456",
                CustomerID = CustomerID,
                AccountBalance = 0
            };
            await apiService.InsertAccountAsync(newAccount);
        }
        private async void ShowAccountInfo()
        {
            string id = idBox.Text.Trim();
            List<Account> result = await apiService.SearchAccountAsync(id);
            if (result != null && result.Count > 0)
            {
                acctBox.Text = result[0].AccountNumber;
                passwordBox.Text = result[0].AccountPassword;
                balanceBox.Text = Convert.ToString(result[0].AccountBalance);
            }
            else
            {
                acctBox.Text = "No account found";
                passwordBox.Text = "N/A";
                balanceBox.Text = "N/A";
                pointsBox.Text = "N/A";
            }
        }
        #endregion

        #region Buttons Action
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.ReadOnly)
            {
                TextReadOnlyControlOff();
                trackBar.Value = 1;
            }
            else
            {
                TextReadOnlyControlOn();
                trackBar.Value = 0;
            }
        }
        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();
            List<Customer> results = await apiService.SearchCustomersAsync(searchTerm);
            if (results.Count == 0)
            {
                if (shareFile.ConfirmAction("No customers found. Do you want to add a new customer?", "Add Customer"))
                {
                    addBtn_Click(sender, e);
                }
            }
            else
            {
                ShowSearchForm(searchTerm);
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            CreateForm cre = new CreateForm("Customer", apiService);
            cre.TopLevel = false;
            cre.OnDataSubmitted += (code, name) =>
            {
                idBox.Text = code;
                nameBox.Text = name;
            };
            shareFile.SetForm(cre, homePanel);
            cre.BringToFront();
            TextReadOnlyControlOff();
        }
        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            string custID = idBox.Text.Trim();
            string custname = nameBox.Text.Trim();
            double balance = await apiService.GetBalanceAsync(custID);
            await apiService.InsertActionAsync(shareFile.RecodeAction($"{GetUser()} delete customer for CustomerID: {custID} : {custname}"));
            if (balance != 0)
            {
                shareFile.ShowMessage("Customer's account balance is not 0, can not delete");
                return;
            }
            if (shareFile.ConfirmAction($"Confirm delete customer with ID: {custID}?", "Confirm Delete"))
            {
                await apiService.DeleteCustomerAsync(custID);
                shareFile.ShowMessage($"Deleted {custID}");
            }
            else
            {
                shareFile.ShowMessage("Delete cancelled.");
            }
        }
        private void transBtn_Click(object sender, EventArgs e)
        {
            IsValid isValid = new IsValid();
            string custID = idBox.Text.Trim();
            if (!isValid.NullVal(custID))
            {
                return;
            }
            ShowTransForm(custID);
        }
        private void graphBtn_Click(object sender, EventArgs e)
        {

        }
        private void searBtn_Click(object sender, EventArgs e)
        {
            searchBtn_Click(sender, e);
        }
        private void undoBtn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            shareFile.HandleTrackBarScroll(trackBar, TextReadOnlyControlOn, TextReadOnlyControlOff);
        }
        private void accBtn_Click(object sender, EventArgs e)
        {
            TextReadOnlyAccountOff();
            acctUBtn.Visible = true;
        }
        private void idBox_TextChanged(object sender, EventArgs e)
        {
            ShowAccountInfo();
        }
        private async void acctUBtn_Click(object sender, EventArgs e)
        {
            string id = acctBox.Text.Trim();
            string custid = idBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string balance = balanceBox.Text.Trim();
            await apiService.InsertActionAsync(shareFile.RecodeAction($"{GetUser()} update customer account for CustomerID: {custid}, password : {password}, balance : {balance}"));
            Account account = new Account
            {
                AccountNumber = id,
                AccountPassword = password,
                CustomerID = custid,
                AccountBalance = Convert.ToDecimal(balance)
            };
            bool success = await apiService.UpdateAccount(account);
            if (success)
            {
                TextReadOnlyAccountOn();
                ShowAccountInfo();
                acctUBtn.Visible = false;
            }
        }
        private async void saveBtn_Click(object sender, EventArgs e)
        {
            string CustomerID = idBox.Text.Trim();
            string ContactName = nameBox.Text.Trim();
            string Phone = phoneBox.Text.Trim();
            string Email = emailBox.Text.Trim();
            string Address1 = address1Box.Text.Trim();
            string Address2 = address2Box.Text.Trim();
            if (!shareFile.ValidateValue(CustomerID, "CustomerID"))
            {
                return;
            }
            bool pkExists = await apiService.CheckExistsAsync("Customers", "CustomerID", CustomerID);
            Customer newCustomer = new Customer
            {
                CustomerID = CustomerID,
                ContactName = ContactName,
                Phone = Phone,
                Email = Email,
                Address1 = Address1,
                Address2 = Address2,
                Notes = ""
            };
            bool success = await shareFile.SaveOrUpdateAsync(newCustomer, pkExists,
                async (customer) => await apiService.UpdateCustomerAsync(customer),
                async (customer) => await apiService.InsertCustomerAsync(customer)
            );
            if (success && !pkExists)
            {
                await CreateNewAccount(CustomerID);
                await apiService.InsertActionAsync(shareFile.RecodeAction($"{GetUser()} save customer for CustomerID: {CustomerID}"));
            }
            TextReadOnlyControlOn();
            TextBoxClear();
        }
        private async void notesBox_TextChanged(object sender, EventArgs e)
        {
            var notes = new NotesForCust
            {
                CustomerID = idBox.Text.Trim(),
                Notes = notesBox.Text
            };
            await apiService.UpdateNotesAsync(notes);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            notesPanel.Visible = false;
        }

        private void notesBtn_Click(object sender, EventArgs e)
        {
            if (notesPanel.Visible)
            {
                notesPanel.Visible = false;
            }
            else
            {
                notesPanel.Visible = true;
            }
        }
        #endregion

        #region User Friendly
        private bool isSearchBoxFocused = false;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    editBtn.PerformClick();
                    return true;
                case Keys.F3:
                    if (!isSearchBoxFocused)
                    {
                        searchBox.Focus();
                        isSearchBoxFocused = true;
                    }
                    else
                    {
                        searchBtn.PerformClick();
                        isSearchBoxFocused = false;
                    }
                    return true;
                case Keys.F4:
                    addBtn.PerformClick();
                    return true;
                case Keys.F5:
                    deleteBtn.PerformClick();
                    return true;
                case Keys.F6:
                    transBtn.PerformClick();
                    return true;
                case Keys.F7:
                    graphBtn.PerformClick();
                    return true;
                case Keys.F8:
                    accBtn.PerformClick();
                    return true;
                case Keys.F9:
                    notesBtn.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, null, nameBox);
            if (e.KeyCode == Keys.Enter)
            {
                searBtn.PerformClick();
            }
        }
        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, pointsBox, address1Box);
        }
        private void address1Box_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, nameBox, address2Box);
        }
        private void address2Box_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, address1Box, phoneBox);
        }
        private void phoneBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, address2Box, emailBox);
        }
        private void emailBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, phoneBox, drawerBox);
        }
        private void drawerBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, emailBox, bankBox);
        }
        private void bankBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, drawerBox, bsbBox);
        }
        private void bsbBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, bankBox, bankaccBox);
        }
        private void bankaccBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, bsbBox, branchBox);
        }
        private void branchBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, bankaccBox, acctBox);
        }
        private void acctBox_KEyDow(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, branchBox, passwordBox);
        }
        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, acctBox, balanceBox);
        }
        private void balanceBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, passwordBox, pointsBox);
        }
        private void pointsBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, balanceBox, nameBox);
        }
        private void homePanel_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
        #endregion        
    }
}
