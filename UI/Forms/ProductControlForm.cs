
using Model;
using UI.Forms;
using UI.Services;

namespace UI
{
    public partial class ProductControlForm : Form
    {
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        public ProductControlForm()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        private void TextReadOnlyControlOn()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                idBox, nameBox, barcodeBox, groupBox, priceBox,
                currentCostBox, latestOrderCostBox, currentInventoryBox, latestOrderIDBox,
                latestUpdateTimeBox, latestUpdateQuantityBox
            }, true);
        }
        private void TextReadOnlyControlOff()
        {
            shareFile.SetTextBoxReadOnly(new Control[]
            {
                idBox, nameBox, barcodeBox, groupBox, priceBox,
                currentCostBox, latestOrderCostBox, currentInventoryBox, latestOrderIDBox,
                latestUpdateTimeBox, latestUpdateQuantityBox
            }, false);
        }
        private void TextBoxClear()
        {
            shareFile.ClearTextBoxes(new Control[]
            {
                idBox, nameBox, barcodeBox, groupBox, priceBox,
                currentCostBox, latestOrderCostBox, currentInventoryBox, latestOrderIDBox,
                latestUpdateTimeBox, latestUpdateQuantityBox
            });
        }
        private async void ShowSearchForm(string searchTerm)
        {
            SearchForm searchForm = new SearchForm("Product", apiService);
            searchForm.OnItemSelect += (rowData) =>
            {
                var bindings = new Dictionary<string, TextBox>
                {
                    {"ProductCode", idBox},
                    {"Name", nameBox},
                    {"Barcode", barcodeBox},
                    {"Cost", currentCostBox},
                    {"Price", priceBox},
                    {"Inventory", currentInventoryBox}
                };

                shareFile.BindRowDataToTextBoxes(bindings, searchForm.GetColumnNames(), rowData);
                string rp = shareFile.RP();
                shareFile.LoadImage($"{rp}prodImage", idBox.Text.Trim(), pictureBox);
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

        private void ProductControlForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            TextReadOnlyControlOn();
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
            CreateForm cre = new CreateForm("Product", apiService);
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
            string prodID = idBox.Text.Trim();
            if (shareFile.ConfirmAction($"Confirm delete Product with ID: {prodID}?", "Confirm Delete"))
            {
                await apiService.DeleteProductAsync(prodID);
                shareFile.ShowMessage($"Deleted {prodID}");
            }
            else
            {
                shareFile.ShowMessage("Delete cancelled.");
            }
        }

        private void transBtn_Click(object sender, EventArgs e)
        {

        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();
            GraphForm graphForm = new GraphForm("Product", id, apiService);
            graphForm.TopLevel = false;
            shareFile.SetForm(graphForm, homePanel);
            graphForm.BringToFront();
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
            string barcode = barcodeBox.Text.Trim();
            decimal cost = Convert.ToDecimal(currentCostBox.Text.Trim());
            decimal price = Convert.ToDecimal(priceBox.Text.Trim());
            int inventory = Convert.ToInt32(currentInventoryBox.Text.Trim());
            if (!shareFile.ValidateValue(id, "ProductCode"))
            {
                return;
            }
            bool pkExists = await apiService.CheckExistsAsync("Products", "ProductCode", id);
            Product newProduct = new Product
            {
                ProductCode = id,
                Name = name,
                Barcode = barcode,
                Cost = cost,
                Price = price,
                Inventory = inventory
            };
            bool success = await shareFile.SaveOrUpdateAsync(newProduct, pkExists,
                async (product) => await apiService.UpdateProductAsync(product),
                async (product) => await apiService.InsertProductAsync(product)
            );
            if (success)
            {
                TextReadOnlyControlOn();
                TextBoxClear();
            }
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

        private void homePanel_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}