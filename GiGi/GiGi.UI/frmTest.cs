using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiGi.BL;
using GiGi.COMMON;

namespace GiGi.UI
{
    public partial class frmTest : Form
    {

        private EmployeeBL oEmployeeBl = new EmployeeBL();
 
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            grideSource();
        }

        #region Events

        private void grideSource() 
        {
            dataGridView1.DataSource = oEmployeeBl.Select();
            dataGridView1.BindingContext = this.BindingContext;
        }

        #endregion Events
    }
}
