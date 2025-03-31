using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker_App
{
    public partial class GoalForm : Form
    {
        public GoalForm()
        {
            ClientSize = new Size(400, (int)(Screen.PrimaryScreen!.WorkingArea.Height * 0.75));
            InitializeComponent();
            this.addGoalButton_Click(null, EventArgs.Empty);

        }

        private void addGoalButton_Click(object? sender, EventArgs e)
        {
            WorkoutEntry entry = new WorkoutEntry();
            entry.RemoveClicked += (s, ev) => RemoveWorkoutEntry(entry);
            flowPanel.Controls.Add(entry);
        }

        private void RemoveWorkoutEntry(WorkoutEntry entry)
        {
            flowPanel.Controls.Remove(entry);
            entry.Dispose();
        }
    }
}
