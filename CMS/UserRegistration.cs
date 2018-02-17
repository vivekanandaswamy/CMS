using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.DAL.Models;
using CMS.BL;
using CMS.DAL;
namespace CMS
{
    public partial class UserRegistration : Form
    {
        #region Properties
        User _user;
        UserBL _userRegistration = null;
       // Login _login;
        #endregion

        #region  Constructor
        public UserRegistration()
        {
            InitializeComponent();           
            _user = new User();
            _userRegistration = new UserBL();           
        }
        #endregion

        #region Button Events

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _user.fname = txtfname.Text;
                _user.lname = txtlname.Text;
                _user.uname = txtuname.Text;
                _user.passwd = txtPasswd.Text;
                _user.conpasswd = txtConPasswd.Text;
                _user.dor = dtPckr.Text == null ? DateTime.Now : Convert.ToDateTime(dtPckr.Text);
                int result = InsertUserDetails(_user);
                if (result > 0)
                {
                    string message = string.Format("Username: {0} registered successfully!", _user.uname);
                    string title = "Registered Successfully";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        this.Hide();
                       // _login.ShowDialog()
                    }
                }

            }

        }

        #endregion

        #region Private Methods
        private int InsertUserDetails(User _userDetails)
        {
            return _userRegistration.InsertUserDetails(_userDetails);
        }
        private void ClearAll()
        {
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtuname.Text = string.Empty;
            txtPasswd.Text = string.Empty;
            txtConPasswd.Text = string.Empty;
            dtPckr.Text = DateTime.Now.ToString();
        }
        #endregion

        #region Validations

        private void txtfname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfname.Text))
            {
                e.Cancel = true;
                txtfname.Focus();
                errProvider.SetError(txtfname, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtfname, "");
            }
        }

        private void txtlname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlname.Text))
            {
                e.Cancel = true;
                txtlname.Focus();
                errProvider.SetError(txtlname, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtlname, "");
            }
        }
        private void txtuname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuname.Text))
            {
                e.Cancel = true;
                txtuname.Focus();
                errProvider.SetError(txtuname, "User Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtuname, "");
            }
        }
        private void txtPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswd.Text))
            {
                e.Cancel = true;
                txtPasswd.Focus();
                errProvider.SetError(txtPasswd, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtPasswd, "");
            }
        }
        private void txtConPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConPasswd.Text))
            {
                e.Cancel = true;
                txtConPasswd.Focus();
                errProvider.SetError(txtConPasswd, "Confirm Password should not be left blank!");
            }
            else if (!txtPasswd.Text.Equals(txtConPasswd.Text))
            {
                e.Cancel = true;
                txtConPasswd.Focus();
                errProvider.SetError(txtConPasswd, "Password Mistmatched!");
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
