public class SmartBox<T> where T : Phone {
    public required string Name {get; set;}
    public required T FeaturedItem {get; set;}
    public List<T> ItemList {get; set;} = new List<T> {};

    public override string ToString()
    {
        string output = $"{this.Name} Brand: {this.FeaturedItem.Brand}| Featured Item: {this.FeaturedItem} \n";

        foreach (T elem in this.ItemList)
        {
            output += $"{elem.Name}\n";
        }

        return output;
    }
}