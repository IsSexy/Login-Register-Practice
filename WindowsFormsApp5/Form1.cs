using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Runner runmeh;
        Homepage home = new Homepage();
        Register reg = new Register();
        Login log = new Login();
        UsersDataSet userDataSet = new UsersDataSet();
        UsersDataSetTableAdapters.tbl_UsersTableAdapter userTableAdapter = 
            new UsersDataSetTableAdapters.tbl_UsersTableAdapter();
        

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            home = new Homepage();

            home.RegisterButton.Click += new EventHandler(register_Click);
            home.LoginButton.Click += new EventHandler(login_Click);
            log.CancelButton.Click += new EventHandler(LoginCancel_Click);
            reg.CancelButton.Click += new EventHandler(RegisterCancel_Click);
            reg.LoginButton.Click += new EventHandler(RegisterToLogin_Click);
            reg.ConfirmButton.Click += new EventHandler(RegisterConfirm_Click);

            this.Controls.Add(home);
            home.Location = new Point(0, 0);
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Controls.Add(reg);
            reg.Location = new Point(0, 0);
            home.Visible = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Controls.Add(log);
            log.Location = new Point(0, 0);
            home.Visible = false;
        }

        private void LoginCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(log);
            home.Visible = true;
        }

        private void RegisterCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(reg);
            home.Visible = true;
        }

        private void RegisterToLogin_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(reg);
            this.Controls.Add(log);
        }

        private void RegisterConfirm_Click(object sender, EventArgs e)
        {
            string[] tempinfo = new string[4];
            tempinfo = reg.GetRegisterInfo();
            userTableAdapter.InsertQuery(tempinfo[0], tempinfo[1], tempinfo[2], tempinfo[3]);
            this.Controls.Remove(reg);
            userTableAdapter.FillBy(userDataSet.tbl_Users, tempinfo[0]);
            home.SuccessLabel.Text = "";
            home.SuccessLabel.Text = "Successfully Registered: \n";
            home.SuccessLabel.Text += string.Format("User ID: {0}\nUsername: {1}\nName: {2}\nPassword: {3}", 
                                                                                                  userDataSet.tbl_Users[0]["UserID"],
                                                                                                  userDataSet.tbl_Users[0]["Username"],
                                                                                                  userDataSet.tbl_Users[0]["Name"],
                                                                                                  userDataSet.tbl_Users[0]["Password"]);
            home.SuccessLabel.Visible = true;
            home.Visible = true;
        }
    }
}
