using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLibrary;

namespace PersistenceLibrary.BBDDPersistence.DAO
{
    public interface IAnimalDAO
    {
        Animal GetAnimalById(int id);
        public List<Animal> GetAllAnimals();
        void InsertAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
        void DeleteAnimal(int id);
    }
}
