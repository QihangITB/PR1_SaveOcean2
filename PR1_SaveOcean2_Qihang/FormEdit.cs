
using PersistenceLibrary.BBDDPersistence.DAO;
using PersistenceLibrary.BBDDPersistence.Mapping;
using PersistenceLibrary.BBDDPersistence.Utils;
using ObjectLibrary;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace PR1_SaveOcean2_Qihang
{
    public partial class FormEdit : Form
    {
        private IAnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
        private int selectedId; //Id of the selected row in the dataGrid

        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            dataGridAnimals.DataSource = animalDAO.GetAllAnimals();
            dataGridAnimals.Columns["id"].Visible = false;
            dataGridAnimals.Columns["SuperFamily"].HeaderText = "Super Family";
            dataGridAnimals.Columns["SuperFamily"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridAnimals.Columns["Species"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridAnimals.Rows[e.RowIndex];

                selectedId = int.Parse(row.Cells["id"].Value.ToString());
                txtName.Text = row.Cells["Name"].Value.ToString();
                comboFamily.Text = row.Cells["SuperFamily"].Value.ToString();
                txtSpecies.Text = row.Cells["Species"].Value.ToString();
                txtWeight.Text = row.Cells["Weight"].Value.ToString();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Animal newAnimal = new Animal()
                {
                    Name = txtName.Text,
                    Species = txtSpecies.Text,
                    SuperFamily = comboFamily.Text,
                    Weight = float.Parse(txtWeight.Text) // We are sure that the value is a number because we have validated it
                };
                animalDAO.InsertAnimal(newAnimal);
                InitializeDataGrid();
                lblUserMsg.ForeColor = Color.Green;
                lblUserMsg.Text = "Animal added";
                selectedId = 0; // Reset the selectedId
            }
            else
            {
                lblUserMsg.Text = string.Empty;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                lblUserMsg.ForeColor = Color.Red;
                lblUserMsg.Text = "Select an animal to modify";
            }
            else if (IsAnimalExists())
            {
                lblUserMsg.ForeColor = Color.Red;
                lblUserMsg.Text = "The animal data has no changes";
            }
            else if (ValidateChildren())
            {
                Animal modifiedAnimal = animalDAO.GetAnimalById(selectedId);

                modifiedAnimal.Name = txtName.Text;
                modifiedAnimal.SuperFamily = comboFamily.Text;
                modifiedAnimal.Species = txtSpecies.Text;
                modifiedAnimal.Weight = float.Parse(txtWeight.Text); // We are sure that the value is a number because we have validated it

                animalDAO.UpdateAnimal(modifiedAnimal);
                InitializeDataGrid();
                lblUserMsg.ForeColor = Color.Green;
                lblUserMsg.Text = "Animal modified";
                selectedId = 0; // Reset the selectedId
            }
            else
            {
               lblUserMsg.Text = string.Empty;
            }
        }

        private bool IsAnimalExists()
        {
            List<Animal> animals = animalDAO.GetAllAnimals();
            foreach (Animal animal in animals)
            {
                if (animal.Name == txtName.Text && animal.SuperFamily == comboFamily.Text 
                    && animal.Species == txtSpecies.Text && animal.Weight == float.Parse(txtWeight.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            Regex rg = new Regex(pattern);

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorName.SetError(txtName, "Name is required");
                e.Cancel = true;
            }
            else if (!rg.IsMatch(txtName.Text))
            {
                errorName.SetError(txtName, "Name must be a string of characters");
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtName, null);
                e.Cancel = false;
            }
        }

        private void comboFamily_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboFamily.Text))
            {
                errorFamily.SetError(comboFamily, "Family is required");
                e.Cancel = true;
            }
            else
            {
                errorFamily.SetError(comboFamily, null);
                e.Cancel = false;
            }
        }

        private void txtSpecies_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            Regex rg = new Regex(pattern);

            if (string.IsNullOrEmpty(txtSpecies.Text))
            {
                errorSpecies.SetError(txtSpecies, "Species is required");
                e.Cancel = true;
            }
            else if (!rg.IsMatch(txtSpecies.Text))
            {
                errorSpecies.SetError(txtSpecies, "Species must be a string of characters");
                e.Cancel = true;
            }
            else
            {
                errorSpecies.SetError(txtSpecies, null);
                e.Cancel = false;
            }
        }

        private void txtWeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text))
            {
                errorWeight.SetError(txtWeight, "Weight is required");
                e.Cancel = true;
            }
            else if (!float.TryParse(txtWeight.Text, out float weight))
            {
                errorWeight.SetError(txtWeight, "Weight must be a number");
                e.Cancel = true;
            }
            else
            {
                errorWeight.SetError(txtWeight, null);
                e.Cancel = false;
            }
        }
    }
}
