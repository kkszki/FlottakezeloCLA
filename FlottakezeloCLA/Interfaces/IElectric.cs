using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA.Interfaces
{
    internal interface IElectric
    {
        void Charge(double percentage);
        int BatteryLevel { get; set; } 
    }
}
