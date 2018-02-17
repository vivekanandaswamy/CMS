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
        Tabs _tabs;
        UserRegistration _userReg;
        #endregion
        public Login()
        {
            InitializeComponent();
            _tabs = new Tabs();
            _userReg = new UserRegistration();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            _tabs.ShowDialog();
        }

        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _userReg.ShowDialog();
        }
    }
}
