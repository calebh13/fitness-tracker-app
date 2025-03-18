using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fitness_Tracker_App
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class WorkoutForm : Form
    {
        public WorkoutForm()
        {
            this.Text = "Workout Tracker";
            this.Size = new Size(400, (int)(Screen.PrimaryScreen!.WorkingArea.Height * 0.75));

            flowPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                Dock = DockStyle.Top,
                Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 45),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            this.Controls.Add(flowPanel);

            addButton = new Button
            {
                Text = "Add Exercise",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            addButton.Click += AddNewWorkoutEntry;
            this.Controls.Add(addButton);
            this.AddNewWorkoutEntry(null, EventArgs.Empty);
        }

        private void AddNewWorkoutEntry(object? sender, EventArgs e)
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
