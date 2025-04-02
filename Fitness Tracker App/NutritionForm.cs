using Fitness_App_Engine;
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
    public partial class NutritionForm : Form
    {
        private readonly DateTime date;
        private List<Meal> meals;

        public DateTime Date { get => this.date.Date; }
        public List<Meal> Meals { get => this.meals; }

        public NutritionForm(DateTime date, List<Meal> meals)
        {
            this.meals = meals;
            this.Text = "Nutrition Tracker";
            this.ClientSize = new Size(400, (int)(Screen.PrimaryScreen!.WorkingArea.Height * 0.75));
            this.date = date;
            this.InitializeComponent();
            foreach (Meal meal in meals)
            {
                this.AddNewNutritionEntry(null, EventArgs.Empty, meal);
            }
            this.AddNewNutritionEntry(null, EventArgs.Empty);
        }

        private void AddNewNutritionEntry(object? sender, EventArgs e)
        {
            NutritionEntry entry = new NutritionEntry() { Name = "NutritionEntry" };
            entry.RemoveClicked += (s, ev) => RemoveNutritionEntry(entry);
            flowPanel.Controls.Add(entry);
        }

        private void AddNewNutritionEntry(object? sender, EventArgs e, Meal meal)
        {
            NutritionEntry entry = new NutritionEntry(meal);
            entry.RemoveClicked += (s, ev) => RemoveNutritionEntry(entry);
            flowPanel.Controls.Add(entry);
        }

        private void RemoveNutritionEntry(NutritionEntry entry)
        {
            flowPanel.Controls.Remove(entry);
            entry.Dispose();
        }

        private void NutritionForm_FormClosing(object sender, FormClosingEventArgs e)
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
            foreach (var component in flowPanel.Controls)
            {
                if (component is NutritionEntry entry)
                {
                    string? name = entry.Controls["nameBox"]!.Text;
                    int calories = 0, protein = 0;
                    if (!int.TryParse(entry.Controls["caloriesBox"]!.Text, out calories)) continue;
                    if (!int.TryParse(entry.Controls["proteinBox"]!.Text, out protein)) continue;
                    var meal = new Meal(name, calories, protein);

                    var result = MessageBox.Show("Name weight sets reps: "
                        + meal.Name + ", " + meal.Calories + ", " + meal.Protein);

                    this.meals.Add(meal);
                }
            }
        }
    }
}