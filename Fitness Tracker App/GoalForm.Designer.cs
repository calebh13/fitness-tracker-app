namespace Fitness_Tracker_App
{
    partial class GoalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            addGoalButton = new Button();
            flowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // addGoalButton
            // 
            addGoalButton.Dock = DockStyle.Bottom;
            addGoalButton.Location = new Point(0, 416);
            addGoalButton.Name = "addGoalButton";
            addGoalButton.Size = new Size(800, 34);
            addGoalButton.TabIndex = 0;
            addGoalButton.Text = "Add Goal";
            addGoalButton.UseMnemonic = false;
            addGoalButton.UseVisualStyleBackColor = true;
            addGoalButton.Click += addGoalButton_Click;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Top;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 45);
            flowPanel.TabIndex = 1;
            flowPanel.WrapContents = false;
            // 
            // GoalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPanel);
            Controls.Add(addGoalButton);
            Name = "GoalForm";
            Text = "GoalForm";
            FormClosing += GoalForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button addGoalButton;
        private FlowLayoutPanel flowPanel;
    }
}