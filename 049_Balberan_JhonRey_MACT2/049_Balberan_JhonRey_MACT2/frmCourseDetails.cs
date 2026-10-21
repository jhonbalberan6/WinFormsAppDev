using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _049_Balberan_JhonRey_MACT2
{
    public partial class frmCourseDetails : Form
    {
        string id;
        string Fname;
        string Lname;
        public frmCourseDetails(string _id, string _Fname, string _Lname)
        {
            id = _id;
            Fname = _Fname;
            Lname = _Lname;
            InitializeComponent();
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            if (cmbPrograms.SelectedIndex == -1 || string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Missing Fields!");
            } else
            {
                frmSummary summary = new frmSummary();
                summary.lblStudId.Text = id;
                summary.lblProgram.Text = cmbPrograms.Text;
                summary.lblYear.Text = txtYear.Text;
                summary.lblFName.Text = Fname;
                summary.lblLName.Text = Lname;
                summary.Show();
                this.Hide();
            }

        }
    }
}
