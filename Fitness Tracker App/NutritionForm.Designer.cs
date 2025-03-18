namespace Fitness_Tracker_App
{
    partial class NutritionForm
    {
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button addButton;

        private void InitializeComponent()
        {
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel.Size = new System.Drawing.Size(580, 300);
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.WrapContents = false;

            // 
            // addButton
            // 
            this.addButton.Text = "Add Meal";
            this.addButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addButton.Height = 40;
            this.addButton.Click += new System.EventHandler(this.AddNewNutritionEntry);

            // 
            // WorkoutForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.addButton);
            this.Text = "Nutrition Tracker";

            this.ResumeLayout(false);
        }
    }
}