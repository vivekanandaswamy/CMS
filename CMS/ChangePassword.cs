using CMS.BL;
using CMS.DAL.Models;
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
    public partial class ChangePassword : Form
    {
        #region Properties
        UserBL _userRegistration = null;
        User _userDetails = null;
        #endregion

        #region Constructor
        public ChangePassword()
        {
            InitializeComponent();
            _userRegistration = new UserBL();
            _userDetails = new User();
        }
        #endregion

        #region Button Click Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string oldPasswd = txtOldPasswd.Text;
                _userDetails.uname = txtuname.Text;
                _userDetails.passwd = txtNewPasswd.Text;
                _userDetails.conpasswd = txtConPasswd.Text;
                int result =  _userRegistration.ChangePassword(oldPasswd, _userDetails);
                if (result > 0)
                {
                    string message = string.Format("Username: {0} Password is changed successfully!", _userDetails.uname);
                    string title = "Changed Password Successfully";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        this.Hide();
                    }
                }
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        #endregion

        #region Private Methods
        private void ClearAll()
        {
            txtuname.Text = string.Empty;
            txtNewPasswd.Text = string.Empty;
            txtConPasswd.Text = string.Empty;
        }
        #endregion

        #region Validations
        private void txtuname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuname.Text))
            {
                e.Cancel = true;
                txtuname.Focus();
                errProvider.SetError(txtuname, "User name should not be blank!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtuname, "");
            }
        }

        private void txtOldPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPasswd.Text))
            {
                e.Cancel = true;
                txtOldPasswd.Focus();
                errProvider.SetError(txtOldPasswd, "Enter Old Passord!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtOldPasswd, "");
            }
        }

        private void txtNewPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPasswd.Text))
            {
                e.Cancel = true;
                txtNewPasswd.Focus();
                errProvider.SetError(txtNewPasswd, "Enter Password!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtNewPasswd, "");
            }
        }

        private void txtConPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConPasswd.Text))
            {
                e.Cancel = true;
                txtConPasswd.Focus();
                errProvider.SetError(txtConPasswd, "Enter Confirm Password!");
            }
            else if (!txtNewPasswd.Text.Equals(txtConPasswd.Text))
            {
                e.Cancel = true;
                txtConPasswd.Focus();
                errProvider.SetError(txtConPasswd, "Password Mismatch!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtConPasswd, "");
            }
        }
        #endregion
    }
}
