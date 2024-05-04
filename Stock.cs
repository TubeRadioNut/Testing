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

        //Constructor
        public Stock(List<Vehicle> vehicles)
        {
            _vehicles = vehicles;
        }

        //Properties
        public List<Vehicle> Vehicles { get => _vehicles; set => _vehicles = value; }
        //method
        //Creates the FormatVehicle() method that will format _vehicles list into a single string to be diplayed and
        //returning that string
        public string FormatVehicle()
        {
            //Create sting variable to build the formatted Vehicle to be displayed
            string formatVehicle = "";
            //Loop through the _vehicles list adding list to string variable using the override ToString() method from Vehicle class
            for(int i = 0; _vehicles.Count > i; i++)
            {
                formatVehicle += $"{_vehicles[i].ToString()} Retail: {_vehicles[i].WholesalePrice * 1.20m:c}\n";
            }
            return formatVehicle;
        }

    }
}
