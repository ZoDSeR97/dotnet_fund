class Wine:Drink{
    string region;
    int year;
    public Wine(string region, int year):base("Wine", "Deep purple", 10, false, 77){
        this.region = region;
        this.year = year;
    }
    public override void ShowDrink() => Console.WriteLine($"""
    ------------------------------------------
        Name: {this.Name}
        Color: {this.Color}
        Temperature: {this.Temperature}
        Calories: {this.Calories}
        Came from: {this.region}
        Year: {this.year}
        Cabornated drink? {this.IsCarbonated}
    """);
}