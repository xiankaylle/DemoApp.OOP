using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    //Base Class
    public abstract class Vehicle 
    {

        public string? IssuedPlateNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }

        private const int NUMBER_OF_SEATS = 4; //Standard number of seats
        private const int NUMBER_OF_DOORS = 4; //Standard number of doors

        public string GetPlateNumber()
        {
            return (string.IsNullOrEmpty(IssuedPlateNumber)) ? "Plate number still in progress.." : IssuedPlateNumber;
        }

        
        /*
         * vitual is optional or not necessary to override in derived class(s)
         * virtual method must have a body
        */
        public virtual int NumberOfSeats()
        {
            return NUMBER_OF_SEATS;
        }
        public virtual int NumberOfDoors()
        {
            return NUMBER_OF_DOORS;
        }
    }
}
