public class Game {
    public string? Name {get; set;}
    public decimal Price {get; set;}

    public Game (){}

    public Game (string name, decimal price){
        this.Name = name;
        this.Price = price;
    }

    public override string ToString(){
        return $"Game Name: {Name}, Price: {Price:C}";
    }


}