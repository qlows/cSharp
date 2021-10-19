using System;
using System.Collections.Generic;
using System.Text;

namespace mockexam
{
    class Hatchback : Car
    {
        private bool foldableSeats;
        public Hatchback(int vin, int mileage, string make, string model, int seats, bool foldable) :
            base(vin, mileage, make, model, seats)
        {
            foldableSeats = foldable;
        }

        public bool hasFoldableSeats() { return foldableSeats; }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\nSubtype: Hatchback";
            s += "\nFoldable seats: " + foldableSeats;
            return s;
        }
    }
}
