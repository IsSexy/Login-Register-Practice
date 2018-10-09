namespace WindowsFormsApp5
{
    partial class Login
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
            this.lbl_login_title = new System.Windows.Forms.Label();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.btn_login_confirm = new System.Windows.Forms.Button();
            this.btn_login_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_title
            // 
            this.lbl_login_title.AutoSize = true;
            this.lbl_login_title.BackColor = System.Drawing.Color.DimGray;
            this.lbl_login_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_login_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_login_title.Location = new System.Drawing.Point(151, 17);
            this.lbl_login_title.Name = "lbl_login_title";
            this.lbl_login_title.Size = new System.Drawing.Size(135, 53);
            this.lbl_login_title.TabIndex = 0;
            this.lbl_login_title.Text = "Login";
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(122, 130);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(67, 13);
            this.lbl_login_username.TabIndex = 1;
            this.lbl_login_username.Text = "Username:";
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(124, 156);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(65, 13);
            this.lbl_login_password.TabIndex = 2;
            this.lbl_login_password.Text = "Password:";
            // 
            // txt_login_username
            // 
            this.txt_login_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_login_username.Location = new System.Drawing.Point(195, 127);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(100, 20);
            this.txt_login_username.TabIndex = 0;
            // 
            // txt_login_password
            // 
            this.txt_login_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_login_password.Location = new System.Drawing.Point(195, 153);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(100, 20);
            this.txt_login_password.TabIndex = 1;
            // 
            // btn_login_confirm
            // 
            this.btn_login_confirm.BackColor = System.Drawing.Color.Red;
            this.btn_login_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_confirm.Location = new System.Drawing.Point(103, 212);
            this.btn_login_confirm.Name = "btn_login_confirm";
            this.btn_login_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_login_confirm.TabIndex = 5;
            this.btn_login_confirm.Text = "Confirm";
            this.btn_login_confirm.UseVisualStyleBackColor = false;
            // 
            // btn_login_cancel
            // 
            this.btn_login_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_login_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_cancel.Location = new System.Drawing.Point(248, 212);
            this.btn_login_cancel.Name = "btn_login_cancel";
            this.btn_login_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_login_cancel.TabIndex = 6;
            this.btn_login_cancel.Text = "Cancel";
            this.btn_login_cancel.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btn_login_cancel);
            this.Controls.Add(this.btn_login_confirm);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.txt_login_username);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.lbl_login_title);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(430, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_title;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Button btn_login_confirm;
        private System.Windows.Forms.Button btn_login_cancel;
    }
}
