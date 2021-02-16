using GameLibrary.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class DisksDAO : AbstractDAO<Disks>, IDisksDAO
    {
        public DisksDAO(Database database) : base(database.Disks, database) { }
    }
}
