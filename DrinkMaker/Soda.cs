class Soda:Drink{
    bool diet = false;
    public Soda(bool diet) : base("Soda", "transparent", 18, true, 150){
        this.diet = diet;
    }
    public override void ShowDrink() => Console.WriteLine($"""
    ------------------------------------------
        Name: {this.Name}
        Color: {this.Color}
        Temperature: {this.Temperature}
        Calories: {this.Calories}
        Diet drink? {this.diet}
        Cabornated drink? {this.IsCarbonated}
    """);
}