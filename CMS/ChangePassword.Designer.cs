namespace CMS
{
    partial class ChangePassword
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
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtOldPasswd = new System.Windows.Forms.TextBox();
            this.txtNewPasswd = new System.Windows.Forms.TextBox();
            this.txtConPasswd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblChangePasswd = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblOldPasswd = new System.Windows.Forms.Label();
            this.lblNewPasswd = new System.Windows.Forms.Label();
            this.lblConPasswd = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(299, 119);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(184, 20);
            this.txtuname.TabIndex = 0;
            this.txtuname.Validating += new System.ComponentModel.CancelEventHandler(this.txtuname_Validating);
            // 
            // txtOldPasswd
            // 
            this.txtOldPasswd.Location = new System.Drawing.Point(299, 171);
            this.txtOldPasswd.Name = "txtOldPasswd";
            this.txtOldPasswd.PasswordChar = '*';
            this.txtOldPasswd.Size = new System.Drawing.Size(184, 20);
            this.txtOldPasswd.TabIndex = 1;
            this.txtOldPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.txtOldPasswd_Validating);
            // 
            // txtNewPasswd
            // 
            this.txtNewPasswd.Location = new System.Drawing.Point(299, 232);
            this.txtNewPasswd.Name = "txtNewPasswd";
            this.txtNewPasswd.PasswordChar = '*';
            this.txtNewPasswd.Size = new System.Drawing.Size(184, 20);
            this.txtNewPasswd.TabIndex = 2;
            this.txtNewPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPasswd_Validating);
            // 
            // txtConPasswd
            // 
            this.txtConPasswd.Location = new System.Drawing.Point(299, 291);
            this.txtConPasswd.Name = "txtConPasswd";
            this.txtConPasswd.PasswordChar = '*';
            this.txtConPasswd.Size = new System.Drawing.Size(184, 20);
            this.txtConPasswd.TabIndex = 3;
            this.txtConPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.txtConPasswd_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(171, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(312, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblChangePasswd
            // 
            this.lblChangePasswd.AutoSize = true;
            this.lblChangePasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePasswd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChangePasswd.Location = new System.Drawing.Point(180, 44);
            this.lblChangePasswd.Name = "lblChangePasswd";
            this.lblChangePasswd.Size = new System.Drawing.Size(251, 31);
            this.lblChangePasswd.TabIndex = 6;
            this.lblChangePasswd.Text = "Change Password";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(138, 119);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(87, 17);
            this.lbluname.TabIndex = 7;
            this.lbluname.Text = "User Name :";
            // 
            // lblOldPasswd
            // 
            this.lblOldPasswd.AutoSize = true;
            this.lblOldPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPasswd.Location = new System.Drawing.Point(138, 178);
            this.lblOldPasswd.Name = "lblOldPasswd";
            this.lblOldPasswd.Size = new System.Drawing.Size(103, 17);
            this.lblOldPasswd.TabIndex = 8;
            this.lblOldPasswd.Text = "Old Password :";
            // 
            // lblNewPasswd
            // 
            this.lblNewPasswd.AutoSize = true;
            this.lblNewPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswd.Location = new System.Drawing.Point(138, 239);
            this.lblNewPasswd.Name = "lblNewPasswd";
            this.lblNewPasswd.Size = new System.Drawing.Size(108, 17);
            this.lblNewPasswd.TabIndex = 9;
            this.lblNewPasswd.Text = "New Password :";
            // 
            // lblConPasswd
            // 
            this.lblConPasswd.AutoSize = true;
            this.lblConPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPasswd.Location = new System.Drawing.Point(138, 298);
            this.lblConPasswd.Name = "lblConPasswd";
            this.lblConPasswd.Size = new System.Drawing.Size(129, 17);
            this.lblConPasswd.TabIndex = 10;
            this.lblConPasswd.Text = "Confirm Password :";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 436);
            this.Controls.Add(this.lblConPasswd);
            this.Controls.Add(this.lblNewPasswd);
            this.Controls.Add(this.lblOldPasswd);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblChangePasswd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConPasswd);
            this.Controls.Add(this.txtNewPasswd);
            this.Controls.Add(this.txtOldPasswd);
            this.Controls.Add(this.txtuname);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtOldPasswd;
        private System.Windows.Forms.TextBox txtNewPasswd;
        private System.Windows.Forms.TextBox txtConPasswd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblChangePasswd;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblOldPasswd;
        private System.Windows.Forms.Label lblNewPasswd;
        private System.Windows.Forms.Label lblConPasswd;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}