using System;
using System.Collections.Generic;
using System.Text;

namespace mockexam
{
    class Sedan : Car
    {
        private bool backseatFridge;
        private bool backseatRecliner;

        public Sedan(int vin, int mileage, string make, string model, int seats, bool bckSeatFridge, bool bckSeatRecliner):
            base(vin, mileage, make, model, seats)
        {
            backseatFridge = bckSeatFridge;
            backseatRecliner = bckSeatRecliner;
        }
        
        public bool hasFridge() { return backseatFridge; }
        public bool hasRecliner() { return backseatFridge; }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\nFridge: " + backseatFridge;
            s += "\nRecliner: " + backseatRecliner;
            return s;
        }
    }
}
