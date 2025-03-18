namespace Fitness_Tracker_App
{
    partial class NutritionEntry
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
            caloriesLabel = new Label();
            caloriesBox = new TextBox();
            macrosLabel = new Label();
            macrosBox = new TextBox();
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
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Location = new Point(5, 55);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(75, 25);
            caloriesLabel.TabIndex = 2;
            caloriesLabel.Text = "calories:";
            // 
            // caloriesBox
            // 
            caloriesBox.Location = new Point(5, 75);
            caloriesBox.Name = "caloriesBox";
            caloriesBox.Size = new Size(100, 31);
            caloriesBox.TabIndex = 3;
            // 
            // macrosLabel
            // 
            macrosLabel.AutoSize = true;
            macrosLabel.Location = new Point(5, 105);
            macrosLabel.Name = "macrosLabel";
            macrosLabel.Size = new Size(74, 25);
            macrosLabel.TabIndex = 4;
            macrosLabel.Text = "Macros:";
            // 
            // macrosBox
            // 
            macrosBox.Location = new Point(5, 125);
            macrosBox.Name = "macrosBox";
            macrosBox.Size = new Size(50, 31);
            macrosBox.TabIndex = 5;
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
            // NutritionEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(caloriesLabel);
            Controls.Add(caloriesBox);
            Controls.Add(macrosLabel);
            Controls.Add(macrosBox);
            Controls.Add(removeButton);
            Name = "NutritionEntry";
            Size = new Size(569, 363);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.TextBox caloriesBox;
        private System.Windows.Forms.Label macrosLabel;
        private System.Windows.Forms.TextBox macrosBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox repsBox;
        private System.Windows.Forms.Button removeButton;
    }
}
