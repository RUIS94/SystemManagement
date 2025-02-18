using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Model;
using UI.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Model.DTO;

namespace UI
{
    public class ShareFile
    {
        #region Form and Control Management
        public void SetForm(Control control, Control parent)
        {
            SetControlLocation(control, parent);
            parent.Controls.Add(control);
            control.Show();
            control.BringToFront();
        }

        public void SetControlLocation(Control control, Control parent)
        {
            control.Location = new Point(
                (parent.Width - control.Width) / 2,
                (parent.Height - control.Height) / 2
            );
        }

        public void SetTextBoxReadOnly(Control[] controls, bool readOnly)
        {
            foreach (var control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = readOnly;
                }
            }
        }
        public void ClearTextBoxes(Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
        public void HandleTrackBarScroll(TrackBar trackBar, Action textReadOnlyOn, Action textReadOnlyOff)
        {
            trackBar.Minimum = 0;
            trackBar.Maximum = 1;
            if (trackBar.Value == trackBar.Minimum)
            {
                textReadOnlyOn();
            }
            else if (trackBar.Value == trackBar.Maximum)
            {
                textReadOnlyOff();
            }
        }
        public void RemoveSelectedRows(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
                {
                    if (!selectedRow.IsNewRow)
                    {
                        dataGridView.Rows.Remove(selectedRow);
                    }
                }
            }
            else
            {
                WarningMessage("Please select a row");
            }
        }
        public void CloseAllControlsInPanel(Panel panel)
        {
            for (int i = panel.Controls.Count - 1; i >= 0;  i--)
            {
                if (panel.Controls[i] is Form form)
                {
                    form.Close();
                    form.Dispose();
                }
            }
            panel.Controls.Clear();
        }
        #endregion

        #region Data Binding and Search

        public void BindRowDataToTextBoxes(Dictionary<string, TextBox> bindings, string[] columnNames, string[] rowData)
        {
            var dataDictionary = new Dictionary<string, string>();
            for (int i = 0; i < columnNames.Length && i < rowData.Length; i++)
            {
                dataDictionary[columnNames[i]] = rowData[i];
            }
            foreach (var kvp in bindings)
            {
                string key = kvp.Key;
                TextBox targetTextBox = kvp.Value;
                if (dataDictionary.TryGetValue(key, out string value))
                {
                    targetTextBox.Text = value;
                }
            }
        }
        public async Task<List<T>> ExecuteSearchAsync<T>(string searchTerm, Func<string, Task<List<T>>> searchFunc)
        {
            try
            {
                return await searchFunc(searchTerm);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return new List<T>();
            }
        }
        public void UpdateSearchResults<T>(DataGridView searchResult, List<T> searchResults)
        {
            if (searchResults.Count > 0)
            {
                searchResult.DataSource = searchResults;
            }
            else
            {
                ShowMessage("No Result Found");
            }
        }
        #endregion

        #region Confirmation and Validation

        public bool ConfirmAction(string message, string title)
        {
            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
        public bool ValidateValue(string textVal, string textName)
        {
            IsValid isvalid = new IsValid();
            if (!isvalid.NullVal(textVal))
            {
                ShowMessage($"{textName} need a value.");
                return false;
            }
            return true;
        }

        #endregion

        #region Async Methods

        public async Task<bool> SaveOrUpdateAsync<T>(T entity, bool pkExists, Func<T, Task<bool>> updateAction, Func<T, Task<bool>> insertAction)
        {
            try
            {
                return pkExists
                    ? await ProcessActionAsync(entity, updateAction, "Update")
                    : await ProcessActionAsync(entity, insertAction, "Create");
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }
        public async Task<bool> ProcessActionAsync<T>(T entity, Func<T, Task<bool>> action, string actionType)
        {
            bool success = await action(entity);
            ShowResultMessage(success, actionType);
            return success;
        }
        public async Task<int> GenerateId(ApiService apiService, string tableName, string idColumn)
        {
            return await apiService.GenerateNewIdAsync(tableName, idColumn);
        }
        #endregion

        #region Image Handling

        public void LoadImage(string filePath, string filename, PictureBox picturebox)
        {
            string imagePath = Path.Combine(filePath, $"{filename}.jpg");
            if (File.Exists(imagePath))
            {
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                picturebox.Image = Image.FromFile(imagePath);
            }
            else
            {
                picturebox.Image = null;
            }
        }

        #endregion

        #region User Feedback Methods
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ShowResultMessage(bool success, string actionType)
        {
            string message = success ? $"{actionType} successfully." : $"Failed to {actionType.ToLower()}.";
            ShowMessage(message);
        }
        public void HandleException(Exception ex)
        {
            ShowMessage($"Error: {ex.Message}");
        }
        public bool HandleSearchException(string message)
        {
            return ConfirmAction(message, "Add New?");
        }
        public void WarningMessage(string  message) 
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region TextBox User Friendly
        public void TextBox_KeyDown(object sender, KeyEventArgs e, Control previousControl, Control nextControl)
        {
            if (e.KeyCode == Keys.Up)
            {
                previousControl?.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                nextControl?.Focus();
            }
        }
        public void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                textbox.BackColor = Color.Yellow;
            }
        }
        public void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                textbox.BackColor = SystemColors.Window;
            }
        }
        public void BindTextBoxEvent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Enter += TextBox_Enter;
                    textbox.Leave += TextBox_Leave;
                }
                else if (control.HasChildren)
                {
                    BindTextBoxEvent(control);
                }
            }
        }
        private static List<TextBox> boxList = new List<TextBox>();
        public void RegisterBoxes(List<TextBox> boxes)
        {
            boxList = new List<TextBox>(boxes);
            foreach (var tb in boxList)
            {
                //tb.KeyDown -= TextBox_KeyDown;
                tb.KeyDown += TextBox_KeyDown;
            }
        }
        private static void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not TextBox ctb) return;
            int index = boxList.IndexOf(ctb);
            if (e.KeyCode == Keys.Down && index < boxList.Count - 1)// || e.KeyCode == Keys.Tab && index < boxList.Count - 1)
            {
                boxList[index + 1].Focus();
            }
            else if (e.KeyCode == Keys.Up && index > 0)// || e.Shift && e.KeyCode == Keys.Tab)
            {
                boxList[index - 1].Focus();
            }
        }
        #endregion

        #region DataGridView User Friendly
        public void MoveToAdjacentCell(DataGridView dataGridView, Keys keyData, TextBox targetTextBox)
        {
            int currentRow = dataGridView.CurrentCell.RowIndex;
            int currentColumn = dataGridView.CurrentCell.ColumnIndex;
            int rowCount = dataGridView.Rows.Count;
            int columnCount = dataGridView.Columns.Count;
            int rowIncrement = (keyData == Keys.Up) ? -1 : (keyData == Keys.Down) ? 1 : 0;
            int columnIncrement = (keyData == Keys.Left) ? -1 : (keyData == Keys.Right) ? 1 : 0;
            int newRow = currentRow + rowIncrement;
            int newColumn = currentColumn + columnIncrement;
            if (keyData == Keys.Left && currentRow == 0 && IsFirstEditableCellInRow(dataGridView, currentRow, currentColumn))
            {
                targetTextBox.Focus();
                return;
            }
            if (keyData == Keys.Up && currentRow == 0 && IsFirstEditableCellInRow(dataGridView, currentRow, currentColumn))
            {
                targetTextBox.Focus();
                return;
            }
            if (keyData == Keys.Right && IsLastEditableCellInRow(dataGridView, currentRow, currentColumn))
            {
                newRow++;
                newColumn = 0;
            }
            if (keyData == Keys.Left && IsFirstEditableCellInRow(dataGridView, currentRow, currentColumn))
            {
                newRow--;
                newColumn = columnCount - 1; 
            }
            while (newRow >= 0 && newRow < rowCount && newColumn >= 0 && newColumn < columnCount)
            {
                if (!dataGridView.Rows[newRow].Cells[newColumn].ReadOnly)
                {
                    dataGridView.CurrentCell = dataGridView.Rows[newRow].Cells[newColumn];
                    return;
                }
                newRow += rowIncrement;
                newColumn += columnIncrement;
            }
        }
        private bool IsLastEditableCellInRow(DataGridView dataGridView, int row, int currentColumn)
        {
            for (int col = currentColumn + 1; col < dataGridView.Columns.Count; col++)
            {
                if (!dataGridView.Rows[row].Cells[col].ReadOnly)
                {
                    return false; 
                }
            }
            return true; 
        }
        private bool IsFirstEditableCellInRow(DataGridView dataGridView, int row, int currentColumn)
        {
            for (int col = 0; col < currentColumn; col++)
            {
                if (!dataGridView.Rows[row].Cells[col].ReadOnly)
                {
                    return false; 
                }
            }
            return true;
        }
        public void MoveToNextEditableCell(DataGridView dataGridView)
        {
            var currentCell = dataGridView.CurrentCell;
            if (currentCell != null)
            {
                int nextColumnIndex = currentCell.ColumnIndex + 1;
                while (nextColumnIndex < dataGridView.Columns.Count &&
                       dataGridView.Columns[nextColumnIndex].ReadOnly)
                {
                    nextColumnIndex++;
                }

                if (nextColumnIndex < dataGridView.Columns.Count)
                {
                    dataGridView.CurrentCell = dataGridView.Rows[currentCell.RowIndex].Cells[nextColumnIndex];
                }
                else
                {
                    if (currentCell.RowIndex < dataGridView.Rows.Count - 1)
                    {
                        int nextRowIndex = currentCell.RowIndex + 1;
                        nextColumnIndex = 0;
                        while (nextColumnIndex < dataGridView.Columns.Count &&
                               dataGridView.Columns[nextColumnIndex].ReadOnly)
                        {
                            nextColumnIndex++;
                        }
                        if (nextColumnIndex < dataGridView.Columns.Count)
                        {
                            dataGridView.CurrentCell = dataGridView.Rows[nextRowIndex].Cells[nextColumnIndex];
                        }
                    }
                }
            }
        }
        public void RewriteSequence(DataGridView datagridview)
        {
            while (datagridview.Rows.Count < 100)
            {
                datagridview.Rows.Add();
            }
            for (int i = 0; i < 100; i++)
            {
                if (!datagridview.Rows[i].IsNewRow)
                {
                    datagridview.Rows[i].Cells["sequence"].Value = i + 1;
                }
            }
        }
        #endregion

        #region UI Actions
        public void ResetControlPosition(List<Control> controls, int startY = 40, int spacing = 10)
        {
            int currentY = startY;

            foreach (Control control in controls)
            {
                control.Location = new Point(control.Location.X, currentY);
                currentY += control.Height + spacing;
            }
        }
        #endregion

        #region Local File Path
        public string RP()
        {
            return "E://SystemManagement//";
        }
        #endregion

        #region Open Link in Browser
        public void AccessBrowser(string url)
        {
            var info = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(info);
        }
        #endregion

        #region User Operation Logs
        public ActionLog RecodeAction(string message)
        {
            var log = new ActionLog
            {
                Action = message
            };
            return log;
        }
        #endregion

        #region File Management
        public string Nowtime()
        {
            return DateTime.Now.ToString("ddMMyyyy_HHmmss");
        }
        public void CheckData<T>(List<T> data)
        {
            if (data == null || data.Count == 0)
            {
                ShowMessage("Data is Null");
                return;
            }
        }
        public void CheckFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                ShowMessage($"{filePath} does not exists");
            }
        }
        public void CreateFoler(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public void WriteData<T>(List<T> data, string filepath)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            using (StreamWriter writer = new StreamWriter(filepath, false, Encoding.UTF8))
            {
                writer.WriteLine(string.Join(",", properties.Select(p => p.Name)));
                foreach (var item in data)
                {
                    var values = properties.Select(p => p.GetValue(item, null)?.ToString() ?? "");
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }
        public void ExportToCsv<T>(List<T> data, string  path, string type)
        {
            try
            {
                CheckData(data);
                CreateFoler(path);
                string filename = $"{type}_{Nowtime()}.csv";
                string filepath = Path.Combine(path, filename);
                WriteData(data, filepath);
                ShowMessage($"file save to {path}");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        public void BackuoDatabase(string sourceFile, string backupFolder)
        {
            try
            {
                CreateFoler(backupFolder);
                string filename = Path.GetFileNameWithoutExtension(sourceFile);
                string fileExtension = Path.GetExtension(sourceFile);
                string backupFile = Path.Combine(backupFolder, $"{filename}_BackUp_{Nowtime()}{fileExtension}");
                File.Copy(sourceFile, backupFile, true);
                ShowMessage($"Backup database to {backupFolder}");
            }
            catch (Exception ex)
            { 
                HandleException(ex); 
            }
        }
        #endregion
    }
}

