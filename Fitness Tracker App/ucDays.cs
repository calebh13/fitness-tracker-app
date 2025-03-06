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
    public partial class ucDays : UserControl
    {
        string _day, date, weekday;
        Color outline;
        Color backing;


        public ucDays(string day, int dateRelation)//sorry this is confusing, negatvie means day has passed, positive means future date, 0 means current day
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox2.Hide();
            if(dateRelation < 0)
            {
                outline = Color.FromArgb(150, 150, 150);
                backing = Color.FromArgb(225, 225, 225);
            }
            else if(dateRelation > 0)
            {
                outline = this.BackColor;
                backing = this.panel1.BackColor;

            }
            else
            {
                backing = this.panel1.BackColor;
                outline = Color.FromArgb(0, 0, 0);

            }
            this.BackColor = outline;
            this.panel1.BackColor = backing;

        }

        public void dateHasPassed()
        {
            this.BackColor = Color.FromArgb(150, 150, 150);
            this.panel1.BackColor = Color.FromArgb(225, 225, 225);

        }
        public void currentDate()
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
        }
        public void futureDate()
        {

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

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(checkBox2.Checked == false)
            {
                checkBox2.Checked = true;
                this.BackColor = Color.FromArgb(100, 181, 246);
                this.panel1.BackColor = Color.FromArgb(227, 242, 253);
            }
            else 
            {
                checkBox2.Checked = false;
                this.BackColor = this.outline;
                this.panel1.BackColor = this.backing;
            }
        }
    }
}
