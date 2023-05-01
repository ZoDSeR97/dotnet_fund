abstract class Vehicle{
    // your code here
    protected string name {get;}
    protected int num_Passengers {get;}
    protected string color {get;}
    protected bool hasEngine {get;}
    protected int miles {get; private set;} = 0;
    public Vehicle(string name, string color)
    {
        this.name = name;
        this.color = color;
        this.num_Passengers = 4;
        this.hasEngine = true;
    }
    public Vehicle(string name, int num_Passengers, string color, bool hasEngine)
    {
        this.name = name;
        this.num_Passengers = num_Passengers;
        this.color = color;
        this.hasEngine = hasEngine;
    }
    public abstract void ShowInfo();
    public void Travel(int miles) => this.miles += miles;
}

