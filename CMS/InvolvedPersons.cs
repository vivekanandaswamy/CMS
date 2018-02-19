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
    public partial class InvolvedPersons : Form
    {
        PersonBL _personBL;
        public InvolvedPersons()
        {
            InitializeComponent();
            _personBL = new PersonBL();
            LoadPersons();
            dbGridPersons.Columns.Clear();
        }
        private void BindPersonDetails()
        {
            var resultTable = _personBL.FetchPersonDetails();
            dbGridPersons.DataSource = resultTable;
        }
        private void LoadPersons()
        {
            DataTable dt = _personBL.FetchPersons();
            cmbReqPersons.ValueMember = "rpid";
            cmbReqPersons.DisplayMember = "name";
            cmbReqPersons.Items.Add("--Select--");
            cmbReqPersons.DataSource = dt;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindPersonDetails();
        }
    }
}
