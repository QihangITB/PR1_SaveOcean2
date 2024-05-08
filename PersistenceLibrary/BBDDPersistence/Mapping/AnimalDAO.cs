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

        /// <summary>
        /// Method that Selects all the animals from the database.
        /// </summary>
        /// <returns>A List of Animal Object </returns>
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

        /// <summary>
        /// Method that Select a animal from the database that has the Id.
        /// </summary>
        /// <param name="id">Unique identification to search the object in the DB</param>
        /// <returns>A object Animal that has the Id</returns>
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

        /// <summary>
        /// Method that deletes a animal from the database that has the Id.
        /// </summary>
        /// <param name="id">Unique identification to search the object in the DB</param>

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

        /// <summary>
        /// Method that insert a animal to the database.
        /// </summary>
        /// <param name="animal">A object Animal that will be inserted.</param>
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

        /// <summary>
        /// Method that update a animal from the database.
        /// </summary>
        /// <param name="animal">A object Animal that will be updated.</param>
        public void UpdateAnimal(Animal animal)
        {
            if (animal.Id == 0)
            {
                throw new Exception("The animal must have an Id");
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE animal SET name = @name, super_family = @superFamily, species = @species, weight = @weight WHERE id = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", animal.Name);
                command.Parameters.AddWithValue("@superFamily", animal.SuperFamily);
                command.Parameters.AddWithValue("@species", animal.Species);
                command.Parameters.AddWithValue("@weight", animal.Weight);
                command.Parameters.AddWithValue("@id", animal.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
