namespace WindowsFormsApp5
{
    partial class Homepage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_main_welcome = new System.Windows.Forms.Label();
            this.btn_home_register = new System.Windows.Forms.Button();
            this.btn_home_login = new System.Windows.Forms.Button();
            this.lbl_reg_success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_main_welcome
            // 
            this.lbl_main_welcome.AutoSize = true;
            this.lbl_main_welcome.BackColor = System.Drawing.Color.DimGray;
            this.lbl_main_welcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_main_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lbl_main_welcome.ForeColor = System.Drawing.Color.Black;
            this.lbl_main_welcome.Location = new System.Drawing.Point(115, 15);
            this.lbl_main_welcome.Name = "lbl_main_welcome";
            this.lbl_main_welcome.Size = new System.Drawing.Size(205, 53);
            this.lbl_main_welcome.TabIndex = 5;
            this.lbl_main_welcome.Text = "Welcome";
            // 
            // btn_home_register
            // 
            this.btn_home_register.BackColor = System.Drawing.Color.Red;
            this.btn_home_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home_register.Location = new System.Drawing.Point(265, 146);
            this.btn_home_register.Name = "btn_home_register";
            this.btn_home_register.Size = new System.Drawing.Size(75, 23);
            this.btn_home_register.TabIndex = 4;
            this.btn_home_register.Text = "Register";
            this.btn_home_register.UseVisualStyleBackColor = false;
            // 
            // btn_home_login
            // 
            this.btn_home_login.BackColor = System.Drawing.Color.Red;
            this.btn_home_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home_login.Location = new System.Drawing.Point(95, 146);
            this.btn_home_login.Name = "btn_home_login";
            this.btn_home_login.Size = new System.Drawing.Size(75, 23);
            this.btn_home_login.TabIndex = 3;
            this.btn_home_login.Text = "Login";
            this.btn_home_login.UseVisualStyleBackColor = false;
            // 
            // lbl_reg_success
            // 
            this.lbl_reg_success.AutoSize = true;
            this.lbl_reg_success.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reg_success.ForeColor = System.Drawing.Color.Green;
            this.lbl_reg_success.Location = new System.Drawing.Point(17, 175);
            this.lbl_reg_success.Name = "lbl_reg_success";
            this.lbl_reg_success.Size = new System.Drawing.Size(35, 13);
            this.lbl_reg_success.TabIndex = 6;
            this.lbl_reg_success.Text = "label1";
            this.lbl_reg_success.Visible = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.lbl_reg_success);
            this.Controls.Add(this.lbl_main_welcome);
            this.Controls.Add(this.btn_home_register);
            this.Controls.Add(this.btn_home_login);
            this.Name = "Homepage";
            this.Size = new System.Drawing.Size(430, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_main_welcome;
        private System.Windows.Forms.Button btn_home_register;
        private System.Windows.Forms.Button btn_home_login;
        private System.Windows.Forms.Label lbl_reg_success;
    }
}
