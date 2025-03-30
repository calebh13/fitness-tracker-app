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
            /*
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Top;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(600, 300);
            flowPanel.TabIndex = 0;
            flowPanel.WrapContents = false;
            */
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Top;
            flowPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 45);
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            // 
            // addButton
            // 
            /*
            addButton.Dock = DockStyle.Bottom;
            addButton.Location = new Point(0, 360);
            addButton.Name = "addButton";
            addButton.Size = new Size(600, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add Exercise";
            addButton.Click += AddNewWorkoutEntry;
            */
            addButton.Text = "Add Exercise";
            addButton.Dock = DockStyle.Bottom;
            addButton.Height = 40;
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
