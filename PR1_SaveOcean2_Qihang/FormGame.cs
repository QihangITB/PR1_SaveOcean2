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

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            GenerateRescue();
            lblMsgNarrator.Text = "Hello! The 112 has recieved a call of warning to rescue an animal. The information that they  give us is the next:";
        }

        private void GenerateRescue()
        {
            //We need to generate a random animal before generate the rescue
            GenerateAnimal();

            rescue = new Rescue(animal);
            dataGridView1.DataSource = new List<Rescue> { rescue };
        }

        private void GenerateAnimal()
        {
            IAnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            List<Animal> animals = animalDAO.GetAllAnimals();

            //We get a random animal from the list of the database
            animal = animals[new Random().Next(0, animals.Count)];
        }
    }
}
