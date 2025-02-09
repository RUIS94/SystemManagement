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
    public partial class SupplierControlForm : Form
    {
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        public SupplierControlForm()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }

        private void TextReadOnlyControlOn()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                searchBox, idBox, nameBox, phoneBox, emailBox, address1Box,
                address2Box
            }, true);
        }
        private void TextReadOnlyControlOff()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                searchBox, idBox, nameBox, phoneBox, emailBox, address1Box,
                address2Box
            }, false);
        }
        private void TextBoxClear()
        {
            shareFile.ClearTextBoxes(new Control[]
            {
                searchBox, idBox, nameBox, phoneBox, emailBox, address1Box,
                address2Box
            });
        }
        private async void ShowSearchForm(string searchTerm)
        {
            SearchForm searchForm = new SearchForm("Supplier", apiService);
            searchForm.OnItemSelect += (rowData) =>
            {
                var bindings = new Dictionary<string, TextBox>
                {
                    {"SupplierCode", idBox},
                    {"SupplierName", nameBox},
                    {"SupplierPhone", phoneBox},
                    {"SupplierEmail", emailBox},
                    {"Address1", address1Box},
                    {"Address2", address2Box }
                };

                shareFile.BindRowDataToTextBoxes(bindings, searchForm.GetColumnNames(), rowData);
            };
            try
            {
                searchForm.TopLevel = false;
                shareFile.SetForm(searchForm, homePanel);
                searchForm.BringToFront();
                searchForm.LoadSearchResults(searchTerm);
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            TextReadOnlyControlOff();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();
            ShowSearchForm(searchTerm);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CreateForm cre = new CreateForm("Supplier", apiService);
            cre.TopLevel = false;
            cre.OnDataSubmitted += (code, name) =>
            {
                idBox.Text = code;
                nameBox.Text = name;
            };
            shareFile.SetForm(cre, homePanel);
            cre.BringToFront();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            //string id = idBox.Text.Trim();
            //if (shareFile.ConfirmAction($"Confirm delete supplier with ID: {id}?", "Confirm Delete"))
            //{
            //    await apiService.DeleteSupplierAsync(id); //need to write in apiService
            //    shareFile.ShowMessage($"Deleted {id}");
            //}
            //else
            //{
            //    shareFile.ShowMessage("Delete cancelled.");
            //}
        }
        private async void ShowTransForm(string id)
        {
            TransactionForm transForm = new TransactionForm("Supplier", id);
            transForm.TopLevel = false;
            transForm.Location = new Point(
                (homePanel.Width - transForm.Width) / 2,
                (homePanel.Height - transForm.Height) / 2
                );
            homePanel.Controls.Add(transForm);
            transForm.Show();
            transForm.BringToFront();
            transForm.LoadSearchResults(id);
        }
        private void transBtn_Click(object sender, EventArgs e)
        {
            IsValid isValid = new IsValid();
            string id = idBox.Text.Trim();
            if (!isValid.NullVal(id))
            {
                return;
            }
            ShowTransForm(id);
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {

        }

        private void searBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();
            ShowSearchForm(searchTerm);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();
            string name = nameBox.Text.Trim();
            string phone = phoneBox.Text.Trim();
            string email = emailBox.Text.Trim();
            string address1 = address1Box.Text.Trim();
            string address2 = address2Box.Text.Trim();
            if (!shareFile.ValidateValue(id, "SupplierCode"))
            {
                return;
            }
            bool pkExists = await apiService.CheckExistsAsync("Suppliers", "SupplierCode", id);
            Supplier newSupplier = new Supplier
            {
                SupplierCode = id,
                SupplierName = name,
                SupplierPhone = phone,
                SupplierEmail = email,
                SupplierAddress1 = address1,
                SupplierAddress2 = address2
            };
            bool success = await shareFile.SaveOrUpdateAsync(newSupplier, pkExists,
                async (supplier) => await apiService.UpdateSupplierAsync(supplier),
                async (supplier) => await apiService.InsertSupplierAsync(supplier)
            );
            if (success)
            {
                TextReadOnlyControlOn();
                TextBoxClear();
            }
        }

        private void SupplierControlForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            searchBox.Focus();
            TextReadOnlyControlOn();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            shareFile.HandleTrackBarScroll(trackBar, TextReadOnlyControlOn, TextReadOnlyControlOff);
        }

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
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #endregion

        private void trackBar_Scroll_1(object sender, EventArgs e)
        {

        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}