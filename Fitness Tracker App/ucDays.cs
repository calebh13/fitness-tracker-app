using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker_App
{
    public partial class calendarDay : UserControl
    {
        private MainForm originalForm;
        string _day; //current date

        //default coloring
        Color outline;
        Color backing;


        public calendarDay(MainForm parentForm, string day, int dateRelation, int width, int height)//sorry this is confusing, negatvie means day has passed, positive means future date, 0 means current day
        {

            InitializeComponent();//default work
            originalForm = parentForm;
            _day = day;//the day it is -_o_-
            label1.Text = day;
            checkBox2.Hide();
            this.Width = width;
            this.Height = height;






            //day color based on relation to current date
            if (dateRelation < 0)//if the day has passed
            {
                outline = Color.FromArgb(150, 150, 150);
                backing = Color.FromArgb(225, 225, 225);
            }
            else if (dateRelation > 0)//future day
            {
                outline = this.BackColor;
                backing = this.panel1.BackColor;

            }
            else//current day
            {
                backing = this.panel1.BackColor;
                outline = Color.FromArgb(0, 0, 0);

            }
            this.BackColor = outline;
            this.panel1.BackColor = backing;
            this.button1.BackColor = backing;
            this.button2.BackColor = backing;

            //this.button2.BackColor = backing;


            //dynamic button and day size
            int buttonHeight = (height - 20) / 4;
            Font dynamic = new Font("Segoe UI", buttonHeight / 4);
            this.label1.Font = dynamic;
            this.button1.Height = buttonHeight;
            this.button1.Font = dynamic;
            this.button2.Height = buttonHeight;
            this.button2.Font = dynamic;


        }


        //public void dateHasPassed()
        //{
        //    this.BackColor = Color.FromArgb(150, 150, 150);
        //    this.panel1.BackColor = Color.FromArgb(225, 225, 225);

        //}
        //public void currentDate()
        //{
        //    this.BackColor = Color.FromArgb(0, 0, 0);
        //}
        //public void futureDate()
        //{

        //}

        public void hideButtons()//hide buttons, used for days that are from previous months
        {
            this.button1.Hide();
            this.button2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucDays_Load(object sender, EventArgs e)
        {

        }

        //what to do when a day is selected
        public void selectDay()
        {
            checkBox2.Checked = true;
            this.BackColor = Color.FromArgb(100, 181, 246);
            this.panel1.BackColor = Color.FromArgb(227, 242, 253);


            this.button1.BackColor = Color.FromArgb(227, 242, 253);
            this.button2.BackColor = Color.FromArgb(227, 242, 253);

            //this.button1.FlatAppearance.BorderColor = Color.FromArgb(100, 181, 246);
            originalForm.selectedDays.Add(this);

        }

        public void deselectDay()
        {
            checkBox2.Checked = false;
            this.BackColor = this.outline;
            this.panel1.BackColor = this.backing;
            this.button1.BackColor = this.backing;
            this.button2.BackColor = this.backing;
            originalForm.selectedDays.Remove(this);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.label1.Text != "")
            {
                if (checkBox2.Checked == false)
                {
                    selectDay();
                }
                else
                {
                    deselectDay();
                }
            }
        }
        public bool isSelected()
        {
            return checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public int getDayNumber()
        {
            return Convert.ToInt32(label1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = this.originalForm.getMonth();
            int year = this.originalForm.getYear();
            int day = this.getDayNumber();

            var formPopup = new WorkoutForm(new DateTime(month,year,day));
            formPopup.ShowDialog(this);
        }
    }
}