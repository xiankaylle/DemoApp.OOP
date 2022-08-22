using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public interface IVehicle
    {
        string Manufacturer { get; set; }
        string Color { get; set; }
        int NumberOfSeats();
        int NumberOfDoors();
    }
}
