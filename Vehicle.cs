// Author: Magnus
// RollNo: 2628

public class Vehicle : Transport
{
    private int vehicleId;
    private string vehicleName;
    private string vehicleNumber;
    private int capacity;

    public Vehicle(
        int vehicleId,
        string vehicleName,
        string transportType,
        string vehicleNumber,
        int capacity
    ) : base(transportType)
    {
        this.vehicleId = vehicleId;
        this.vehicleName = vehicleName;
        this.vehicleNumber = vehicleNumber;
        this.capacity = capacity;
    }

    public int GetVehicleId()
    {
        return vehicleId;
    }

    public string GetVehicleName()
    {
        return vehicleName;
    }

    public string GetVehicleNumber()
    {
        return vehicleNumber;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    public void SetVehicleName(string vehicleName)
    {
        this.vehicleName = vehicleName;
    }

    public void SetVehicleNumber(string vehicleNumber)
    {
        this.vehicleNumber = vehicleNumber;
    }

    public void SetCapacity(int capacity)
    {
        this.capacity = capacity;
    }

    public override void StartJourney()
    {
        Console.WriteLine(vehicleName + " will be starting its journey soon.");
    }

    public void DisplayVehicle()
    {
        Console.WriteLine("\n--- VEHICLE DETAILS ---");
        Console.WriteLine("Vehicle ID: " + GetVehicleId());
        Console.WriteLine("Vehicle Name: " + GetVehicleName());
        DisplayTransportType();
        Console.WriteLine("Vehicle Number: " + GetVehicleNumber());
        Console.WriteLine("Capacity: " + GetCapacity());
    }
}
