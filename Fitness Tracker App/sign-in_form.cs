using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker_App
{
    public partial class sign_in_form : Form
    {
        List<string> userNames;
        public sign_in_form()
        {
            InitializeComponent();
            this.sign_in.BackColor = Color.LightGray;
            userNames = loadUserNamesFromFile();
            updateDropdown();
        }

        public List<string> loadUserNamesFromFile()
        {
            Directory.CreateDirectory("./users/");
            string[] users = Directory.GetDirectories("./users/");
            List<string> newUsernames = new List<string>();
            foreach (string str in users)
            {
                newUsernames.Add(str.Substring(8));
            }
            return newUsernames;
        }

        public List<string> getAllUserNames()
        {
            return userNames;
        }

        public void updateDropdown()
        {
            comboBox1.Items.Clear();
            foreach(string str in this.userNames)
            {
                comboBox1.Items.Add(str);
            }
        }

        public void addUserName(string newUsername)
        {
            this.userNames.Add(newUsername);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            if (this.sign_in.BackColor != Color.LightGray)
            {
                var formPopup = new MainForm(this.comboBox1.Text);
                this.Hide();
                formPopup.ShowDialog(this);
                this.Close();
            }
        }

        private void newUser_Click(object? sender, EventArgs e)
        {
            var formPopup = new newUserForm(this);
            formPopup.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.TabIndex == 0)
            {
                this.sign_in.BackColor = Color.LightGray;
            }
            else
            {
                this.sign_in.BackColor = Color.White;
            }
        }
    }
}
