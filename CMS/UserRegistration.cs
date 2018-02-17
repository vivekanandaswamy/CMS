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
        User _user;
        UserRegistrationBL _userRegistration = null;
        public UserRegistration()
        {
            InitializeComponent();
            _user = new User();
            _userRegistration = new UserRegistrationBL();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.fname = txtfname.Text;
            _user.lname = txtlname.Text;
            _user.uname = txtuname.Text;
            _user.passwd = txtPasswd.Text;
            _user.conpasswd = txtConPasswd.Text;
            _user.dor = dtPckr.Text == null ? DateTime.Now : Convert.ToDateTime(dtPckr.Text);
            int result = InsertUserDetails(_user);
            if(result>0)
            {
                MessageBox.Show("Registered Successfully");
            }

        }
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
    }
}
