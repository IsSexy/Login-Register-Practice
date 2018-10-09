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
    public partial class Homepage : UserControl
    {
        public Homepage()
        {
            InitializeComponent();
        }

        public Button RegisterButton
        {
            get { return btn_home_register; }
        }

        public Button LoginButton
        {
            get { return btn_home_login; }
        }

        public Label SuccessLabel
        {
            get { return lbl_reg_success; }
        }
    }
}
