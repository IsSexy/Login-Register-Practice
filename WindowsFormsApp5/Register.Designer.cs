namespace WindowsFormsApp5
{
    partial class Register
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
            this.txt_reg_username = new System.Windows.Forms.TextBox();
            this.txt_reg_name = new System.Windows.Forms.TextBox();
            this.txt_reg_password = new System.Windows.Forms.TextBox();
            this.txt_reg_email = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_reg_title = new System.Windows.Forms.Label();
            this.btn_reg_confirm = new System.Windows.Forms.Button();
            this.btn_reg_login = new System.Windows.Forms.Button();
            this.btn_reg_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_reg_username
            // 
            this.txt_reg_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_reg_username.Location = new System.Drawing.Point(190, 105);
            this.txt_reg_username.Name = "txt_reg_username";
            this.txt_reg_username.Size = new System.Drawing.Size(100, 20);
            this.txt_reg_username.TabIndex = 0;
            // 
            // txt_reg_name
            // 
            this.txt_reg_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_reg_name.Location = new System.Drawing.Point(190, 157);
            this.txt_reg_name.Name = "txt_reg_name";
            this.txt_reg_name.Size = new System.Drawing.Size(100, 20);
            this.txt_reg_name.TabIndex = 2;
            // 
            // txt_reg_password
            // 
            this.txt_reg_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_reg_password.Location = new System.Drawing.Point(190, 131);
            this.txt_reg_password.Name = "txt_reg_password";
            this.txt_reg_password.Size = new System.Drawing.Size(100, 20);
            this.txt_reg_password.TabIndex = 1;
            // 
            // txt_reg_email
            // 
            this.txt_reg_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_reg_email.Location = new System.Drawing.Point(190, 183);
            this.txt_reg_email.Name = "txt_reg_email";
            this.txt_reg_email.Size = new System.Drawing.Size(100, 20);
            this.txt_reg_email.TabIndex = 3;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(117, 108);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(67, 13);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(117, 134);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(65, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(135, 160);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(135, 186);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 13);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_reg_title
            // 
            this.lbl_reg_title.AutoSize = true;
            this.lbl_reg_title.BackColor = System.Drawing.Color.DimGray;
            this.lbl_reg_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_reg_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_reg_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_reg_title.Location = new System.Drawing.Point(120, 17);
            this.lbl_reg_title.Name = "lbl_reg_title";
            this.lbl_reg_title.Size = new System.Drawing.Size(193, 53);
            this.lbl_reg_title.TabIndex = 8;
            this.lbl_reg_title.Text = "Register";
            // 
            // btn_reg_confirm
            // 
            this.btn_reg_confirm.BackColor = System.Drawing.Color.Red;
            this.btn_reg_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg_confirm.Location = new System.Drawing.Point(48, 239);
            this.btn_reg_confirm.Name = "btn_reg_confirm";
            this.btn_reg_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_confirm.TabIndex = 9;
            this.btn_reg_confirm.Text = "Confirm";
            this.btn_reg_confirm.UseVisualStyleBackColor = false;
            // 
            // btn_reg_login
            // 
            this.btn_reg_login.BackColor = System.Drawing.Color.Red;
            this.btn_reg_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg_login.Location = new System.Drawing.Point(181, 239);
            this.btn_reg_login.Name = "btn_reg_login";
            this.btn_reg_login.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_login.TabIndex = 10;
            this.btn_reg_login.Text = "Login";
            this.btn_reg_login.UseVisualStyleBackColor = false;
            // 
            // btn_reg_cancel
            // 
            this.btn_reg_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_reg_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg_cancel.Location = new System.Drawing.Point(314, 239);
            this.btn_reg_cancel.Name = "btn_reg_cancel";
            this.btn_reg_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_cancel.TabIndex = 11;
            this.btn_reg_cancel.Text = "Cancel";
            this.btn_reg_cancel.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btn_reg_cancel);
            this.Controls.Add(this.btn_reg_login);
            this.Controls.Add(this.btn_reg_confirm);
            this.Controls.Add(this.lbl_reg_title);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_reg_email);
            this.Controls.Add(this.txt_reg_password);
            this.Controls.Add(this.txt_reg_name);
            this.Controls.Add(this.txt_reg_username);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(430, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_reg_username;
        private System.Windows.Forms.TextBox txt_reg_name;
        private System.Windows.Forms.TextBox txt_reg_password;
        private System.Windows.Forms.TextBox txt_reg_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_reg_title;
        private System.Windows.Forms.Button btn_reg_confirm;
        private System.Windows.Forms.Button btn_reg_login;
        private System.Windows.Forms.Button btn_reg_cancel;
    }
}
