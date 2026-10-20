// Author: Magnus
// RollNo: 2628

public class Route
{
    public int routeId;
    public string source;
    public string destination;
    public double distance;

    public Route(int routeId, string source, string destination, double distance)
    {
        this.routeId = routeId;
        this.source = source;
        this.destination = destination;
        this.distance = distance;
    }

    public void DisplayRoute()
    {
        Console.WriteLine(" ROUTE DETAILS ");
        Console.WriteLine("Route ID: " + routeId);
        Console.WriteLine("Source: " + source);
        Console.WriteLine("Destination: " + destination);
        Console.WriteLine("Distance: " + distance + " km");
    }
}
