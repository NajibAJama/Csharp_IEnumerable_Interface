using Csharp_IEnumerable_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Csharp_IEnumerable_Interface 
{
    public class VehicleList : IEnumerable
    {
        private readonly Vehicle[] _vehicles;
        public VehicleList(Vehicle[] Vehicles)
        {
            //Note this is can be skiped but it's for clearity 
            _vehicles = new Vehicle[Vehicles.Length];
            _vehicles = Vehicles;
        }

        public IEnumerator GetEnumerator()
        {
            return new VehicleEnumerator(_vehicles);
        }
    }

}
