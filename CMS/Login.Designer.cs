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
            this.components = new System.ComponentModel.Container();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpasswd = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.LinkLabel();
            this.btnforgotPasswd = new System.Windows.Forms.LinkLabel();
            this.btnChangePasswd = new System.Windows.Forms.LinkLabel();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(250, 103);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(129, 20);
            this.txtUname.TabIndex = 1;
            this.txtUname.Validating += new System.ComponentModel.CancelEventHandler(this.txtUname_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(250, 196);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtpasswd
            // 
            this.txtpasswd.Location = new System.Drawing.Point(250, 149);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.PasswordChar = '*';
            this.txtpasswd.Size = new System.Drawing.Size(129, 20);
            this.txtpasswd.TabIndex = 2;
            this.txtpasswd.Validating += new System.ComponentModel.CancelEventHandler(this.txtpasswd_Validating);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Construction/Material Information";
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(445, 79);
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
            this.btnforgotPasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnforgotPasswd_LinkClicked);
            // 
            // btnChangePasswd
            // 
            this.btnChangePasswd.AutoSize = true;
            this.btnChangePasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePasswd.Location = new System.Drawing.Point(442, 256);
            this.btnChangePasswd.Name = "btnChangePasswd";
            this.btnChangePasswd.Size = new System.Drawing.Size(122, 17);
            this.btnChangePasswd.TabIndex = 8;
            this.btnChangePasswd.TabStop = true;
            this.btnChangePasswd.Text = "Change Password";
            this.btnChangePasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangePasswd_LinkClicked);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 350);
            this.Controls.Add(this.btnChangePasswd);
            this.Controls.Add(this.btnforgotPasswd);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUname);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtpasswd;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btnSignUp;
        private System.Windows.Forms.LinkLabel btnforgotPasswd;
        private System.Windows.Forms.LinkLabel btnChangePasswd;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}

