// See https://aka.ms/new-console-template for more information
// Vehicle v = new Vehicle("Fake", "Black")
/* Abstract class is a blueprint and cannot make an instance just like interface */
List<Vehicle> l = new List<Vehicle>{
    new Car("Diesel"),
    new Horse("Grass"),
    new Bicycle()
};
List<INeedFuel> arr = new List<INeedFuel>();
l.ForEach(item=> {if (item is INeedFuel)arr.Add((INeedFuel)item);});
arr.ForEach(item=> item.GiveFuel(10));
l.ForEach(item=>item.ShowInfo());