using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public abstract class VehicleAbstraction
    {
        /*
         * Abstract method has no actual code or body but  
         * MUST BE overrridden in non-abstract child class.
         */
        public abstract int NumberOfSeats();
        public abstract int NumberOfDoors();

        public abstract void StartEngine();

        public string? IssuedPlateNumber { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }


    }
}
