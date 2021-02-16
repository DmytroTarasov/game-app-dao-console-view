using GameLibrary.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class AccumulatorDAO : AbstractDAO<Accumulator>, IAccumulatorDAO
    {
        public AccumulatorDAO(Database database) : base(database.Accumulators, database) { }
    }
}
