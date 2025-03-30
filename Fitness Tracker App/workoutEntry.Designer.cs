namespace Fitness_Tracker_App
{
    partial class WorkoutEntry
    {
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
            nameLabel = new Label();
            nameBox = new TextBox();
            weightLabel = new Label();
            weightBox = new TextBox();
            setsRepsLabel = new Label();
            setsBox = new TextBox();
            xLabel = new Label();
            repsBox = new TextBox();
            removeButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(5, 5);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(5, 25);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(250, 31);
            nameBox.TabIndex = 1;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(5, 55);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(72, 25);
            weightLabel.TabIndex = 2;
            weightLabel.Text = "Weight:";
            // 
            // weightBox
            // 
            weightBox.Location = new Point(5, 75);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(100, 31);
            weightBox.TabIndex = 3;
            // 
            // setsRepsLabel
            // 
            setsRepsLabel.AutoSize = true;
            setsRepsLabel.Location = new Point(5, 105);
            setsRepsLabel.Name = "setsRepsLabel";
            setsRepsLabel.Size = new Size(105, 25);
            setsRepsLabel.TabIndex = 4;
            setsRepsLabel.Text = "Sets x Reps:";
            // 
            // setsBox
            // 
            setsBox.Location = new Point(5, 125);
            setsBox.Name = "setsBox";
            setsBox.Size = new Size(50, 31);
            setsBox.TabIndex = 5;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(60, 130);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(20, 25);
            xLabel.TabIndex = 6;
            xLabel.Text = "x";
            // 
            // repsBox
            // 
            repsBox.Location = new Point(86, 125);
            repsBox.Name = "repsBox";
            repsBox.Size = new Size(50, 31);
            repsBox.TabIndex = 7;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(5, 160);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 30);
            removeButton.TabIndex = 8;
            removeButton.Text = "Remove";
            removeButton.Click += removeButton_Click;
            // 
            // WorkoutEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(weightLabel);
            Controls.Add(weightBox);
            Controls.Add(setsRepsLabel);
            Controls.Add(setsBox);
            Controls.Add(xLabel);
            Controls.Add(repsBox);
            Controls.Add(removeButton);
            Name = "WorkoutEntry";
            Size = new Size(300, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameBox;
        private Label weightLabel;
        private TextBox weightBox;
        private Label setsRepsLabel;
        private TextBox setsBox;
        private Label xLabel;
        private TextBox repsBox;
        private Button removeButton;
    }
}