using Npgsql;
using Microsoft.Extensions.Configuration;
using System.IO;
using ObjectLibrary;

namespace PersistenceLibrary.BBDDPersistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "../../../Files/JSON/appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static Animal GetAnimal(NpgsqlDataReader reader)
        {
            Animal animal = new Animal()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                SuperFamily = reader.GetString(2),
                Species = reader.GetString(3),
                Weight = reader.GetFloat(4),
            };

            return animal;
        }
    }
}
