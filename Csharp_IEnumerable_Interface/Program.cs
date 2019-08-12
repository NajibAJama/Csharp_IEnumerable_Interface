using System;

namespace Csharp_IEnumerable_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] Mycars = new Vehicle[]
        {
                new Vehicle{Make = "Honda", Model = "Civic", Year = new DateTime(2001, 1, 1)},
                new Vehicle{Make = "Honda", Model = "Accord", Year = new DateTime(2000, 1, 1)},
                new Vehicle{Make = "Toyota", Model = "High Lander", Year = new DateTime(2010, 1, 1)},
                new Vehicle{Make = "Toyota", Model = "Carolla", Year = new DateTime(2006, 1, 1)},
                new Vehicle{Make = "Doge", Model = "Durango", Year = new DateTime(2002, 1, 1)}
        };
            //this objects implements Ienumerable 
            VehicleList MyVehiclesList = new VehicleList(Mycars);

            //test if MyVehicleList enumorable
            var MyEnumerator = MyVehiclesList.GetEnumerator();
            while (MyEnumerator.MoveNext())
            {
                Console.WriteLine(MyEnumerator.Current.ToString()); // the tostring method has been overriden to return vehcile info 
            }
            MyEnumerator.Reset(); //reset pointer to the beginign 
            Console.ReadLine();
        }
    }
}
