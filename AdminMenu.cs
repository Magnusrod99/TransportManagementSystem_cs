// Author: Magnus
// RollNo: 2628

using System.Globalization;

public class AdminMenu
{
    public void ShowMenu()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("===TRANSPORT SYSTEM=== :Admin");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Manage Transport Modes");
            Console.WriteLine("2. Manage Vehicles");
            Console.WriteLine("3. Manage Routes");
            Console.WriteLine("4. Manage Schedules");
            Console.WriteLine("5. View Bookings");
            Console.WriteLine("6. Exit");
            Console.WriteLine("enter your choice");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                choice = 0;
                continue;
            }

            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("\n--- ADD TRANSPORT MODE ---");
                    if (!TryReadInt("Enter Mode ID: ", out int modeId)) break;

                    Console.Write("Enter Mode Name: ");
                    string modeName = Console.ReadLine() ?? "";

                    TransportMode mode = new TransportMode(modeId, modeName);
                    Console.WriteLine("\nTransport mode added successfully!");
                    mode.DisplayMode();
                    break;
                }

                case 2:
                {
                    Console.WriteLine("\n--- ADD VEHICLE ---");
                    if (!TryReadInt("Enter Vehicle ID: ", out int vehicleId)) break;

                    Console.Write("Enter Vehicle Name: ");
                    string vehicleName = Console.ReadLine() ?? "";

                    Console.Write("Enter Vehicle Type: ");
                    string vehicleType = Console.ReadLine() ?? "";

                    Console.Write("Enter Vehicle Number: ");
                    string vehicleNumber = Console.ReadLine() ?? "";

                    if (!TryReadInt("Enter Vehicle Capacity: ", out int capacity)) break;

                    Vehicle vehicle = new Vehicle(
                        vehicleId, vehicleName, vehicleType, vehicleNumber, capacity
                    );

                    Console.WriteLine("\nVehicle added successfully!");
                    vehicle.DisplayVehicle();

                    Transport transport = vehicle; // Polymorphism
                    transport.StartJourney();
                    break;
                }

                case 3:
                {
                    Console.WriteLine("\n--- ADD ROUTE ---");
                    if (!TryReadInt("Enter Route ID: ", out int routeId)) break;

                    Console.Write("Enter Source: ");
                    string source = Console.ReadLine() ?? "";

                    Console.Write("Enter Destination: ");
                    string destination = Console.ReadLine() ?? "";

                    if (!TryReadDouble("Enter Distance in km: ", out double distance)) break;

                    Route route = new Route(routeId, source, destination, distance);
                    Console.WriteLine("\nRoute added successfully!");
                    route.DisplayRoute();
                    break;
                }

                case 4:
                {
                    Console.WriteLine(" ADD SCHEDULE ");
                    if (!TryReadInt("Enter Schedule ID: ", out int scheduleId)) break;
                    if (!TryReadInt("Enter Vehicle ID: ", out int scheduleVehicleId)) break;
                    if (!TryReadInt("Enter Route ID: ", out int scheduleRouteId)) break;

                    Console.Write("Enter Departure Time: ");
                    string departureTime = Console.ReadLine() ?? "";

                    Console.Write("Enter Arrival Time: ");
                    string arrivalTime = Console.ReadLine() ?? "";

                    Schedule schedule = new Schedule(
                        scheduleId, scheduleVehicleId, scheduleRouteId,
                        departureTime, arrivalTime
                    );

                    Console.WriteLine("Schedule added successfully!");
                    schedule.DisplaySchedule();
                    break;
                }

                case 5:
                    Console.WriteLine(" opening view bookings ....");
                    break;

                case 6:
                    Console.WriteLine("exiting thank you ....");
                    break;

                default:
                    Console.WriteLine("error please enter the number from the given choice ");
                    break;
            }

            Console.WriteLine();
        } while (choice != 6);
    }

    private static bool TryReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out value))
        {
            return true;
        }

        Console.WriteLine("Invalid input. Please enter a whole number.");
        return false;
    }

    private static bool TryReadDouble(string prompt, out double value)
    {
        Console.Write(prompt);
        string input = Console.ReadLine() ?? "";
        if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out value) ||
            double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
        {
            return true;
        }

        Console.WriteLine("Invalid input. Please enter a number.");
        return false;
    }
}
