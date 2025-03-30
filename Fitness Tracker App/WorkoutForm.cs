using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fitness_Tracker_App
{
    using Fitness_App_Engine;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class WorkoutForm : Form
    {
        private List<Exercise> exercises;
        int numExercises;

        public WorkoutForm()
        {
            ClientSize = new Size(400, (int)(Screen.PrimaryScreen!.WorkingArea.Height * 0.75));

            InitializeComponent();

            this.AddNewWorkoutEntry(null, EventArgs.Empty);
            this.exercises = new List<Exercise>();
        }

        private void AddNewWorkoutEntry(object? sender, EventArgs e)
        {
            WorkoutEntry entry = new WorkoutEntry();
            entry.RemoveClicked += (s, ev) => RemoveWorkoutEntry(entry);
            flowPanel.Controls.Add(entry);
            this.numExercises++;
        }

        private void RemoveWorkoutEntry(WorkoutEntry entry)
        {
            flowPanel.Controls.Remove(entry);
            entry.Dispose();
            this.numExercises--;
        }

        private void WorkoutForm_FormClosing(object sender, FormClosingEventArgs e)
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

        // Example save method
        private void SaveData()
        {
            // Serialize your data into an object
            foreach (var component in flowPanel.Controls)
            {
                if (component is WorkoutEntry entry)
                {
                    string? name = entry.Controls["nameBox"]!.Text;
                    int weight, sets, reps;
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
