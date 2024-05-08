namespace PR1_SaveOcean2_Qihang
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit edit = new FormEdit();
            edit.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormRecord record = new FormRecord();
            record.Show();
        }
    }
}
