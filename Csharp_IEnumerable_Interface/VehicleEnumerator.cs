using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Csharp_IEnumerable_Interface 
{
    class VehicleEnumerator : IEnumerator
    {
        private int position = -1;
        private readonly Vehicle[] vehicles;
        public VehicleEnumerator(Vehicle[] Vehicles)
        {
            vehicles = new Vehicle[Vehicles.Length];
            vehicles = Vehicles;
        }
        public object Current
        {
            get
            {
                try
                {
                    return vehicles[position];
                }
                catch (IndexOutOfRangeException)
                {
                    //this hides the existance of my internal array
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < vehicles.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
