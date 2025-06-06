using Fitness_App_Engine;
using System.Globalization;
using System.Windows.Forms;
using System.Text.Json;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.IO;

namespace Fitness_Tracker_App
{
    public partial class MainForm : Form
    {
        private string filePath;

        public static int _year, _month;

        public static int _dayWidth, _dayHeight;

        public List<calendarDay> selectedDays;

        public calendarBackend backend;

        public MainForm(string username)
        {

            filePath = "./users/" + username;
            //DirectoryInfo directory = Directory.CreateDirectory(filePath);
            Directory.CreateDirectory(filePath);
            this.selectedDays = new List<calendarDay>();
            this.backend = new calendarBackend();
            InitializeComponent();

            try
            {
                string json = File.ReadAllText(filePath + "/calendarData.json");

                var result = MessageBox.Show("Previous fitness data detected. Do you want to load it?", "Confirm Load",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.LoadData(json);
                }
            }
            catch (Exception)
            {
                this.backend = new calendarBackend();
            }
            this.FunFact();
        }

        public int getMonth()
        {
            return _month;
        }

        public int getYear()
        {
            return _year;
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
            int month = _month;
            int year = _year;
            int day = DateTime.Now.Day;
            DateTime date = new DateTime(year, month, day);
            var formPopup = new WorkoutForm(date, exercises);
            formPopup.FormClosed += this.WorkoutFormClosed;
            formPopup.ShowDialog(this);

        }

        public void WorkoutFormClosed(object? sender, EventArgs e)
        {
            if (sender is WorkoutForm workoutForm)
            {
                List<DateTime> dayList = this.datesFromSelectedDays();
                if (dayList.Any())//from selected days
                {
                    foreach (DateTime day in dayList)
                    {
                        backend.addWorkouts(day, workoutForm.Exercises);
                    }
                    foreach (calendarDay ctrl in flowLayoutPanel1.Controls)
                    {
                        ctrl.deselectDay();
                    }
                }
                else
                {
                    if (this.backend.dateIsInDictionary(workoutForm.Date))
                    {
                        this.backend.getDay(workoutForm.Date).clearExercises();
                    }

                    this.backend.addWorkouts(workoutForm.Date, workoutForm.Exercises);
                }
                this.FunFact();
            }
        }

        // nutrintion form
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            List<Meal> meals = new List<Meal>(); // here we will get the list of meals for that day
            var formPopup = new NutritionForm(DateTime.Now, meals);
            formPopup.FormClosed += this.NutritionFormClosed;
            formPopup.ShowDialog(this);
            */
            List<Meal> exercises = new List<Meal>(); // here we will get the lists of exercises for that day
            int month = _month;
            int year = _year;
            int day = DateTime.Now.Day;
            DateTime date = new DateTime(year, month, day);
            var formPopup = new NutritionForm(date, exercises);
            formPopup.FormClosed += this.NutritionFormClosed;
            formPopup.ShowDialog(this);
        }

        public void NutritionFormClosed(object? sender, EventArgs e)
        {
            if (sender is NutritionForm nutritionForm)
            {
                List<DateTime> dayList = this.datesFromSelectedDays();
                if (dayList.Any())//from selected days
                {
                    foreach (DateTime day in dayList)
                    {
                        backend.addMeals(day, nutritionForm.Meals);
                    }
                    foreach (calendarDay ctrl in flowLayoutPanel1.Controls)
                    {
                        ctrl.deselectDay();
                    }
                }
                else
                {
                    if (this.backend.dateIsInDictionary(nutritionForm.Date))
                    {
                        this.backend.getDay(nutritionForm.Date).clearNutrition();
                    }

                    this.backend.addMeals(nutritionForm.Date, nutritionForm.Meals);
                }
                this.FunFact();
            }
        }

        /// <summary>
        /// The button to create a goal form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int month = _month;
            int year = _year;
            int day = DateTime.Now.Day;
            DateTime date = new DateTime(year, month, day);
            var formPopup = new GoalForm(date, this.backend.goals);
            formPopup.FormClosed += this.GoalFormClosed;
            formPopup.ShowDialog(this);
        }


        private void GoalFormClosed(object? sender, EventArgs e)
        {
            if (sender is GoalForm goalForm)
            {
                List<DateTime> dayList = this.datesFromSelectedDays();
                if (dayList.Any())//from selected days
                {
                    foreach (DateTime day in dayList)
                    {
                        backend.AddGoals(goalForm.Exercises);
                    }
                    foreach (calendarDay ctrl in flowLayoutPanel1.Controls)
                    {
                        ctrl.deselectDay();
                    }
                }
                else
                {
                    if (this.backend.dateIsInDictionary(goalForm.Date))
                    {
                        this.backend.getDay(goalForm.Date).clearExercises();
                    }

                    this.backend.AddGoals(goalForm.Exercises);
                }
            }
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
                if (ctrl.isSelected())
                {
                    numSelectedDays += 1;
                }
            }
            var formPopup = new Form();
            int shade = (int)(255 / 42.0 * numSelectedDays);
            formPopup.BackColor = System.Drawing.Color.FromArgb(shade, shade, shade);
            formPopup.ShowDialog(this);
        }

        private List<DateTime> datesFromSelectedDays()//can be changed to return an array of dates/ a date struct
        {
            List<DateTime> listOfSelectedDates = new List<DateTime>();
            foreach (calendarDay ctrl in this.selectedDays)
            {

                listOfSelectedDates.Add(new DateTime(_year, _month, ctrl.getDayNumber()));
            }
            return listOfSelectedDates;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = tabControl1.SelectedIndex;
            if (tabIndex == 1)
            {
                int totalCalories = 0;
                int totalMeals = 0;
                int totalProtein = 0;
                int biggestMeal = 0;
                string biggestMealName = "";

                int totalWeightMoved = 0;
                int totalExercises = 0;
                int heaviestWeight = 0;
                string heaviestWorkout = "";
                foreach (var dictionary in backend.Days)
                {
                    foreach (var exercise in dictionary.Value.GetExercises())
                    {
                        totalWeightMoved += exercise.Weight;
                        totalExercises += 1;
                        if (exercise.Weight > heaviestWeight)
                        {
                            heaviestWeight = exercise.Weight;
                            heaviestWorkout = exercise.Name;
                        }
                    }

                    foreach (var meal in dictionary.Value.GetMeals())
                    {
                        totalCalories += meal.Calories;
                        totalProtein += meal.Protein;
                        totalMeals += 1;
                        if (meal.Calories > biggestMeal)
                        {
                            biggestMealName = meal.Name;
                            biggestMeal = meal.Calories;
                        }
                    }

                }
                label11.Text = "Total Calories: " + totalCalories + " Calories";
                label12.Text = "Total Protein: " + totalProtein + " Protein";
                label15.Text = "Biggest Meal: \"" + biggestMealName + "\" " + biggestMeal + " Calories";

                label14.Text = "Total Weight Moved: " + totalWeightMoved;
                label13.Text = "Heaviest Weight Moved: \"" + heaviestWorkout + "\" " + heaviestWeight;


                // Graphing

                var plotModel = new PlotModel { Title = "Calorie Graph" };

                var barSeries = new RectangleBarSeries
                {
                    FillColor = OxyColors.ForestGreen,
                    StrokeColor = OxyColors.Black,
                    StrokeThickness = 1
                };

                int index = 0;
                var labels = new List<string>();

                this.SaveData();
                string json = File.ReadAllText(filePath + "/calendarData.json");
                this.LoadData(json);

                foreach (var day in backend.Days.Keys.OrderBy(d => d))
                {
                    int calories = backend.getDay(day).GetMeals().Sum(m => m.Calories);

                    // Bar from (x=index - 0.4) to (x=index + 0.4), y from 0 to calories
                    barSeries.Items.Add(new RectangleBarItem(index - 0.4, 0, index + 0.4, calories));
                    labels.Add(day.Date.ToString("M/d"));
                    index++;
                }

                // X axis (bottom) � treat x-coordinates as categories
                var xAxis = new CategoryAxis
                {
                    Position = AxisPosition.Bottom,
                    Angle = 45,
                    Title = "Date"
                };

                xAxis.LabelFormatter = (value) =>
                {
                    if (value >= 0 && value < labels.Count)
                    {
                        return labels[(int)value];
                    }
                    return string.Empty;
                };

                // Y axis (left)
                var yAxis = new LinearAxis
                {
                    Position = AxisPosition.Left,
                    Title = "Calories"
                };

                plotModel.Series.Add(barSeries);
                plotModel.Axes.Add(xAxis);
                plotModel.Axes.Add(yAxis);

                // Plot view
                var plotView = new PlotView
                {
                    Model = plotModel,
                    Dock = DockStyle.Fill
                };

                this.panel1.Controls.Add(plotView);

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save before exiting?", "Confirm Exit",
                                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.SaveData();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(this.backend, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath + "/calendarData.json", json);
        }

        private void FunFact()
        {
            int totalCalories = 0;
            int totalMeals = 0;
            int totalProtein = 0;
            int biggestMeal = 0;
            string biggestMealName = "";

            int totalWeightMoved = 0;
            int totalExercises = 0;
            int heaviestWeight = 0;
            string heaviestWorkout = "";
            foreach (var dictionary in backend.Days)
            {
                foreach (var exercise in dictionary.Value.GetExercises())
                {
                    totalWeightMoved += exercise.Weight;
                    totalExercises += 1;
                    if (exercise.Weight > heaviestWeight)
                    {
                        heaviestWeight = exercise.Weight;
                        heaviestWorkout = exercise.Name;
                    }
                }

                foreach (var meal in dictionary.Value.GetMeals())
                {
                    totalCalories += meal.Calories;
                    totalProtein += meal.Protein;
                    totalMeals += 1;
                    if (meal.Calories > biggestMeal)
                    {
                        biggestMealName = meal.Name;
                        biggestMeal = meal.Calories;
                    }
                }

            }

            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            double stat = 0;

            switch (randomNumber)
            {
                case 1:
                    stat = Math.Round(totalCalories / 1500.0, 2);
                    this.textBox1.Text = $"You have eaten {stat} costco rotisserie chicken(s) in calories!";
                    break;
                case 2:
                    stat = Math.Round(totalWeightMoved / 12000.0, 2);
                    this.textBox1.Text = $"You have lifted {stat} elephant(s)!";
                    break;
                case 3:
                    stat = Math.Round(totalProtein / 54.0, 2);
                    this.textBox1.Text = $"You have eaten {stat} jif peanutbutter(s) in protein!";
                    break;
                case 4:
                    stat = Math.Round(biggestMeal / 7726.0, 2);
                    this.textBox1.Text = $"Your bigest meal was {stat}% of the world record!";
                    break;
                case 5:
                    stat = Math.Ceiling(heaviestWeight / 18.0);
                    this.textBox1.Text = $"Your heaviest weight that you've lifted could be lifted by {stat} doung beetle(s)!";
                    break;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(string json)
        {
            calendarBackend? temp = JsonSerializer.Deserialize<calendarBackend>(json);
            if (temp != null) this.backend = temp;
        }
    }
}
