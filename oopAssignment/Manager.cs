using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class Manager
    {
        private oopAssignment.Customer[] clist;
        private oopAssignment.Booking[] blist;
        private oopAssignment.Flight[] flightList;
        private int numberOfCustomer;
        private int numberOfBookings;
        private int numberOFlight;
        private int maxBookings;
        private int maxCustomer;
        private int numberOfFlights;
        private int maxFlights;
        private string flightNumber;
        private int maxSeats;
        private int numberOfSeats;


        public Manager()
        {
            numberOfSeats = 0;
            maxSeats = 1000;
            numberOfCustomer = 0;
            numberOfBookings = 0;
            numberOfFlights = 0;
            maxBookings = 99999;
            maxFlights = 99999;
            maxCustomer = 100;
            clist = new Customer[maxCustomer];

            maxFlights = 999999;
            numberOfFlights = 0;
            flightList = new Flight[numberOfFlights];
        }

        public bool addCustomer(string fnam, string lName, int phone)
        {
            if (numberOfCustomer < maxCustomer)
            {
                Random rnd = new Random();
                int id = rnd.Next(10000, 99999);
                clist[maxCustomer] = new Customer(id, fnam, lName, phone);
                numberOfCustomer++;
                return true;
            }
            return false;
        }

        public string listAllCustomers()
        {
            string s = "=== Customer List ===\n";
            for (int i = 0; i < numberOfCustomer; i++)
            {
                if (clist[i].GetType() == typeof(Customer))
                {
                    s += ((Customer)clist[i]).ToString() + "\n";
                }
            }
            return s;
        }

        //Function to add flight
        public bool addFlight(int fn, string or, string dest, int mSeats)
        {
            flightList[maxSeats] = new Flight(fn, or, dest, mSeats);
            maxSeats++;
            return true;
        }
        /* public bool addFlight(int fn, string or, string dest, int mSeats)
         {
             if (numberOfFlights <= maxFlights)
             {
                 Random randomFlight = new Random();
                 int id = randomFlight.Next(10000, 99999);
                 flightList[numberOfFlights] = new Flight(fn, or, dest, mSeats);
                 numberOfFlights++;
                 return true;
             }
             return false;
         }*/

        //Function to view all flights
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

        //Function to display a particular flight
        public int findParticularFlight(int flightID)
        {
            for(int i = 0; i < maxFlights; i++)
            {
                if (flightList[i].getFlightNumber() == flightID);
                return i;
            }
            return -1;
        }

        //Function to delete flight
        public bool deleteFlight(int flightID)
        {
            int finder = findParticularFlight(flightID);
            if(finder == -1) { return false; }
            flightList[finder] = flightList[numberOfFlights - 1];
            numberOfFlights--;
            return true;
        }
    }
}
