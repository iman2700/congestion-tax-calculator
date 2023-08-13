using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator
{
  public  class VehicleFactory<T> where T : Vehicle, new()
    {
        public T CreateVehicle()
        {
            return new T();
        }
    }
}
