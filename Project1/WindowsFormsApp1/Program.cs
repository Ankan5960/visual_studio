using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Profile
    {
        private string username;
        private string password;

        Profile()
        {
            Profile A= new Profile();
        }
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetUsername()
        {
            return this.username;
        }
        public string GetPassword() 
        { 
            return this.password;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Profile A;
            A.SetUsername = "Ankan";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
