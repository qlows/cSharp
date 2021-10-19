using System;
using System.Collections.Generic;
using System.Text;

namespace mockexam
{
    class Car : Vehicle
    {
        protected int seats; 

        public Car(int vin, int mileage, string make, string model, int seats):
            base(vin, mileage, make, model)
        {
            this.seats = seats;
        }

        public int getSeats() { return seats; }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\nType: Car";
            s += "\nNumber of Seats: " + seats;
            return s;
        }
    }
}
