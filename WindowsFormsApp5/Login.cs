using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            txt_login_password.UseSystemPasswordChar = true;
        }

        public Button CancelButton
        {
            get { return btn_login_cancel; }
        }

        public Button ConfirmButton
        {
            get { return btn_login_confirm; }
        }

        public string[] GetLoginInfo()
        {
            string[] tempinfo = new string[2];
            tempinfo[0] = txt_login_username.Text;
            tempinfo[1] = EncryptMe(txt_login_password.Text);
            txt_login_username.Text = "";
            txt_login_password.Text = "";
            return tempinfo;
        }

        public string EncryptMe(string pass)
        {
            using (System.Security.Cryptography.SHA256Managed hasher = new System.Security.Cryptography.SHA256Managed())
            {
                UTF8Encoding utf8e = new UTF8Encoding();
                byte[] newpass = hasher.ComputeHash(utf8e.GetBytes(pass));
                return Convert.ToBase64String(newpass);
            }
        }
    }
}
