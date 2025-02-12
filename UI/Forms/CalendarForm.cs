using System.Data;
using System.Globalization;
using System.Reflection;
using Model;
using Newtonsoft.Json;
using UI.Controls;
using UI.Forms;
using UI.Services;
namespace UI.Forms
{
    public partial class CalendarForm : Form
    {
        ShareFile shareFile = new ShareFile();
        private DateTime currentDate;
        private DateTime td;
        private CalendarDays lastSelectedDay;
        private readonly ApiService apiService;
        public CalendarForm()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            td = DateTime.Now.Date;
            lastSelectedDay = null;
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        //public class CustomFLPanel : FlowLayoutPanel
        //{
        //    public CustomFLPanel()
        //    {
        //        this.DoubleBuffered = true;
        //    }
        //}
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            displayDays();
            today_Click(sender, e);
            UpdateCalendarEvents();
        }
        private EventsForm eventsform;
        private void addEvent_Click(object sender, EventArgs e)
        {
            if (eventsform == null || eventsform.IsDisposed)
            {
                eventsform = new EventsForm();
                eventsform.TopLevel = false;
                shareFile.SetForm(eventsform, this);
                eventsform.DisplayTime(td);
                homePanel.Enabled = false;
            }
            else
            {
                eventsform.BringToFront();
            }
            eventsform.FormClosed += (sender, e) =>
            {
                homePanel.Enabled = true;
            };
        }
        private void today_Click(object sender, EventArgs e)
        {
            currentDate = td;
            if (lastSelectedDay != null)
            {
                lastSelectedDay.Deselect();
            }
            displayDays();
            foreach (Control control in daycontainer.Controls)
            {
                if (control is CalendarDays calendarDay)
                {
                    int dayNumber = calendarDay.tDay;
                    if (dayNumber == td.Day && currentDate.Month == td.Month && currentDate.Year == td.Year)
                    {
                        calendarDay.Select();
                        lastSelectedDay = calendarDay;
                        break;
                    }
                }
            }
        }
        private void lastMonth_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            displayDays();
        }
        private void nextMonth_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            displayDays();
        }
        private void Day_Click(object sender, EventArgs e)
        {
            CalendarDays clickedDay = (CalendarDays)sender;
            if (lastSelectedDay != null)
            {
                lastSelectedDay.Deselect();
            }
            clickedDay.Select();
            lastSelectedDay = clickedDay;
        }
        private void displayDays()
        {
            daycontainer.Controls.Clear();
            DateTime now = currentDate;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            int firstDayOfWeek = (int)startofthemonth.DayOfWeek;

            for (int i = 0; i < firstDayOfWeek; i++)
            {
                CalendarBlank calendarB = new CalendarBlank();
                daycontainer.Controls.Add(calendarB);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                CalendarDays calendarD = new CalendarDays();
                calendarD.days(i);
                calendarD.Click += Day_Click;
                daycontainer.Controls.Add(calendarD);
            }

            m_yDisp.Text = currentDate.ToString("MMM yyyy");
            UpdateCalendarEvents();
        }
        private async void UpdateCalendarEvents()
        {
            List<Events> events = await apiService.GetAllEventsAsync();
            foreach (Control control in daycontainer.Controls)
            {
                if (control is CalendarDays calendarDay)
                {
                    DateTime dayDate = new DateTime(currentDate.Year, currentDate.Month, calendarDay.tDay);
                    var dayEvents = events.Where(e => e.Date == dayDate.ToString("dd/MM/yyyy")).ToList();
                    if (dayEvents.Any())
                    {
                        string summary = dayEvents.First().Summary;
                        string shortSummary = GetFirstFewWords(summary, 1);
                        calendarDay.SetEventLabel(shortSummary);
                        calendarDay.ShowEventLabel();
                    }
                    else
                    {
                        calendarDay.ClearEventLabel();
                    }
                }
            }
        }
        public void RefreshCalendarEvents()
        {
            UpdateCalendarEvents();
        }
        private string GetFirstFewWords(string input, int wordCount)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words.Take(wordCount));
        }
        private string selectedM;
        private MonthSelect ms;
        private void m_yDisp_Click(object sender, EventArgs e)
        {
            ms = new MonthSelect();
            selectPanel.Controls.Add(ms);
            selectPanel.Visible = true;
            selectPanel.ControlRemoved += (s, args) => 
            {
                selectedM = ms.SeleMonth();
                selectPanel.Visible = false;
                SetDate();
                //shareFile.ShowMessage($"{selectedM}");
            };
        }
        private void SetDate()
        {
            currentDate = DateTime.ParseExact(selectedM, "M/yyyy", CultureInfo.InvariantCulture);
            displayDays();
        }
    }
}
