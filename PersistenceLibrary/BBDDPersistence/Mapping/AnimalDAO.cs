using Npgsql;
using ObjectLibrary;
using PersistenceLibrary.BBDDPersistence.DAO;
using PersistenceLibrary.BBDDPersistence.Utils;

namespace PersistenceLibrary.BBDDPersistence.Mapping
{
    public class AnimalDAO : IAnimalDAO
    {
        private readonly string connectionString;

        public AnimalDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM animal";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Animal contact = NpgsqlUtils.GetAnimal(reader);
                    animals.Add(contact);
                }
            }
            return animals;
        }

        public Animal GetAnimalById(int id)
        {
            Animal animal = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM animal WHERE id = @Id";

                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();

                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    animal = NpgsqlUtils.GetAnimal(reader);
                }
            }

            return animal; ;
        }

        public void DeleteAnimal(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "DELETE FROM animal WHERE id = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void InsertAnimal(Animal animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO animal (name, super_family, species, weight) VALUES (@name, @superFamily, @species, @weight)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", animal.Name);
                command.Parameters.AddWithValue("@superFamily", animal.SuperFamily);
                command.Parameters.AddWithValue("@species", animal.Species);
                command.Parameters.AddWithValue("@weight", animal.Weight);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAnimal(Animal animal)
        {
            if (animal.Id == 0)
            {
                throw new Exception("The animal must have an Id");
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE animal SET Name = @name, SuperFamily = @superFamily, Species = @species, Weight = @weight WHERE Id = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@SuperFamily", animal.SuperFamily);
                command.Parameters.AddWithValue("@Species", animal.Species);
                command.Parameters.AddWithValue("@Weight", animal.Weight);
                command.Parameters.AddWithValue("@Id", animal.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
