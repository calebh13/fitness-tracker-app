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
    public partial class NutritionForm: Form
    {
        public NutritionForm()
        {
            this.Text = "Nutrition Tracker";
            this.Size = new Size(400, (int)(Screen.PrimaryScreen!.WorkingArea.Height * 0.75));
            this.InitializeComponent();
            this.AddNewNutritionEntry(null, EventArgs.Empty);
        }

        private void AddNewNutritionEntry(object? sender, EventArgs e)
        {
            NutritionEntry entry = new NutritionEntry();
            entry.RemoveClicked += (s, ev) => RemoveNutritionEntry(entry);
            flowPanel.Controls.Add(entry);
        }

        private void RemoveNutritionEntry(NutritionEntry entry)
        {
            flowPanel.Controls.Remove(entry);
            entry.Dispose();
        }
    }
}
