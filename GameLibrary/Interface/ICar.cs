using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface ICar
    {
        int Speed { get; set; }
        Engine Engine { get; set; }
        Accumulator Accumulator { get; set; }
        Disks Disks { get; set; }
    }
}
