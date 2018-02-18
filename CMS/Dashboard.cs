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
    public partial class Dashboard : Form
    {
        #region Properties
        MaterialReg _material = null;
        TypeOfMaterialReg _typeofMaterial = null;
        #endregion
        public Dashboard()
        {
            InitializeComponent();
            _material = new MaterialReg();
            _typeofMaterial = new TypeOfMaterialReg();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            _material.ShowDialog();
        }

        private void btnMaterialDealers_Click(object sender, EventArgs e)
        {

        }

        private void btnTypeOfMaterials_Click(object sender, EventArgs e)
        {
            _typeofMaterial.ShowDialog();
        }

        private void btnEstMaterialCost_Click(object sender, EventArgs e)
        {

        }

        private void btnActualMaterialCost_Click(object sender, EventArgs e)
        {

        }

        private void btnRequiredPersons_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnEstLabourCost_Click(object sender, EventArgs e)
        {

        }

        private void btnActualLabourCost_Click(object sender, EventArgs e)
        {

        }
    }
}
