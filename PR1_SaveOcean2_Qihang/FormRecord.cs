using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersistenceLibrary.XMLPersistence;
using ObjectLibrary;

namespace PR1_SaveOcean2_Qihang
{
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent();
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            initializeDataGrid();
        }

        private void initializeDataGrid()
        {
            List<Rescue> rescueList = XMLHelper.GetRescueList();
            dataGridRecord.DataSource = rescueList;
            dataGridRecord.Columns["Code"].HeaderText = "Rescue Code";
            dataGridRecord.Columns["Date"].Visible = false;
            dataGridRecord.Columns["Family"].Visible = false;
            dataGridRecord.Columns["AffectationGrade"].Visible = false;
            dataGridRecord.Columns["Location"].Visible = false;
        }

        private void dataGridRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCode.Text = "Code: " + dataGridRecord.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            lblDate.Text = "Date: " + dataGridRecord.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            lblAnimal.Text = "Animal: " + dataGridRecord.Rows[e.RowIndex].Cells["Family"].Value.ToString();
            lblAG.Text = "Affectation: " + dataGridRecord.Rows[e.RowIndex].Cells["AffectationGrade"].Value.ToString();
            lblLocation.Text = "Location: " + dataGridRecord.Rows[e.RowIndex].Cells["Location"].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
