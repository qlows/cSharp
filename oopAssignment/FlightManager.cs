using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oopAssignment
{
    class FlightManager /*: Flight*/
    {
        private Flight[] flightList;
        private int numberOfFlights;
        private int maxFlights;
        private string flightNumber;

        public FlightManager()
        {
            maxFlights = 10;
            numberOfFlights = 0;
            flightList = new Flight[numberOfFlights];
        }

        public virtual void setFlightNumber(string airlineID, string number)
        {
            if (airlineID.Matches("[a-zA-Z]+$") && airlineID.Length == 2 && number.Matches("[0-9 ]+$"))
            {
                flightNumber = airlineID + number;
            }
            else
            {
                Console.WriteLine("Invalid Flight Number");
            }

        }


        /*public bool addFlight(int fn, string or, string dest, int mSeats)
        {
            if(numberOfFlights <= maxFlights)
            {
                flightList[maxFlights] = new Flight(fn, or, dest, mSeats);
                numberOfFlights++;
                return true;
            }
            return false;
        }*/
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

        /*
        public bool deleteFlight()
        {
            if(numberOfFlights >= 1)
            {

            }
        }*/

        public string _listAllFlights()
        {
            string f = "________All Flights________\n";
            for (int i = 0; i < numberOfFlights; i++)
            {
                if(numberOfFlights[i].GetType() == typeof(Flight))
                {
                    f += ((Flight)numberOfFlights[i]).ToString() + "\n";
                }
            }
        }

    }
}
