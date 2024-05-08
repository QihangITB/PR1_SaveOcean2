using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectLibrary;

namespace PR1_SaveOcean2_Qihang
{
    public partial class FormRegister : Form
    {
        const int MinNameLength = 3, MaxNameLength = 15;


        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnTechnical_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Player player = new Player(txtName.Text, "Technical", 45);
                FormGame game = new FormGame(player);
                game.Show();
                this.Close();
            }
        }

        private void btnVet_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Player player = new Player(txtName.Text, "Vet", 80);
                FormGame game = new FormGame(player);
                game.Show();
                this.Close();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            //With regex we can specify the input format that we want
            string pattern = @"^[a-zA-Z\s]+$";
            Regex rg = new Regex(pattern);

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorName.SetError(txtName, "Name is required.");
                e.Cancel = true;
            }
            else if (txtName.Text.Length < MinNameLength)
            {
                errorName.SetError(txtName, "Name must be at least 3 characters.");
                e.Cancel = true;
            }
            else if (txtName.Text.Length > MaxNameLength)
            {
                errorName.SetError(txtName, "Name must be less than 15 characters.");
                e.Cancel = true;
            }
            else if (!rg.IsMatch(txtName.Text))
            {
                errorName.SetError(txtName, "Name format is invalid.");
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtName, null);
                e.Cancel = false;
            }
        }
    }
}
