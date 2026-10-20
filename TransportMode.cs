// Author: Magnus
// RollNo: 2628

public class TransportMode
{
    private int modeId;
    private string modeName;

    public TransportMode(int modeId, string modeName)
    {
        this.modeId = modeId;
        this.modeName = modeName;
    }

    public void DisplayMode()
    {
        Console.WriteLine("Mode id : " + modeId);
        Console.WriteLine("Mode name : " + modeName);
    }
}
