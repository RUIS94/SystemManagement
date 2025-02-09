using System.Globalization;
using Model;
using Newtonsoft.Json;
using UI.Services;

namespace UI.Forms
{
    public partial class EventsForm : Form
    {
        DateTime dt = DateTime.Now;
        ShareFile sf = new ShareFile();
        private readonly ApiService apiService;
        private string filePath;
        private CalendarForm cf;
        public EventsForm()
        {
            InitializeComponent();
            string rp = sf.RP();
            filePath = ($"{rp}events.txt");
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            LoadEventsFromFile();
            DisplayTime(dt);
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            SaveEventsToFile();
            //if (this.Owner is CalendarForm calendarForm)
            //{
            //    calendarForm.RefreshCalendarEvents();
            //}
            //cf.RefreshCalendarEvents();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string input = dt.ToString("dd/MM/yyyy - HH:mm");
            if (noteBox.Text.Trim() == "")
            {
                noteBox.Text = $"{input} (user):\n";
            }
            else
            {
                noteBox.AppendText($"\r\n {input} (user):\n");
            }
            noteBox.AppendText("\r\n");
            noteBox.Focus();
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            if (!calendar.Visible)
            {
                calendar.Visible = true;
            }
            else
            {
                calendar.Visible = false;
            }
        }

        private void leftLabel_Click(object sender, EventArgs e)
        {
            ct = dt.AddDays(-1);
            dt = ct;
            DisplayTime(ct);
            LoadEventsFromFile();
        }
        private DateTime ct;
        private void rightLabel_Click(object sender, EventArgs e)
        {
            ct = dt.AddDays(1);
            dt = ct;
            DisplayTime(ct);
            LoadEventsFromFile();
        }

        public void DisplayTime(DateTime dateTime)
        {
            dayLabel.Text = dateTime.ToString("dd");
            weekLabel.Text = dateTime.ToString("dddd");
            monthLabel.Text = dateTime.ToString("MMMM");
            yearLabel.Text = dateTime.ToString("yyyy");
            dateBox.Text = dateTime.ToString("dd/MM/yyyy");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F5:
                    addBtn.PerformClick();
                    return true;
                case Keys.F9:
                    cancelBtn.PerformClick();
                    return true;
                case Keys.F10:
                    okBtn.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void summaryBox_TextChanged(object sender, EventArgs e)
        {
            if (eventList.CurrentRow != null)
            {
                int rowIndex = eventList.CurrentRow.Index;
                eventList.Rows[rowIndex].Cells["summary"].Value = summaryBox.Text;
            }
        }

        private void addeventBtn_Click(object sender, EventArgs e)
        {
            string summary = summaryBox.Text;
            string notes = noteBox.Text;
            string selectedDate = dt.ToString("dd/MM/yyyy");

            if (eventList.CurrentRow != null)
            {
                int rowIndex = eventList.CurrentRow.Index;
                eventList.Rows[rowIndex].Cells["date"].Value = selectedDate;
                eventList.Rows[rowIndex].Cells["summary"].Value = summary;
                eventList.Rows[rowIndex].Cells["text"].Value = notes;
            }
        }
        private async void SaveEventsToFile()
        {
            //List<EventInfo> events = new List<EventInfo>();
            //foreach (DataGridViewRow row in eventList.Rows)
            //{
            //    if (row.Cells["date"].Value != null && row.Cells["summary"].Value != null && row.Cells["text"].Value != null)
            //    {
            //        EventInfo eventInfo = new EventInfo
            //        {
            //            Date = row.Cells["date"].Value.ToString(),
            //            Summary = row.Cells["summary"].Value.ToString(),
            //            Notes = row.Cells["text"].Value.ToString()
            //        };
            //        events.Add(eventInfo);
            //    }
            //}

            //string json = JsonConvert.SerializeObject(events, Formatting.Indented);
            //File.WriteAllText(filePath, json);
            //List<Events> eventsList = new List<Events>();
            //foreach (DataGridViewRow row in eventList.Rows)
            //{
            //    if (row.Cells["date"].Value != null)
            //    {
            //        if (row.Cells["id"].Value != null)
            //        {
            //            Events eventItem = new Events
            //            {
            //                ID = (string)row.Cells["id"].Value,
            //                Summary = row.Cells["summary"].Value?.ToString(),
            //                Date = row.Cells["date"].Value?.ToString(),
            //                Notes = row.Cells["text"].Value?.ToString()
            //            };
            //            await apiService.UpdateEventAsync(eventItem);
            //        }
            //        else
            //        {
            //            int ID = await apiService.GenerateNewIdAsync("Events", "ID");
            //            string stringID = ID.ToString();
            //            Events newevent = new Events
            //            {
            //                ID = stringID,
            //                Summary = row.Cells["summary"].Value?.ToString(),
            //                Date = row.Cells["date"].Value?.ToString(),
            //                Notes = row.Cells["text"].Value?.ToString()
            //            };
            //            await apiService.InsertEventsAsync(newevent);
            //        }
            //    }               
            //}
            List<Events> list = new List<Events>();
            foreach (DataGridViewRow row in eventList.Rows) 
            {
                if (row.Cells["date"].Value != null )
                {
                    Events eventItem = new Events
                    {
                        ID = (string)row.Cells["id"].Value,
                        Summary = row.Cells["summary"].Value?.ToString(),
                        Date = row.Cells["date"].Value?.ToString(),
                        Notes = row.Cells["text"].Value?.ToString()
                    };
                    list.Add(eventItem);
                }
                else
                {
                    break;
                }
            }

            foreach (var item  in list)
            {
                if(item.ID != null)
                {
                    await apiService.UpdateEventAsync(item);
                }
                else
                {
                    int ID = await apiService.GenerateNewIdAsync("Events", "ID");
                    string stringID = ID.ToString();
                    item.ID = stringID;
                    await apiService.InsertEventsAsync(item);
                }
            }
        }
        private async void LoadEventsFromFile()
        {
            eventList.Rows.Clear();
            //if (File.Exists(filePath))
            //{
            //    string json = File.ReadAllText(filePath);
            //    List<EventInfo> events = JsonConvert.DeserializeObject<List<EventInfo>>(json);
            //    string selectedDate = dt.ToString("dd/MM/yyyy");
            //    foreach (var eventInfo in events)
            //    {
            //        if (eventInfo.Date == selectedDate)
            //        {
            //            eventList.Rows.Add(eventInfo.Date, eventInfo.Summary, eventInfo.Notes);
            //        }
            //    }
            //}
            string stringDt = dt.ToString("dd/MM/yyyy");
            List<Events> results = await apiService.GetEventsByDateAsync(stringDt);
            foreach (Events events in results)
            {
                eventList.Rows.Add();
                int lastRowIndex = eventList.Rows.Count - 1;
                eventList.Rows[lastRowIndex].Cells["id"].Value = events.ID;
                eventList.Rows[lastRowIndex].Cells["summary"].Value = events.Summary;
                eventList.Rows[lastRowIndex].Cells["date"].Value = events.Date;
                eventList.Rows[lastRowIndex].Cells["text"].Value = events.Notes;
            }
            sf.RewriteSequence(eventList);
        }
        //public class EventInfo
        //{
        //    public string Date { get; set; }
        //    public string Summary { get; set; }
        //    public string Notes { get; set; }
        //}

        private void eventList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (eventList.CurrentRow != null)
            {
                int rowIndex = eventList.CurrentRow.Index;
                string summary = eventList.Rows[rowIndex].Cells["summary"].Value?.ToString();
                string date = eventList.Rows[rowIndex].Cells["date"].Value?.ToString();
                string text = eventList.Rows[rowIndex].Cells["text"].Value?.ToString();
                summaryBox.Text = summary ?? string.Empty;
                dateBox.Text = date ?? string.Empty;
                noteBox.Text = text ?? string.Empty;
            }
        }
        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            ct = e.End;
            dt = ct;
            string dateString = ct.ToString("dd/MM/yyyy");
            dateBox.Text = dateString;
            calendar.Visible = false;
            DisplayTime(ct);
        }
    }
}
