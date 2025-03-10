public class Book {
    public string Name {get; set;}
    public decimal Price {get; set;}

    public Book (string BookName, decimal BookPrice){
        this.Name = BookName;
        this.Price = BookPrice;
    }

    public override string ToString(){
        return $"Book Name: {Name}, Price: {Price:C}";
    }


}