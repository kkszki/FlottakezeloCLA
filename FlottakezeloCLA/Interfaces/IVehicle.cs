using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA.Interfaces
{
    internal interface IVehicle
    {
        void StartEngine();
        void StopEngine();

        bool IsRunning { get; set; }
    }
}
