using Fitness_App_Engine;
using System.Globalization;

namespace Fitness_Tracker_App
{
    public partial class MainForm : Form
    {
        public static int _year, _month;

        public static int _dayWidth, _dayHeight;

        public List<calendarDay> selectedDays;

        public MainForm()
        {
            this.selectedDays = new List<calendarDay>();
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
            selectedDays.Clear();//clear previous selected days
            flowLayoutPanel1.Controls.Clear();//clear previous month

            //set display date
            _year = year;
            _month = month;

            //dynamic sizing for days
            _dayWidth = (int)(flowLayoutPanel1.Width / 7.3);
            _dayHeight = (int)(flowLayoutPanel1.Height / 6.3);

            //set label with month name
            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            label1.Text = monthName;//.ToUpper();


            DateTime startOfTheMonth = new DateTime(year, month, 1);//start of month is the first day in that month;
            int day = DateTime.DaysInMonth(year, month);//total days in the month

            //this is killing me, it's how we create the days before the first of the month
            //it is taking the day of the month (wednseday) and converting it to an int, so that that that the correct number of days before it are made
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            int dayRelation = 0;//-1 for before, 0 for current, 1 for future

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

            int tempDayRelation = dayRelation;//need a temporary so we can change it while still being able to go back to dayRelation


            for (int i = 0; i < week; i++)//buffer days before the first of the month
            {
                if (tempDayRelation == 0)
                {
                    tempDayRelation = -1;
                }
                calendarDay blankDay = new calendarDay(this, "", tempDayRelation, _dayWidth, _dayHeight);
                blankDay.hideButtons();
                flowLayoutPanel1.Controls.Add(blankDay);
            }
            tempDayRelation = dayRelation;
            for (int i = 1; i <= day; i++)//normal days
            {
                if (dayRelation == 0)
                {
                    tempDayRelation = i - DateTime.Now.Day;
                }
                calendarDay Date = new calendarDay(this, i + "", tempDayRelation, _dayWidth, _dayHeight);
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
                flowLayoutPanel1.Controls.Add(Date);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        // Workout
        private void button1_Click(object sender, EventArgs e)
        {
            List<Exercise> exercises = new List<Exercise>(); // here we will get the lists of exercises for that day
            var formPopup = new WorkoutForm(DateTime.Now, exercises);
            formPopup.FormClosed += this.WorkoutFormClosed;
            formPopup.ShowDialog(this);

        }

        private void WorkoutFormClosed(object? sender, EventArgs e)
        {
            if(sender is WorkoutForm workoutForm)
            {
                foreach(Exercise exercise in workoutForm.Exercises)
                {
                    // Add to calendar's list of exercises for a given day
                }
            }
        }

        // nutrintion form
        private void button2_Click(object sender, EventArgs e)
        {
            List<Meal> meals = new List<Meal>(); // here we will get the list of meals for that day
            var formPopup = new NutritionForm(DateTime.Now, meals);
            formPopup.FormClosed += this.NutritionFormClosed;
            formPopup.ShowDialog(this);
        }

        private void NutritionFormClosed(object? sender, EventArgs e)
        {
            if (sender is WorkoutForm workoutForm)
            {
                foreach (Exercise exercise in workoutForm.Exercises)
                {
                    // Add to calendar's list of stuff
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formPopup = new GoalForm();
            formPopup.ShowDialog(this);
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

        private void resize()
        {
            this.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                ctrl.Width = (int)(flowLayoutPanel1.ClientSize.Width / 7.5);
                ctrl.Height = (int)(flowLayoutPanel1.ClientSize.Height / 7.5);
            }
            this.ResumeLayout();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            //this.resize();
            //this.flowLayoutPanel1.SuspendLayout();
            //this.flowLayoutPanel1.Controls.Clear();
            //this.flowLayoutPanel1.ResumeLayout();
            this.showDays(DateTime.Now.Month, DateTime.Now.Year);
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            //this.flowLayoutPanel1.Controls.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numSelectedDays = 0;
            foreach (calendarDay ctrl in flowLayoutPanel1.Controls)
            {
                if(ctrl.isSelected())
                {
                    numSelectedDays += 1;
                }
            }
            var formPopup = new Form();
            int shade = (int) (255 / 42.0 * numSelectedDays);
            formPopup.BackColor = Color.FromArgb(shade, shade, shade);
            formPopup.ShowDialog(this);
        }

        private List<string> datesFromSelectedDays()//can be changed to return an array of dates/ a date struct
        {
            List<string> date = new List<string>();
            foreach(calendarDay ctrl in this.selectedDays)
            {

            }
            return date;
        }
    }
}
