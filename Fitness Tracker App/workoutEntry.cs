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
    using Fitness_App_Engine;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class WorkoutEntry : UserControl
    {
        public event EventHandler? RemoveClicked;

        public WorkoutEntry()
        {
            this.Size = new Size(300, 190);
            this.BorderStyle = BorderStyle.FixedSingle;

            int yOffset = 5;

            Label nameLabel = new Label { Text = "Name:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox nameBox = new TextBox { Name = "nameBox", Location = new Point(5, yOffset + 20), Width = 250 };
            yOffset += 50;

            // "Weight:" Label + Input Box
            Label weightLabel = new Label { Text = "Weight:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox weightBox = new TextBox { Name = "weightBox", Location = new Point(5, yOffset + 20), Width = 100 };
            yOffset += 50;

            // "Sets x Reps:" Label + Two Input Boxes
            Label setsRepsLabel = new Label { Text = "Sets x Reps:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox setsBox = new TextBox { Name = "setsBox", Location = new Point(5, yOffset + 20), Width = 50 };
            Label xLabel = new Label { Text = "x", Location = new Point(60, yOffset + 25), AutoSize = true };
            TextBox repsBox = new TextBox { Name = "repsBox", Location = new Point(80, yOffset + 20), Width = 50 };
            yOffset += 50;

            Button removeButton = new Button
            {
                Text = "Remove",
                Location = new Point(5, yOffset),
                Width = 100,
                Height = 30
            };

            removeButton.Click += (s, e) => RemoveClicked?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(nameLabel);
            this.Controls.Add(nameBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(weightBox);
            this.Controls.Add(setsRepsLabel);
            this.Controls.Add(setsBox);
            this.Controls.Add(xLabel);
            this.Controls.Add(repsBox);
            this.Controls.Add(removeButton);
        }

        public WorkoutEntry(Exercise exercise)
        {
            this.Size = new Size(300, 190);
            this.BorderStyle = BorderStyle.FixedSingle;

            int yOffset = 5;

            Label nameLabel = new Label { Text = "Name:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox nameBox = new TextBox { Name = "nameBox", Text = exercise.Name, Location = new Point(5, yOffset + 20), Width = 250 };
            yOffset += 50;

            // "Weight:" Label + Input Box
            Label weightLabel = new Label { Text = "Weight:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox weightBox = new TextBox { Name = "weightBox", Text = exercise.Weight.ToString(), Location = new Point(5, yOffset + 20), Width = 100 };
            yOffset += 50;

            // "Sets x Reps:" Label + Two Input Boxes
            Label setsRepsLabel = new Label { Text = "Sets x Reps:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox setsBox = new TextBox { Name = "setsBox", Text = exercise.Sets.ToString(), Location = new Point(5, yOffset + 20), Width = 50 };
            Label xLabel = new Label { Text = "x", Location = new Point(60, yOffset + 25), AutoSize = true };
            TextBox repsBox = new TextBox { Name = "repsBox", Text = exercise.Reps.ToString(), Location = new Point(80, yOffset + 20), Width = 50 };
            yOffset += 50;

            Button removeButton = new Button
            {
                Text = "Remove",
                Location = new Point(5, yOffset),
                Width = 100,
                Height = 30
            };

            removeButton.Click += (s, e) => RemoveClicked?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(nameLabel);
            this.Controls.Add(nameBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(weightBox);
            this.Controls.Add(setsRepsLabel);
            this.Controls.Add(setsBox);
            this.Controls.Add(xLabel);
            this.Controls.Add(repsBox);
            this.Controls.Add(removeButton);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }
    }

}
