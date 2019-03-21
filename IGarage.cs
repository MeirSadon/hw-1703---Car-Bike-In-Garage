using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703__hw___CarInGarageWithNewException
{
    public interface IGarage<T>
    {
        void AddVehicle(T v);
        void FixVehicle(T v);
        void TakeOutVehicle(T v);
    }
}
