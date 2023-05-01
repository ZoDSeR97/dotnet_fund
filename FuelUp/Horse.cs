class Horse:Vehicle, INeedFuel{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; } = 10;
    public Horse(string FuelType) : base("Horse", 2, "White", false){
        this.FuelType = FuelType;
    }
    public Horse(string FuelType, int FuelTotal) : base("Horse", 2, "White", false){
        this.FuelType = FuelType;
        this.FuelTotal = FuelTotal;
    }
    public override void ShowInfo() => Console.WriteLine($"""
    ------------------------------------------------
        Name: {this.name}
        Color: {this.color}
        Capacity: {this.num_Passengers} people
        Has_Engine: {this.hasEngine}
        Traveled: {this.miles} miles
        Fuel Type: {this.FuelType}
        Fuel Total: {this.FuelTotal}
    """);
    public void GiveFuel(int Amount) => this.FuelTotal += Amount;
}