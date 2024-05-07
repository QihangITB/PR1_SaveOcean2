using System.Windows.Forms;
using ObjectLibrary;
using PersistenceLibrary.BBDDPersistence.DAO;
using PersistenceLibrary.BBDDPersistence.Mapping;
using PersistenceLibrary.BBDDPersistence.Utils;

namespace PR1_SaveOcean2_Qihang
{
    public partial class FormGame : Form
    {
        private Animal animal;
        private Rescue rescue;
        private int resultAffectationGrade;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //First, we have to generate the animal and then the rescue
            GenerateAnimal();
            initializeDataGridAnimal();

            GenerateRescue();
            initializeDataGridRescue();

            lblAffectation.Text = "Affectation grade: " + rescue.AffectationGrade;
        }

        private void initializeDataGridAnimal()
        {
            dataGridAnimal.DataSource = new List<Animal> { animal };
            dataGridAnimal.Columns["Id"].Visible = false;
            dataGridAnimal.Columns["SuperFamily"].HeaderCell.Value = "Family";
            dataGridAnimal.Columns["Weight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridAnimal.ClearSelection();
            dataGridAnimal.CurrentCell = null;
        }

        private void initializeDataGridRescue()
        {
            dataGridRescue.DataSource = new List<Rescue> { rescue };
            dataGridRescue.Columns["AffectationGrade"].HeaderCell.Value = "Affectation";
            dataGridRescue.Columns["AffectationGrade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridRescue.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridRescue.Columns["Family"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridRescue.ClearSelection();
            dataGridRescue.CurrentCell = null;
        }

        private void GenerateRescue()
        {
            //To generate the rescue, we need the animal
            rescue = new Rescue(animal);
        }

        private void GenerateAnimal()
        {
            IAnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            List<Animal> animals = animalDAO.GetAllAnimals();

            //We get a random animal from the list of the database
            animal = animals[new Random().Next(0, animals.Count)];
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int healOption = 1;
            resultAffectationGrade = CalculateTreatment(healOption);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int moveOption = 2;
            resultAffectationGrade = CalculateTreatment(moveOption);
        }

        private int CalculateTreatment(int userOption)
        {
            int result = 0;

            switch (animal.SuperFamily)
            {
                case "Sea Turtle":
                    result = animal.SeaTurtleTreatment(rescue.AffectationGrade, userOption);
                    break;
                case "Sea Bird":
                    result = animal.SeaBirdTreatment(rescue.AffectationGrade, userOption);
                    break;
                case "Cetacean":
                    result = animal.CetaceanTreatment(rescue.AffectationGrade, userOption);
                    break;
            }

            return result;
        }
    }
}
