using GameLibrary.daoImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Database
    {
        internal IDictionary<Guid, Car> Cars;

        internal IDictionary<Guid, Engine> Engines;

        internal IDictionary<Guid, Accumulator> Accumulators;

        internal IDictionary<Guid, Disks> Disks;
        public Database()
        {
            Cars = new Dictionary<Guid, Car>();
            Engines = new Dictionary<Guid, Engine>();
            Accumulators = new Dictionary<Guid, Accumulator>();
            Disks = new Dictionary<Guid, Disks>();
        }

        DAOFactory GetDAOFactory()
        {
            return new DAOFactory(this);
        }
    }
}
