using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLibrary;

namespace PersistenceLibrary.BBDDPersistence.DAO
{
    public interface IRescueDAO
    {
        Rescue GetRescueByCode(string code);
        public List<Rescue> GetAllRescues();
        void InsertRescue(Rescue rescue);
        void UpdateRescue(Rescue rescue);
        void DeleteRescue(string code);
    }
}
