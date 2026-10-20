// Author: Magnus
// RollNo: 2628

public class Schedule
{
    public int scheduleId;
    public int vehicleId;
    public int routeId;
    public string departureTime;
    public string arrivalTime;

    public Schedule(
        int scheduleId,
        int vehicleId,
        int routeId,
        string departureTime,
        string arrivalTime
    )
    {
        this.scheduleId = scheduleId;
        this.vehicleId = vehicleId;
        this.routeId = routeId;
        this.departureTime = departureTime;
        this.arrivalTime = arrivalTime;
    }

    public void DisplaySchedule()
    {
        Console.WriteLine(" SCHEDULE DETAILS ");
        Console.WriteLine("Schedule ID: " + scheduleId);
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Route ID: " + routeId);
        Console.WriteLine("Departure Time: " + departureTime);
        Console.WriteLine("Arrival Time: " + arrivalTime);
    }
}
