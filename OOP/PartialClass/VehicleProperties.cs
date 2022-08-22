using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*mespace OOP.Polymorphism*/
namespace OOP.PartialClass
{
    public abstract partial class Vehicle
    {
        public string? IssuedPlateNumber { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }

    }
}
