using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string defUsername = "Ankan Maity";
            string defPassword = "Ankan5900";

            string password = textBox2.Text;
            string name = textBox1.Text;
            if(password==defPassword && name == defUsername)
            {
                MessageBox.Show(name + " Login succesful");
            }
            else if(name != defUsername)
            {
                MessageBox.Show("Worng Username");
            }
            else
            {
                MessageBox.Show("Worng Password");
            }
            
        }
    }
}
