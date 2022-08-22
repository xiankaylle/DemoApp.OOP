using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Bus : Vehicle
    {
        private const int NUMBER_OF_SEATS = 50;
        private const int NUMBER_OF_DOORS = 1;
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
