public class Vehicle{
    public string Name {get; set;} = "Default Name";

    public int ModelYear {get; set;} = 2025;

    public string Manufacturer {get; set;} = "Default Manufacturer";

    public Vehicle(){
        Console.WriteLine("Vehicle Constructor!");
    }
}