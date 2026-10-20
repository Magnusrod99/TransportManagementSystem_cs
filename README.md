# Transport Management System — C#

**Author:** Magnus  
**Roll No:** 2628

C# console implementation of the Transport Management System, based on the supplied Java program.

## Classes
- `Transport` — abstract base class with `StartJourney()`.
- `Vehicle` — inherits from `Transport` and overrides `StartJourney()`.
- `TransportMode` — stores and displays transport mode details.
- `Route` — stores route details.
- `Schedule` — stores schedule details.
- `AdminMenu` — provides the console menu.
- `Program` — application entry point.

## Run in VS Code
Open the terminal in this folder and run:

```powershell
dotnet run
```

## Notes
- The View Bookings option is a placeholder, matching the Java reference.
- Records are displayed after input but are not persisted for later viewing.
- Save the program-output screenshot in the `output` folder.
