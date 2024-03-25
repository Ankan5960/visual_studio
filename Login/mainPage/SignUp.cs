using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainPage
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string newPassword=textBox3.Text;
            if(username ==string.Empty)
            {
                MessageBox.Show("Enter name");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Enter Password");
            }
            else if(newPassword == string.Empty)
            {
                MessageBox.Show("Enter Confirm Password");
            }
            else if (password == newPassword)
            {
                profile.Instance.SetUsername(username);
                profile.Instance.SetPassword(password);
                MessageBox.Show("Sign Up succesful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Pasword not matched");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = default;
                button3.Text = "H";
            }
            else
            {
                textBox3.PasswordChar = '*';
                button3.Text = "S";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = default;
                button2.Text = "H";
            }
            else
            {
                textBox2.PasswordChar = '*';
                button2.Text = "S";
            }       
        }
    }
}
