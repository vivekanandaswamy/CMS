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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
