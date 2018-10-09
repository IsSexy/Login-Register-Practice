﻿using System;
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


    }
}
