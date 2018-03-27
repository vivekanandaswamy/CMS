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
    public partial class PersonDetailsReg : Form
    {
        PersonBL _personBL;
        PersonDetails _personDetails;
       

        public InvolvedPersons InvolvedPersons { get; internal set; }

        public PersonDetailsReg()
        {
            InitializeComponent();
            _personBL = new PersonBL();
            _personDetails = new PersonDetails();            
            LoadPersons();
        }
        private void LoadPersons()
        {
            DataTable dt = _personBL.FetchPersons();
            cmbPersons.ValueMember = "rpid";
            cmbPersons.DisplayMember = "name";
            cmbPersons.Items.Add("--Select--");
            cmbPersons.DataSource = dt;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _personDetails.name = txtName.Text;
                _personDetails.address = txtAddress.Text;
                _personDetails.rpid = Convert.ToInt32(cmbPersons.SelectedIndex) + 1;
                _personDetails.mobile1 = txtMobile1.Text;
                _personDetails.mobile2 = txtMobile2.Text;
                _personDetails.email = txtEmail.Text;
                _personDetails.comments = txtComments.Text;
                var result = _personBL.InsertPersonDetails(_personDetails);
                if (result > 0)
                {
                    string message = string.Format("Person Details: {0} registered successfully!", txtName.Text);
                    string title = "Registered Successfully";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        txtName.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtMobile1.Text = string.Empty;
                        txtMobile2.Text = string.Empty;
                        cmbPersons.SelectedIndex = 0;
                        txtEmail.Text = string.Empty;
                        txtComments.Text = string.Empty;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMobile1.Text = string.Empty;
            txtMobile2.Text = string.Empty;
            cmbPersons.SelectedIndex = 0;
            txtEmail.Text = string.Empty;
            txtComments.Text = string.Empty;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errProvider.SetError(txtName, "Enter Person Name!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtName, "");
            }
        }

        private void PersonDetailsReg_Load(object sender, EventArgs e)
        {
            
        }
    }
}
