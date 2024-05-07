using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_SaveOcean2_Qihang
{
    public partial class FormResult : Form
    {
        private int finalAffectationGrade;
        private int finalPlayerExperience;

        public FormResult(int finalAffectationGrade, int finalPlayerExperience)
        {
            InitializeComponent();
            this.finalAffectationGrade = finalAffectationGrade;
            this.finalPlayerExperience = finalPlayerExperience;
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            if (finalAffectationGrade <= 30)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "CONGRATULATIONS, IT HAS BEEN A SUCCES";
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "UNFORTUNATELY IT HAS BEEN A FAILURE";
            }
            lblAffectation.Text = "Affectation grade: " + finalAffectationGrade + "%";
            lblExperience.Text = "Player experience: " + finalPlayerExperience + "xp";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
