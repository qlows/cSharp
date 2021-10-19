using System;
using System.Collections.Generic;
using System.Text;

namespace mockexam
{
    class VehicleManager
    {
        private Vehicle[] vehicleList;
        private int numVehicles;
        private int maxVehicles;

        public VehicleManager()
        {
            maxVehicles = 100;
            numVehicles = 0;
            vehicleList = new Vehicle[maxVehicles];
        }

        public void addVehicle(int vin, int mileage, string make, string model, int seats)
        {
            if(numVehicles < maxVehicles)
            {
                vehicleList[numVehicles] = new Car(vin, mileage, make, model, seats);
                numVehicles++;
            }
        }
        public void addVehicle(int vin, int mileage, string make, string model, int seats, bool foldable)
        {
            if (numVehicles < maxVehicles)
            {
                vehicleList[numVehicles] = new Hatchback(vin, mileage, make, model, seats, foldable);
                numVehicles++;
            }
        }

        public void addVehicle(int vin, int mileage, string make, string model, int seats, bool backseatFridge, bool backseatRecliner)
        {
            if (numVehicles < maxVehicles)
            {
                vehicleList[numVehicles] = new Sedan(vin, mileage, make, model, seats, backseatFridge, backseatRecliner);
                numVehicles++;
            }
        }

        public void addVehicle(int vin, int mileage, string make, string model, bool radar)
        {
            if (numVehicles < maxVehicles)
            {
                vehicleList[numVehicles] = new Boat(vin, mileage, make, model, radar);
                numVehicles++;
            }
        }

        public string printAllVehicles()
        {
            string s = "-- Vehicle List --";
            for (int x = 0; x < numVehicles; x++)
            {
                s += "\n" + vehicleList[x].ToString();
            }
            return s;
        }
    }
}
