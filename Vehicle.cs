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
        //Constructor
        public Vehicle(string make, string model, string year, string vin)
        {
            _make = make;
            _model = model;
            _year = year;
            _vin = vin;
        }
        //Properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Year { get => _year; set => _year = value; }
        public string Vin { get => _vin; set => _vin = value; }
        //Method
        public override string ToString()
        {
            return $"{_make} {_model} {_year} VIN: {_vin}";
        }
    }//end of class

}//end of namespace
