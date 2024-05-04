using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Vehicle
    {
        //fields
        string _make;
        string _model;
        string _year;
        string _vin;
        decimal _wholesalePrice;
        //Constructor
        public Vehicle(string make, string model, string year, string vin)
        {
            //generate a random number for _wholesalePrice between 1,000 and 70,000
            Random rand = new Random();
            _make = make;
            _model = model;
            _year = year;
            _vin = vin;
            _wholesalePrice = rand.Next(1000, 70000);
        }
        //Properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Year { get => _year; set => _year = value; }
        public string Vin { get => _vin; set => _vin = value; }
        public decimal WholesalePrice { get => _wholesalePrice; }//no set for WholesalePrice

        //Method
        //create override ToString() to formatt how fields will be displayed
        public override string ToString()
        {
            return $"{_make} {_model} {_year} VIN: {_vin} Wholesale: {_wholesalePrice:c}\n";
        }
    }//end of class

}//end of namespace
