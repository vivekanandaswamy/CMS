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
    public partial class RequiredPersons : Form
    {
        #region Properties
        Person _person;
        PersonBL _personBL;
        #endregion
        
        public RequiredPersons()
        {
            InitializeComponent();
            _person = new Person();
            _personBL = new PersonBL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _person.name = txtpname.Text;
                _person.comments = txtComments.Text;
                var result = _personBL.InsertPersons(_person);
                if (result > 0)
                {
                    string message = string.Format("Person: {0} registered successfully!", txtpname.Text);
                    string title = "Registered Successfully";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        txtpname.Text = string.Empty;
                        txtComments.Text = string.Empty;                                              
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtpname.Text = string.Empty;
            txtComments.Text = string.Empty;
        }

        private void txtpname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpname.Text))
            {
                e.Cancel = true;
                txtpname.Focus();
                errProvider.SetError(txtpname, "Enter Person Name!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtpname, "");
            }
        }
    }
}
