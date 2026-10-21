namespace _049_Balberan_JhonRey_MACT2
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text))
            {
                MessageBox.Show("Input Missing Fields");
            } else
            {
                frmCourseDetails course = new frmCourseDetails(
                    txtId.Text,
                    txtFname.Text,
                    txtLname.Text);
                this.Hide();
                course.Show();
            }

        }
    }
}
