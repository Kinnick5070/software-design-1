public class Airplane {
    public string Name {get; set;}

    public int MaximumAltitude {get; private set;}

    public decimal FuelLevel {get; private set;}

    public Airplane(string givenName, int MaxAlt, decimal Fuel){
        this.Name = givenName;
        this.MaximumAltitude = MaxAlt;
        this.FuelLevel = Fuel;

    }

    public void Fly(int altitude) {
        if(altitude > this.MaximumAltitude){
            Console.WriteLine($"{this.Name} has a max altitude of {this.MaximumAltitude}");
            
        }else if (this.FuelLevel <= 0){
        Console.WriteLine($" {this.Name} does not have fuel");

        }else {
            Console.WriteLine($"{this.Name} is flying at {altitude}");
            this.FuelLevel -= altitude * 0.001m;
        }
    }
    public decimal Refuel(decimal amount){
        if (amount <=0){
            Console.WriteLine("Refuel amount positive");
            this.FuelLevel += amount;
        }
        

        return this.FuelLevel;
    }

}