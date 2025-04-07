namespace Fitness_Tracker_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1174, 1170);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1158, 1116);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calendar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label7, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Controls.Add(label8, 6, 0);
            tableLayoutPanel1.Location = new Point(6, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1146, 40);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 1;
            label2.Text = "Sunday";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 2;
            label3.Text = "Monday";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 3;
            label4.Text = "Tuesday";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(492, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 32);
            label7.TabIndex = 6;
            label7.Text = "Wednesday";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 4;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(818, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 5;
            label6.Text = "Friday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(981, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 7;
            label8.Text = "Saturday";
            label8.Click += label8_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(478, 1048);
            button3.Name = "button3";
            button3.Size = new Size(170, 46);
            button3.TabIndex = 12;
            button3.Text = "Set Goal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(287, 1048);
            button2.Name = "button2";
            button2.Size = new Size(170, 46);
            button2.TabIndex = 11;
            button2.Text = "Add Nutrition";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(86, 1048);
            button1.Name = "button1";
            button1.Size = new Size(170, 46);
            button1.TabIndex = 10;
            button1.Text = "Add Workout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(962, 23);
            label10.Name = "label10";
            label10.Size = new Size(146, 32);
            label10.TabIndex = 9;
            label10.Text = "Next-Month";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 23);
            label9.Name = "label9";
            label9.Size = new Size(142, 32);
            label9.TabIndex = 8;
            label9.Text = "Prev-Month";
            label9.Click += label9_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(478, 23);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "Month";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(6, 138);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1149, 904);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.SizeChanged += flowLayoutPanel1_SizeChanged;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1158, 1116);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Statistics";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1158, 1116);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Leaderboard";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(121, 139);
            label11.Name = "label11";
            label11.Size = new Size(168, 32);
            label11.TabIndex = 0;
            label11.Text = "Total Calories: ";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(100, 252);
            label12.Name = "label12";
            label12.Size = new Size(160, 32);
            label12.TabIndex = 1;
            label12.Text = "Total Protein: ";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(638, 139);
            label13.Name = "label13";
            label13.Size = new Size(235, 32);
            label13.TabIndex = 2;
            label13.Text = "Total Weight Moved:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(638, 252);
            label14.Name = "label14";
            label14.Size = new Size(275, 32);
            label14.TabIndex = 3;
            label14.Text = "Heaviest Weight Moved:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(100, 361);
            label15.Name = "label15";
            label15.Size = new Size(158, 32);
            label15.TabIndex = 4;
            label15.Text = "Biggest Meal:";
            label15.Click += label15_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 1170);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Button button1;
        private Button button3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}
