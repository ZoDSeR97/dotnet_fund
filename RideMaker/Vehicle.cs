class Vehicle{
    string name {get; set;}
    int num_Passengers {get; set;}
    string color {get; set;}
    bool hasEngine {get; set;}
    int miles = 0;
    public Vehicle(string name, string color){
        this.name = name;
        this.color = color;
        this.num_Passengers = 4;
        this.hasEngine = true;
    }
    public Vehicle(string name, int num_Passengers, string color, bool hasEngine){
        this.name = name;
        this.num_Passengers = num_Passengers;
        this.color = color;
        this.hasEngine = hasEngine;
    }
    public void ShowInfo() => Console.WriteLine($"""
    ------------------------------------------------
        Name: {this.name}
        Color: {this.color}
        Capacity: {this.num_Passengers} people
        Has_Engine: {this.hasEngine}
        Traveled: {this.miles} miles
    """);
    public void Travel(int miles) => this.miles+=miles;
}