﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Services;

namespace UI.Controls
{
    public partial class CalendarDays : UserControl
    {
        private readonly ApiService apiService;
        public CalendarDays()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        private bool isSelected = false;
        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public int tDay { get; set; }
        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
            tDay = numday;
        }
        private void CalendarDays_Click(object sender, EventArgs e)
        {
            isSelected = !isSelected;
            UpdateHighlight();
        }
        private void UpdateHighlight()
        {
            if (isSelected)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
        public void Select()
        {
            this.BackColor = Color.LightBlue;
            isSelected = true;
        }
        public void Deselect()
        {
            this.BackColor = Color.White;
            isSelected = false;
        }
        public void SetEventLabel(string summary)
        {
            eventLabel.Text = summary + "...";
        }
        public void ClearEventLabel()
        {
            eventLabel.Text = string.Empty;
            eventLabel.Visible = false;
        }
        public void ShowEventLabel()
        {
            eventLabel.Visible = true;
        }
    }
}
