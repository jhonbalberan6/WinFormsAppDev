using System.Data;

namespace _049_Balberan_JhonRey_MACT3
{
    public partial class frmRegistration : Form
    {
        DataTable studentDt = new DataTable();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            studentDt.Columns.Add("First Name", typeof(string));
            studentDt.Columns.Add("Last Name", typeof(string));
            studentDt.Columns.Add("Course", typeof(string));
            studentDt.Columns.Add("Department", typeof(string));
            dtgStudents.DataSource = studentDt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFName.Text) &&
                !string.IsNullOrWhiteSpace(txtLName.Text) &&
                !string.IsNullOrWhiteSpace(txtCourse.Text) &&
                cmbDepartment.SelectedIndex != -1)
            {
                studentDt.Rows.Add(txtFName.Text, txtLName.Text, txtCourse.Text, cmbDepartment.Text);
                clear();
            }
            else
            {
                MessageBox.Show("Fill in all fields!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtCourse.Clear();
            txtFName.Clear();
            txtLName.Clear();
            cmbDepartment.SelectedIndex = -1;
        }

        private void dtgStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStudentInfo studentInfo = new frmStudentInfo();
            studentInfo.lblFname.Text = studentDt.Rows[0]["First Name"].ToString();
            studentInfo.lblLname.Text = studentDt.Rows[0]["Last Name"].ToString();
            studentInfo.lblCourse.Text = studentDt.Rows[0]["Course"].ToString();
            studentInfo.lblDepartment.Text = studentDt.Rows[0]["Department"].ToString();
            studentInfo.Show();
        }
    }
}
