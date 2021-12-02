using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class Manager : classMenu
    {
        private oopAssignment.Customer[] clist;
        private int numCustomer;
        private int maxCustomer;

        private oopAssignment.Flight[] flightList;
        private int numberOfFlights;
        private int maxFlights;
        private string flightNumber;

        public Manager()
        {
            numCustomer = 0;
            maxCustomer = 100;
            clist = new Customer[maxCustomer];

           maxFlights = 10;
            numberOfFlights = 0;
            flightList = new Flight[numberOfFlights];
        }

        public bool addCustomer(string fnam, string lName, int phone)
        {
            if (numCustomer < maxCustomer)
            {
                Random rnd = new Random();
                int id = rnd.Next(10000, 99999);
                clist[maxCustomer] = new Customer(id, fnam, lName, phone);
                numCustomer++;
                return true;
            }
            return false;
        }

        public string listAllCustomers()
        {
            string s = "=== Customer List ===\n";
            for (int i = 0; i < numCustomer; i++)
            {
                if (clist[i].GetType() == typeof(Customer))
                {
                    s += ((Customer)clist[i]).ToString() + "\n";
                }
            }
            return s;
        }

        public bool addFlight(int fn, string or, string dest, int mSeats)
        {
            if (numberOfFlights <= maxFlights)
            {
                Random rnd = new Random();
                int id = rnd.Next(10000, 99999);
                flightList[numberOfFlights] = new Flight(fn, or, dest, mSeats);
                numberOfFlights++;
                return true;
            }
            return false;
        }

        public string viewAllFlights()
        {
            string s = "=== All Flight List ===\n";
            for (int i = 0; i < numberOfFlights; i++)
            {
                if(flightList[i].GetType() == typeof(Flight))
                {
                    s += ((Flight)flightList[i]).ToString() + "\n";
                }
            }
            return s;
        }

       /* public string viewParticularFlight()
        {
            string s = "=== Viewing Particular Flight ===\n";

        }*/
    }
}
