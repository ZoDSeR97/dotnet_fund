class Car:Vehicle, INeedFuel{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; } = 10;
    public Car(string FuelType) : base("Car", 4, "Gray", true){
        this.FuelType = FuelType;
    }
    public Car(string FuelType, int FuelTotal):base("Car", 4, "Gray", true){
        this.FuelType = FuelType;
        this.FuelTotal = FuelTotal;
    }
    public override void ShowInfo()=> Console.WriteLine($"""
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