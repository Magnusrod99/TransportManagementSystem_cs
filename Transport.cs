// Author: Magnus
// RollNo: 2628

public abstract class Transport
{
    protected string transportType;

    public Transport(string transportType)
    {
        this.transportType = transportType;
    }

    public void DisplayTransportType()
    {
        Console.WriteLine("Transport Type: " + transportType);
    }

    public abstract void StartJourney();
}
