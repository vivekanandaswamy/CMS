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
    public partial class MaterialReg : Form
    {
        #region Properties
        MaterialBL _materialBL;
        Material _material;
        #endregion
        public MaterialReg()
        {
            InitializeComponent();
            _materialBL = new MaterialBL();
            _material = new Material();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _material.mnane = txtmname.Text;
                _material.comments = txtComments.Text;
                var result = _materialBL.InsertMaterial(_material);
                if (result > 0)
                {
                    string message = string.Format("Material: {0} registered successfully!", txtmname.Text);
                    string title = "Registered Successfully";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult _confirmBox = MessageBox.Show(message, title, buttons);
                    if (_confirmBox == DialogResult.OK)
                    {
                        txtmname.Text = string.Empty;
                        txtComments.Text = string.Empty;
                       // this.Hide();                        
                    }
                }
            }
        }

        private void txtmname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmname.Text))
            {
                e.Cancel = true;
                txtmname.Focus();
                errProvider.SetError(txtmname, "Enter Material Name!");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtmname, "");
            }
        }
    }
}
