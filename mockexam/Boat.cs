using System;
using System.Collections.Generic;
using System.Text;

namespace mockexam
{
    class Boat : Vehicle
    {
        private bool hasRadar;

        public Boat(int vin, int mileage, string make, string model, bool radar):
            base(vin, mileage, make, model)
        {
            this.hasRadar = radar;
        }
            
        public bool hasRadars() { return this.hasRadar; }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\nType: Boat";
            s += "\nRadar: " + hasRadar;
            return s;
        }
    }
}
