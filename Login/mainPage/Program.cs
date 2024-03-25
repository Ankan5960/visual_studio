using mainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mainPage
{
    public class profile
    {
        private static profile _instance;

        private string username;
        private string password;    

        // Private constructor to prevent instantiation outside the class
        private profile()
        {
            this.password = string.Empty;
            this.username = string.Empty;   
        }

        // Public method to access the single instance of the class
        public static profile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new profile();
                }
                return _instance;
            }
        }

        public void SetUsername(string name)
        {
            username = name;
        }
        public void SetPassword(string pass)
        {
            password= pass;
        }

        public string GetUsername() { return username; } 
        public string GetPassword() { return password; }
    }

    internal static class Program
     {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                //profile A = new profile();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new page());
            }
        
    };
}

