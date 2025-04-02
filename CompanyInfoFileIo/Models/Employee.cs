using System.Text.Json.Serialization;

public class Employee{

    [JsonPropertyName("id")]

    public string? Id {get; set;}

    [JsonPropertyName("fullName")]

    public string? FullName {get; set;}

    [JsonPropertyName("anualSalary")]

    public decimal AnualSalary {get; set;}

    [JsonPropertyName("position")]

    public Position Position {get; set;}

    [JsonPropertyName("benefits")]

    public List <Benefit> Benefits {get; set;} = new List<Benefit>();






}