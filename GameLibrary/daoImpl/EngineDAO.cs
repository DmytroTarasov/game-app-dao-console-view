using GameLibrary.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class EngineDAO : AbstractDAO<Engine>, IEngineDAO
    {
        public EngineDAO(Database database) : base(database.Engines, database) { }

    }
}
