namespace Fitness_Tracker_App
{
    partial class NutritionForm
    {
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button addButton;

        private void InitializeComponent()
        {
            flowPanel = new FlowLayoutPanel();
            addButton = new Button();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Top;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 45);
            flowPanel.TabIndex = 0;
            flowPanel.WrapContents = false;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Bottom;
            addButton.Location = new Point(0, 204);
            addButton.Name = "addButton";
            addButton.Size = new Size(278, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add Meal";
            addButton.Click += AddNewNutritionEntry;
            // 
            // NutritionForm
            // 
            Controls.Add(flowPanel);
            Controls.Add(addButton);
            Name = "NutritionForm";
            Text = "Nutrition Tracker";
            FormClosing += NutritionForm_FormClosing;
            ResumeLayout(false);
        }
    }
}