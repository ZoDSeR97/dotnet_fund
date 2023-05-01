// See https://aka.ms/new-console-template for more information
List<Vehicle> l = new List<Vehicle>{
    new Vehicle("RealCar", "Gray"),
    new Vehicle("Honda CBR 1000RR",2,"Red", true),
    new Vehicle("Uni-cycle",1,"Black", false),
    new Vehicle("Lambo",2,"Yellow", true)
};
l[2].ShowInfo();
l[2].Travel(100);
l[2].ShowInfo();
//l[2].miles = 350;
/**
 * Attribute is private will prevent vilation Ecapsulation
 * Does not really matter much in grand scheme
 * If you really want to protect something, there won't be a setter in first place
 */