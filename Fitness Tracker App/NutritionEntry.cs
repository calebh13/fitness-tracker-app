using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness_App_Engine;

namespace Fitness_Tracker_App
{
    public partial class NutritionEntry: UserControl
    {
        public event EventHandler? RemoveClicked;

        public NutritionEntry()
        {
            this.Size = new Size(300, 190);
            this.BorderStyle = BorderStyle.FixedSingle;

            int yOffset = 5;

            Label nameLabel = new Label { Text = "Name:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox nameBox = new TextBox { Name = "nameBox", Location = new Point(5, yOffset + 20), Width = 250 };
            yOffset += 50;

            // "Weight:" Label + Input Box
            Label caloriesLabel = new Label { Text = "Calories:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox caloriesBox = new TextBox { Name = "caloriesBox", Location = new Point(5, yOffset + 20), Width = 100 };
            yOffset += 50;

            // "Sets x Reps:" Label + Two Input Boxes
            Label proteinLabel = new Label { Text = "Protein:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox proteinBox = new TextBox { Name = "proteinBox", Location = new Point(5, yOffset + 20), Width = 50 };
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
            this.Controls.Add(caloriesLabel);
            this.Controls.Add(caloriesBox);
            this.Controls.Add(proteinLabel);
            this.Controls.Add(proteinBox);
            this.Controls.Add(removeButton);
        }

        public NutritionEntry(Meal meal)
        {
            this.Size = new Size(300, 190);
            this.BorderStyle = BorderStyle.FixedSingle;

            int yOffset = 5;

            Label nameLabel = new Label { Text = "Name:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox nameBox = new TextBox { Name = "nameBox", Text = meal.Name, Location = new Point(5, yOffset + 20), Width = 250 };
            yOffset += 50;

            // "Weight:" Label + Input Box
            Label caloriesLabel = new Label { Text = "Calories:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox caloriesBox = new TextBox { Name = "caloriesBox", Text = meal.Calories.ToString(), Location = new Point(5, yOffset + 20), Width = 100 };
            yOffset += 50;

            // "Sets x Reps:" Label + Two Input Boxes
            Label proteinLabel = new Label { Text = "Protein:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox proteinBox = new TextBox { Name = "proteinBox", Text = meal.Protein.ToString(), Location = new Point(5, yOffset + 20), Width = 50 };
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
            this.Controls.Add(caloriesLabel);
            this.Controls.Add(caloriesBox);
            this.Controls.Add(proteinLabel);
            this.Controls.Add(proteinBox);
            this.Controls.Add(removeButton);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
