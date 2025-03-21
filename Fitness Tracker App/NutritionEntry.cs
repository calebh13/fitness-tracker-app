﻿using System;
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
    public partial class NutritionEntry: UserControl
    {
        public event EventHandler? RemoveClicked;

        public NutritionEntry()
        {
            this.Size = new Size(300, 190);
            this.BorderStyle = BorderStyle.FixedSingle;

            int yOffset = 5;

            Label nameLabel = new Label { Text = "Name:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox nameBox = new TextBox { Location = new Point(5, yOffset + 20), Width = 250 };
            yOffset += 50;

            // "Weight:" Label + Input Box
            Label caloriesLabel = new Label { Text = "Calories:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox caloriesBox = new TextBox { Location = new Point(5, yOffset + 20), Width = 100 };
            yOffset += 50;

            // "Sets x Reps:" Label + Two Input Boxes
            Label macrosLabel = new Label { Text = "Macros:", Location = new Point(5, yOffset), AutoSize = true };
            TextBox macrosBox = new TextBox { Location = new Point(5, yOffset + 20), Width = 50 };
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
            this.Controls.Add(macrosLabel);
            this.Controls.Add(macrosBox);
            this.Controls.Add(removeButton);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
