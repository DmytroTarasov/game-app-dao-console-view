﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.dao
{
    interface IDAOFactory
    {
        IDetailDAO GetDetailDAO();
        ICarDAO GetCarDao();
    }
}
