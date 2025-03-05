
Airplane plane = new Airplane("Chris",30000, 100);

Console.WriteLine($"\n Name: {plane.Name}\n");
plane.Fly(8000);

Console.WriteLine($"{plane.Name} fuel level: {plane.FuelLevel}");

decimal NewFuel = plane.Refuel(50);

Console.WriteLine($"{plane.Name} fuel level: {NewFuel}");