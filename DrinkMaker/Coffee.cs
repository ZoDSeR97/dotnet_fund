class Coffee:Drink{
    string roast;
    string bean;
    public Coffee(string roast, string bean):base("Coffee", "Black", 18, false, 2){
        this.roast = roast;
        this.bean = bean;
    }
    public override void ShowDrink() => Console.WriteLine($"""
    ------------------------------------------
        Name: {this.Name}
        Color: {this.Color}
        Temperature: {this.Temperature}
        Calories: {this.Calories}
        Bean used: {this.bean}
        Roast: {this.roast}
        Cabornated drink? {this.IsCarbonated}
    """);
}