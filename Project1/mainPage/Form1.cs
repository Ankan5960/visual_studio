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
    
    public partial class page : Form
    {
        
        public page()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginForm anotherForm = new LoginForm();
            anotherForm.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp anotherForm = new SignUp();
            anotherForm.Show();
        }

        private void MainPage_Load(object sender, EventArgs e) { }
       
    }

    
}
