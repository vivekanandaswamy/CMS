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
    public partial class ForgotPassword : Form
    {
        #region Properties
        UserBL _userRegistration = null;
        #endregion

        #region Constructor
        public ForgotPassword()
        {
            InitializeComponent();
            _userRegistration = new UserBL();
        }
        #endregion

        #region Button Click Events
        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var fetch_passwd = _userRegistration.GetPassword(txtuname.Text);
                if (fetch_passwd.HasRows)
                {
                    string passwd = string.Empty;
                    while (fetch_passwd.Read())
                    {
                        passwd = fetch_passwd["passwd"].ToString();
                    }
                    string mesg = string.Format("Username: {0} password is {1}", txtuname.Text, passwd);
                    string title = "Retrieved Password!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(mesg, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        this.Hide();
                    }

                }
            }
        }
        #endregion

        #region Validations
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
        #endregion
    }
}
