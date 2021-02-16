using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface IBase
    {
        Guid Id { get; set; }
        void GenerateId();
    }
}
