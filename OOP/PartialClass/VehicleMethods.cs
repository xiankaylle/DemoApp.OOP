using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace OOP.Polymorphism
namespace OOP.PartialClass
{
    public abstract partial class Vehicle
    {
        private const int NUMBER_OF_SEATS = 4; //Standard number of seats
        private const int NUMBER_OF_DOORS = 4; //Standard number of doors
        public virtual int NumberOfSeats()
        {
            return NUMBER_OF_SEATS;
        }
        public virtual int NumberOfDoors()
        {
            return NUMBER_OF_DOORS;
        }
        public void StartEngine()
        {
            Console.WriteLine("Broom! Broom!");
        }
    }
}
