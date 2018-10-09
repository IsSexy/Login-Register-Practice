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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
            txt_reg_password.UseSystemPasswordChar = true;
        }

        public Button CancelButton
        {
            get { return btn_reg_cancel; }
        }

        public Button LoginButton
        {
            get { return btn_reg_login; }
        }

        public Button ConfirmButton
        {
            get { return btn_reg_confirm; }
        }

        public string[] GetRegisterInfo()
        {
            string[] tempinfo = new string[4];
            tempinfo[0] = txt_reg_username.Text;
            tempinfo[1] = EncryptMe(txt_reg_password.Text);
            tempinfo[2] = txt_reg_name.Text;
            tempinfo[3] = txt_reg_email.Text;
            txt_reg_username.Text = "";
            txt_reg_password.Text = "";
            txt_reg_name.Text = "";
            txt_reg_email.Text = "";
            return tempinfo;
        }

        private void btn_reg_login_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
