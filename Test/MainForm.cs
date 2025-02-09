namespace Test
{
    public partial class MainForm : Form
    {
        private DateTime currentDate;
        private DateTime td;
        private UserControlDays lastSelectedDay;
        public MainForm()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            td = DateTime.Now.Date;
            lastSelectedDay = null;
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
                UserControlBlank ucB = new UserControlBlank();
                daycontainer.Controls.Add(ucB);
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucD = new UserControlDays();
                ucD.days(i);
                ucD.Click += Day_Click;
                daycontainer.Controls.Add(ucD);
            }
            displayMonth.Text = currentDate.ToString("MMM yyyy");
        }
        private void MainForm_Load(object sender, EventArgs e) 
        {
            displayDays();
        }

        private void lastMonth_Click(object sender, EventArgs e) 
        {
            currentDate = currentDate.AddMonths(-1); 
            displayDays();
        }
        private void nextMonth_Click(Object sender, EventArgs e) 
        {
            currentDate = currentDate.AddMonths(1);
            displayDays();
        }
        private void today_Click(object sender, EventArgs e)
        {
            currentDate = td;
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            //Open form or panel
        }
        private void Day_Click(object sender, EventArgs e)
        {
            UserControlDays clickedDay = (UserControlDays)sender;
            if (lastSelectedDay != null)
            {
                lastSelectedDay.Deselect();
            }
            clickedDay.Select();
            lastSelectedDay = clickedDay;
        }
    }
}
