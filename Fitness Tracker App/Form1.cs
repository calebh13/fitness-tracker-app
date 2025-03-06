using System.Globalization;

namespace Fitness_Tracker_App
{
    public partial class Form1 : Form
    {
        public static int _year, _month;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void showDays(int month, int year)//for calendar
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            label1.Text = monthName;//.ToUpper();
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            int dayRelation = 0;

            if (_year < DateTime.Now.Year)
            {
                dayRelation = -1;
            }
            else if (_year > DateTime.Now.Year)
            {
                dayRelation = 1;
            }
            else if (_month < DateTime.Now.Month)
            {
                dayRelation = -1;
            }
            else if (_month > DateTime.Now.Month)
            {
                dayRelation = 1;
            }

            int tempDayRelation = dayRelation;
            for (int i = 0; i < week; i++)
            {
                if (tempDayRelation == 0)
                {
                    tempDayRelation = -1;
                }
                ucDays uc = new ucDays("", tempDayRelation);
                flowLayoutPanel1.Controls.Add(uc);
            }
            tempDayRelation = dayRelation;
            for (int i = 1; i <= day; i++)
            {
                if (dayRelation == 0)
                {
                    tempDayRelation = i - DateTime.Now.Day;
                }
                ucDays uc = new ucDays(i + "", tempDayRelation);
                //if (i < DateTime.Now.Day)
                //{
                //    uc.dateHasPassed();
                //}
                //else if (i == DateTime.Now.Day)
                //{
                //    uc.currentDate();
                //}
                //else
                //{
                //    uc.futureDate();
                //}
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                ctrl.Width = (int) (flowLayoutPanel1.ClientSize.Width/7.5);
                ctrl.Height = (int)(flowLayoutPanel1.ClientSize.Height / 7.5);

            }
            this.ResumeLayout();
        }
    }
}
