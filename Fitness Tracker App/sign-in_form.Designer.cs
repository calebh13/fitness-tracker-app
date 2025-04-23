namespace Fitness_Tracker_App
{
    partial class sign_in_form
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
            textBox1 = new TextBox();
            Title = new Label();
            comboBox1 = new ComboBox();
            sign_in = new Button();
            newUserButton = new Button();
            remove_user = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 25F);
            Title.Location = new Point(355, 47);
            Title.Name = "Title";
            Title.Size = new Size(425, 89);
            Title.TabIndex = 1;
            Title.Text = "Select A User";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(368, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(376, 40);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // sign_in
            // 
            sign_in.Font = new Font("Segoe UI", 10F);
            sign_in.Location = new Point(793, 160);
            sign_in.Name = "sign_in";
            sign_in.Size = new Size(150, 46);
            sign_in.TabIndex = 4;
            sign_in.Text = "Sign-In";
            sign_in.UseVisualStyleBackColor = true;
            sign_in.Click += sign_in_Click;
            // 
            // newUserButton
            // 
            newUserButton.Location = new Point(446, 248);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(200, 46);
            newUserButton.TabIndex = 5;
            newUserButton.Text = "Create New User";
            newUserButton.UseVisualStyleBackColor = true;
            newUserButton.Click += newUser_Click;
            // 
            // remove_user
            // 
            remove_user.Font = new Font("Segoe UI", 10F);
            remove_user.Location = new Point(116, 160);
            remove_user.Name = "remove_user";
            remove_user.Size = new Size(191, 46);
            remove_user.TabIndex = 6;
            remove_user.Text = "Remove User";
            remove_user.UseVisualStyleBackColor = true;
            remove_user.Click += remove_user_Click_1;
            // 
            // sign_in_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 348);
            Controls.Add(remove_user);
            Controls.Add(newUserButton);
            Controls.Add(sign_in);
            Controls.Add(comboBox1);
            Controls.Add(Title);
            Controls.Add(textBox1);
            Name = "sign_in_form";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Sign-in Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Title;
        private ComboBox comboBox1;
        private Button sign_in;
        private Button newUserButton;
        private Button remove_user;
    }
}