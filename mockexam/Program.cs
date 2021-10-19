using System;

namespace mockexam
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vm = new VehicleManager();
            vm.addVehicle(1234, 98000, "Hyundai", "Santa Fe Sport", 5); // car
            vm.addVehicle(3234, 2000, "Yatch", "Seabreeze", true); //boat
            vm.addVehicle(12231, 52341, "Lexus", "200t", 5, true, false);// sedan
            vm.addVehicle(12357, 76478, "Toyota", "Prius", 5, true); //hatchback
            Console.WriteLine(vm.printAllVehicles());
        }
    }
}
