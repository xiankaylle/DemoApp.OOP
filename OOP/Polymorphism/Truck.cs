using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    //Derived Class
    public class Truck : Vehicle
    {
        public Truck()
        {
            

        }

        private const int NUMBER_OF_SEATS = 2;
        private const int NUMBER_OF_DOORS = 2;
        
        public override int NumberOfDoors()
        {
            return NUMBER_OF_DOORS;
        }
        public override int NumberOfSeats()
        {
            return NUMBER_OF_SEATS;
        }
       
    }
}
