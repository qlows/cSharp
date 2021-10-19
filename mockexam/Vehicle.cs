using System;
using System.Collections.Generic;
using System.Text;

namespace mockexam
{
    class Vehicle
    {
        protected int vehicleNumber;
        protected int mileage;
        protected string make;
        protected string model;

        public Vehicle(int vin, int mileage, string make, string model)
        {
            this.vehicleNumber = vin;
            this.mileage = mileage;
            this.make = make;
            this.model = model;
        }

        public int getVehicleIDNumber() { return vehicleNumber; }

        public int getMileage() { return mileage; }

        public string getMake() { return make; }

        public string getModel() { return model; }

        public override string ToString()
        {
            string s = "";
            s += "\nVehicle Number: " + vehicleNumber;
            s += "\nMileage: " + mileage;
            s += "\nMake: " + make;
            s += "\nModel: " + model;
            return s;
        }
    }
}
