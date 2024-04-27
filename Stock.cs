using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Stock
    {
        //fields
        List<Vehicle> _vehicles;

        public Stock(List<Vehicle> vehicles)
        {
            _vehicles = vehicles;
        }

        //Constructor

        //Properties
        public List<Vehicle> Vehicles { get => _vehicles; set => _vehicles = value; }
        //method
        
    }
}
