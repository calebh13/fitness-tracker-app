using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker_App
{
    public partial class newUserForm : Form
    {
        sign_in_form parentForm;
        public newUserForm(sign_in_form newParentForm)
        {
            parentForm = newParentForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "username" || parentForm.getAllUserNames().Contains(textBox1.Text))
            {

            }
            else
            {
                parentForm.addUserName(textBox1.Text);
                parentForm.updateDropdown();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
