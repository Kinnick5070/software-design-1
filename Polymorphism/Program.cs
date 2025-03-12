List<Airplane> planeList = new List<Airplane>();

Airplane airplaneOne = new Airplane("Delta", 35000, 2);

Automobile carOne = new Automobile("AB123", 5, true);

Vehicle vehicleOne = new Vehicle();

planeList.Add(airplaneOne);

foreach(Airplane plane in planeList){
    Console.WriteLine($"{plane.Airline}");
}