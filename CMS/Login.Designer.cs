namespace CMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.LinkLabel();
            this.btnforgotPasswd = new System.Windows.Forms.LinkLabel();
            this.btnPasswdRecovery = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(250, 196);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 31);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(102, 106);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(83, 17);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "User Name:";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswd.Location = new System.Drawing.Point(102, 152);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(77, 17);
            this.lblPasswd.TabIndex = 4;
            this.lblPasswd.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Construction/Material Information";
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(442, 71);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(119, 17);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.TabStop = true;
            this.btnSignUp.Text = "New User/SignUp";
            this.btnSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSignUp_LinkClicked);
            // 
            // btnforgotPasswd
            // 
            this.btnforgotPasswd.AutoSize = true;
            this.btnforgotPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgotPasswd.Location = new System.Drawing.Point(102, 256);
            this.btnforgotPasswd.Name = "btnforgotPasswd";
            this.btnforgotPasswd.Size = new System.Drawing.Size(114, 17);
            this.btnforgotPasswd.TabIndex = 7;
            this.btnforgotPasswd.TabStop = true;
            this.btnforgotPasswd.Text = "Forgot Password";
            // 
            // btnPasswdRecovery
            // 
            this.btnPasswdRecovery.AutoSize = true;
            this.btnPasswdRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswdRecovery.Location = new System.Drawing.Point(442, 256);
            this.btnPasswdRecovery.Name = "btnPasswdRecovery";
            this.btnPasswdRecovery.Size = new System.Drawing.Size(133, 17);
            this.btnPasswdRecovery.TabIndex = 8;
            this.btnPasswdRecovery.TabStop = true;
            this.btnPasswdRecovery.Text = "Password Recovery";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 350);
            this.Controls.Add(this.btnPasswdRecovery);
            this.Controls.Add(this.btnforgotPasswd);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btnSignUp;
        private System.Windows.Forms.LinkLabel btnforgotPasswd;
        private System.Windows.Forms.LinkLabel btnPasswdRecovery;
    }
}

