namespace Fitness_Tracker_App
{
    partial class newUserForm
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
            create_user = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // create_user
            // 
            create_user.Location = new Point(245, 11);
            create_user.Name = "create_user";
            create_user.Size = new Size(150, 46);
            create_user.TabIndex = 0;
            create_user.Text = "Create User";
            create_user.UseVisualStyleBackColor = true;
            create_user.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "username";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // newUserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 75);
            Controls.Add(textBox1);
            Controls.Add(create_user);
            Name = "newUserForm";
            Text = "New User Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_user;
        private TextBox textBox1;
    }
}