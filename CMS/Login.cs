using CMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Login : Form
    {
        #region Properties/Objects
        Dashboard _dashboard;
        UserRegistration _userReg;
        ChangePassword _chgPasswd;
        ForgotPassword _fgtPasswd;
        UserBL _userBal;
        #endregion

        #region Constructor
        public Login()
        {
            InitializeComponent();
            _dashboard = new Dashboard();
            _userReg = new UserRegistration();
            _chgPasswd = new ChangePassword();
            _fgtPasswd = new ForgotPassword();
            _userBal = new UserBL();
        }
        #endregion

        #region Button Click Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = txtUname.Text;
                string passwd = txtpasswd.Text;
                var result = _userBal.Login(username, passwd);
                if (result.HasRows)
                {
                    string message = string.Format("Username: {0} Authenticated successfully!", username);
                    string title = "Authentication Successfully";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        this.Hide();
                        _dashboard.ShowDialog();
                    }
                }
                else
                {
                    string message = string.Format("Username: {0} Authentication failed; Check Username/Password!", username);
                    string title = "Authentication Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        // this.ShowDialog();
                    }
                }
            }
        }

        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _userReg.ShowDialog();
        }

        private void btnforgotPasswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _fgtPasswd.ShowDialog();
        }

        private void btnChangePasswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _chgPasswd.ShowDialog();
        }

        #endregion

        #region  Validations       

        private void txtUname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUname.Text))
            {
                e.Cancel = true;
                txtUname.Focus();
                errProvider.SetError(txtUname, "Enter User Name!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtUname, "");
            }
        }

        private void txtpasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpasswd.Text))
            {
                e.Cancel = true;
                txtpasswd.Focus();
                errProvider.SetError(txtpasswd, "Enter Password!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtpasswd, "");
            }
        }
        #endregion
    }
}
