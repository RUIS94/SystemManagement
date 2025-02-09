using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using UI.Forms;
using UI.Services;

namespace UI
{
    public partial class UserControlForm : Form
    {
        #region Generic class
        private readonly ApiService apiService;
        ShareFile sf = new ShareFile();
        public UserControlForm()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        private void TextReadOnlyControlOn()
        {
            sf.SetTextBoxReadOnly(new Control[] 
            {
                idBox, nameBox, phoneBox, emailBox, 
                address1Box, address2Box, passwordBox
            },true);
        }
        private void TextReadOnlyControlOff()
        {
            sf.SetTextBoxReadOnly(new Control[]
            {
                idBox, nameBox, phoneBox, emailBox, 
                address1Box, address2Box, passwordBox
            }, false);
        }
        private void TextBoxClear()
        {
            sf.ClearTextBoxes(new Control[]
            {
                idBox, nameBox, phoneBox, emailBox,
                address1Box, address2Box, passwordBox, roleBox
            });
            RadioBtnClear();
        }
        private void RadioBtnClear()
        {
            manager.Checked = false;
            salesman.Checked = false;
            accountant.Checked = false;
            technician.Checked = false;
        }
        #endregion

        #region Process
        private void ShowSearchForm(string searchTerm)
        {
            SearchForm searchForm = new SearchForm("User", apiService);
            searchForm.FormClosed += (s, args) => homePanel.Enabled = true;
            searchForm.OnItemSelect += (rowData) =>
            {
                var bindings = new Dictionary<string, TextBox>
                {
                    {"UserID", idBox},
                    {"UserName", nameBox},
                    {"UserPassword", passwordBox},
                    {"UserPhone", phoneBox},
                    {"UserRole", roleBox}
                };
                sf.BindRowDataToTextBoxes(bindings, searchForm.GetColumnNames(), rowData);
                nameBox.Focus();
                string role = roleBox.Text;
                if (role == "manager")
                {
                    manager.Checked = true;
                }
                if (role == "salesman")
                {
                    salesman.Checked = true;
                }
                if (role == "accountant")
                {
                    accountant.Checked = true;
                }
                if (role == "technician")
                {
                    technician.Checked = true;
                }
            };
            try
            {
                searchForm.TopLevel = false;
                sf.SetForm(searchForm, this);
                searchForm.BringToFront();
                searchForm.LoadSearchResults(searchTerm);
                homePanel.Enabled = false;
            }
            catch (Exception ex)
            {
                sf.HandleException(ex);
            }
        }
        private string RoleSelected()
        {
            string role = null;
            if (manager.Checked) { role = "manager"; }
            if (salesman.Checked) { role = "salesman"; }
            if (accountant.Checked) { role = "accountant"; }
            if (technician.Checked) { role = "technician"; }
            return role;
        }
        #endregion
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (idBox.ReadOnly)
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
            List<User> results = await apiService.SearchUsersAsync(searchTerm);
            ShowSearchForm(searchTerm);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            homePanel.Enabled = false;
            CreateForm cf = new CreateForm("User", apiService);
            cf.TopLevel = false;
            sf.SetForm(cf, this);
            cf.BringToFront();
            cf.FormClosed += (s, args) => homePanel.Enabled = true;
            cf.OnDataSubmitted += (code, name) =>
            {
                idBox.Text = code;
                nameBox.Text = name;
            };
            TextReadOnlyControlOff();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();
            string username = nameBox.Text.Trim();
            await apiService.DeleteUserAsync(id);
            sf.ShowMessage($"Delete User {username}");
            TextBoxClear();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {

        }

        private void graphBtn_Click(object sender, EventArgs e)
        {

        }

        private void searBtn_Click(object sender, EventArgs e)
        {
            searchBtn.PerformClick();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();
            string name = nameBox.Text.Trim();
            string ph = phoneBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            if (!sf.ValidateValue(id, "UserID"))
            {
                return;
            }
            bool pkExists = await apiService.CheckExistsAsync("Users", "UserID", id);
            User user = new User
            {
                UserID = id,
                UserName = name,
                UserPassword = password,
                UserPhone = ph,
                UserRole = RoleSelected()
            };
            bool success = await sf.SaveOrUpdateAsync(user, pkExists,
                async (user) => await apiService.UpdateUserAsync(user),
                async (user) => await apiService.InsertUserAsync(user)
            );
            TextReadOnlyControlOn();
            TextBoxClear();
        }

        private void UserControlForm_Load(object sender, EventArgs e)
        {
            sf.BindTextBoxEvent(this);
            searchBox.Focus();
            TextReadOnlyControlOn();
        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            sf.HandleTrackBarScroll(trackBar, TextReadOnlyControlOn, TextReadOnlyControlOff);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2) 
            {
                editBtn.PerformClick();
            }
            if (keyData == Keys.F3)
            {
                searchBtn.PerformClick();
            }
            if (keyData == Keys.F4)
            {
                addBtn.PerformClick();
            }
            if (keyData == Keys.F5)
            {
                deleteBtn.PerformClick();
            }
            if (keyData == Keys.F6)
            {
                transBtn.PerformClick();
            }
            if (keyData == Keys.F7)
            {
                graphBtn.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
