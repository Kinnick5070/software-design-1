public class Book {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Book (string name, decimal price) {
        this.Name = name;
        this.Price = price;
    }

    public override string ToString() {
        return $"Book Name: {Name}, Price: {Price:C}";
    }
}