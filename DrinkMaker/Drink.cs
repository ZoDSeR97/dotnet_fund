public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;

    // We need a basic constructor that takes all these features in
    public Drink(string name, string color, double temp, bool isCarb, int calories){
        this.Name = name;
        this.Color = color;
        this.Temperature = temp;
        this.IsCarbonated = isCarb;
        this.Calories = calories;
    }
    public virtual void ShowDrink()=>Console.WriteLine($"""
    ------------------------------------------
        Name: {this.Name}
        Color: {this.Color}
        Temperature: {this.Temperature}
        Calories: {this.Calories}
        Cabornated drink? {this.IsCarbonated}
    """);
}

