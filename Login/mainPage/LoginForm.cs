using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mainPage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string defUsername = profile.Instance.GetUsername();
            string defPassword = profile.Instance.GetPassword();
           
            string password = LoginPasswordTextBox.Text;
            string name = UsernameTextBox.Text;
            if (name == string.Empty)
            {
                MessageBox.Show("Enter name");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Enter Password");
            }
            else if (password == defPassword && name == defUsername)
            {
                MessageBox.Show("Login succesful");
                this.Close();
            }
            else if (name != defUsername)
            {
                MessageBox.Show("Worng Username");
            }
            else
            {
                MessageBox.Show("Worng Password");
            }
              

        }
        private void Username_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginPasswordTextBox.PasswordChar == '*')
            {
                LoginPasswordTextBox.PasswordChar = default;
                ShowHideButton.Text = "H";
            }
            else
            {
                LoginPasswordTextBox.PasswordChar = '*';
                ShowHideButton.Text = "S";
            }
        }
    }
}
