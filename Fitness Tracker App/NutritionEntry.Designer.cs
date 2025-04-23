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
            proteinLabel = new Label();
            proteinBox = new TextBox();
            removeButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 6);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(6, 32);
            nameBox.Margin = new Padding(4, 4, 4, 4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(324, 39);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Location = new Point(6, 70);
            caloriesLabel.Margin = new Padding(4, 0, 4, 0);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(99, 32);
            caloriesLabel.TabIndex = 2;
            caloriesLabel.Text = "calories:";
            // 
            // caloriesBox
            // 
            caloriesBox.Location = new Point(6, 96);
            caloriesBox.Margin = new Padding(4, 4, 4, 4);
            caloriesBox.Name = "caloriesBox";
            caloriesBox.Size = new Size(129, 39);
            caloriesBox.TabIndex = 3;
            // 
            // proteinLabel
            // 
            proteinLabel.AutoSize = true;
            proteinLabel.Location = new Point(6, 134);
            proteinLabel.Margin = new Padding(4, 0, 4, 0);
            proteinLabel.Name = "proteinLabel";
            proteinLabel.Size = new Size(96, 32);
            proteinLabel.TabIndex = 4;
            proteinLabel.Text = "Macros:";
            // 
            // proteinBox
            // 
            proteinBox.Location = new Point(6, 160);
            proteinBox.Margin = new Padding(4, 4, 4, 4);
            proteinBox.Name = "proteinBox";
            proteinBox.Size = new Size(64, 39);
            proteinBox.TabIndex = 5;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(6, 205);
            removeButton.Margin = new Padding(4, 4, 4, 4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(130, 38);
            removeButton.TabIndex = 8;
            removeButton.Text = "Remove";
            removeButton.Click += removeButton_Click;
            // 
            // NutritionEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(caloriesLabel);
            Controls.Add(caloriesBox);
            Controls.Add(proteinLabel);
            Controls.Add(proteinBox);
            Controls.Add(removeButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NutritionEntry";
            Size = new Size(740, 465);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.TextBox caloriesBox;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.TextBox proteinBox;
        private System.Windows.Forms.Button removeButton;
    }
}
