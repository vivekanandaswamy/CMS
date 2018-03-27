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
using System.Data.Common;

namespace CMS
{
    public partial class InvolvedPersons : Form
    {
        PersonBL _personBL;
        PersonDetailsReg _personDetailsRegistration = null;
        DbDataReader personDetails = null;
        public InvolvedPersons()
        {
            InitializeComponent();
            _personBL = new PersonBL();
            _personDetailsRegistration = new PersonDetailsReg();
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

        private void dbGridPersons_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           int pid = Convert.ToInt32(dbGridPersons.Rows[e.RowIndex].Cells[0].Value.ToString());
            personDetails = FetchPersonDetailById(pid);
            _personDetailsRegistration.InvolvedPersons = this;
            _personDetailsRegistration.ShowDialog();
        }
        private DbDataReader FetchPersonDetailById(int pid)
        {
            var person = _personBL.FetchPersonDetailById(pid);
            return person;
        }
    }
}
