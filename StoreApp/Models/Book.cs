public class Book {
    public string Name {get; set;}
    public decimal Price {get; set;}

    public Book (string BookName, decimal BookPrice){
        this.Name = BookName;
        this.Price = BookPrice;
    }

    public string ToString(string Name, decimal Price){
        string ReturnValue = Name + "," + Price;
        return ReturnValue;
    }


}