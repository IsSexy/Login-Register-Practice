using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Runner
    {
        static Form1 newform = new Form1();
        Login log = new Login();
        Register reg = new Register();

        public Runner()
        {
        }

        public Runner(Form1 newform1)
        {
            newform = newform1;
        }

        public void RegToLogin()
        {
            
        }
    }
}
