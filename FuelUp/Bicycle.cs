class Bicycle:Vehicle{
    public Bicycle() : base("Bicycle", 2, "Gray", false){}
    public override void ShowInfo() => Console.WriteLine($"""
    ------------------------------------------------
        Name: {this.name}
        Color: {this.color}
        Capacity: {this.num_Passengers} people
        Has_Engine: {this.hasEngine}
        Traveled: {this.miles} miles
    """);
}