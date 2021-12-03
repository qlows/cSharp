using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class classMenu

    {
        Manager m = new Manager();
        public void mainMenu()
        {
            int input;
            bool error;
            


            Console.Clear();
            Console.WriteLine("XYZ Airlines Limited.");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1: Customers");
            Console.WriteLine("2: Flights");
            Console.WriteLine("3: Bookings");
            Console.WriteLine("4: Exit");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        customerMenu();
                        break;
                    case 2:
                        flightMenu();
                        break;
                    case 3:
                        bookingMenu();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);

        }
        public void customerMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Customer Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Add Customer");
            Console.WriteLine("2. View Customers");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        // add customer function
                        break;
                    case 2:
                        // view customer function
                        break;
                    case 3:
                        // delete customer function
                        break;
                    case 4:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }

        public void flightMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Flight Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Add Flights");
            Console.WriteLine("2. View Flights");
            Console.WriteLine("3. View a particular Flight");
            Console.WriteLine("4. Delete Flight");
            Console.WriteLine("5. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        int flightNum;
                        string origin;
                        string destination;
                        int numSeats;
                        Console.WriteLine("Adding new flight...\nPlease enter the following:");
                        Console.Write("Flight Number: ");
                        flightNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Flight Origin: ");
                        origin = Console.ReadLine();
                        Console.Write("Flight Destination: ");
                        destination = Console.ReadLine();
                        Console.Write("Number of Seats: ");
                        numSeats = Convert.ToInt32(Console.ReadLine());
                        m.addFlight(flightNum, origin, destination, numSeats);
                        Console.WriteLine("\nPress any key to go back to the Flight Menu...");
                        Console.ReadKey();
                        flightMenu();
                        break;
                    case 2:
                        //View all flights
                        Console.WriteLine(m.viewAllFlights());
                        break;
                    case 3:
                       /* findParticularFlight();*/
                        break;
                    case 4:
                        /*int delete;
                        deleteFlight();*/
                        break;
                    case 5:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }

        public void bookingMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Booking Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Make Booking");
            Console.WriteLine("2. View Bookings");
            Console.WriteLine("3. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        // add booking function
                        break;
                    case 2:
                        // view booking function
                        break;
                    case 3:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }
    }
}
