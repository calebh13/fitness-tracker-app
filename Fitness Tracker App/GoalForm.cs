using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness_App_Engine;

namespace Fitness_Tracker_App
{
    public partial class GoalForm : Form
    {
        private List<Exercise> exercises;
        private readonly DateTime date;

        public List<Exercise> Exercises { get => this.exercises; }
        public DateTime Date { get => this.date; }

        public GoalForm(DateTime date, List<Exercise> exercises)
        {
            ClientSize = new Size(400, (int)(Screen.PrimaryScreen!.WorkingArea.Height * 0.75));

            InitializeComponent();
            this.exercises = new List<Exercise>(exercises);
            foreach (Exercise exercise in exercises)
            {
                AddNewWorkoutEntry(null, EventArgs.Empty, exercise);
            }

            this.AddNewWorkoutEntry(null, EventArgs.Empty);
            this.date = date;
        }

        private void AddNewWorkoutEntry(object? sender, EventArgs e)
        {
            WorkoutEntry entry = new WorkoutEntry();
            entry.RemoveClicked += (s, ev) => RemoveWorkoutEntry(entry);
            flowPanel.Controls.Add(entry);
        }

        private void AddNewWorkoutEntry(object? sender, EventArgs e, Exercise exercise)
        {
            WorkoutEntry entry = new WorkoutEntry(exercise);
            entry.RemoveClicked += (s, ev) => RemoveWorkoutEntry(entry);
            flowPanel.Controls.Add(entry);
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

        private void GoalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save before exiting?", "Confirm Exit",
                                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveData();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveData()
        {
            this.exercises.Clear();
            foreach (var component in flowPanel.Controls)
            {
                if (component is WorkoutEntry entry)
                {
                    string? name = entry.Controls["nameBox"]!.Text;
                    int weight = 0, sets = 0, reps = 0;
                    if (!int.TryParse(entry.Controls["weightBox"]!.Text, out weight)) continue;
                    if (!int.TryParse(entry.Controls["setsBox"]!.Text, out sets)) continue;
                    if (!int.TryParse(entry.Controls["repsBox"]!.Text, out reps)) continue;
                    var exercise = new Exercise(name, weight, sets, reps);

                    var result = MessageBox.Show("Name weight sets reps: "
                        + exercise.Name + ", " + exercise.Weight + ", " + exercise.Sets + ", " + exercise.Reps);

                    this.exercises.Add(exercise);
                }
            }
        }
    }
}
