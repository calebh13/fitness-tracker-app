namespace Fitness_Tracker_App
{
    partial class WorkoutForm
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
            flowPanel.Paint += flowPanel_Paint;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Bottom;
            addButton.Location = new Point(0, 189);
            addButton.Name = "addButton";
            addButton.Size = new Size(274, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add Exercise";
            addButton.Click += AddNewWorkoutEntry;
            // 
            // WorkoutForm
            // 
            Controls.Add(flowPanel);
            Controls.Add(addButton);
            Name = "WorkoutForm";
            Text = "Workout Tracker";
            FormClosing += WorkoutForm_FormClosing;
            ResumeLayout(false);
        }
    }
}
