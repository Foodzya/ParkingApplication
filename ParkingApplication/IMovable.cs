using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApplication
{
    interface IMovable
    {
        double Speed();

        string Transmission();

        string DriveUnit();
    }
}
