// See https://aka.ms/new-console-template for more information
List<Drink> AllBeverages = new List<Drink>{
    new Soda(false),
    new Coffee("medium","Layo Teraga Hawata"),
    new Wine("Uraga, Guji", 1500)
};
AllBeverages.ForEach(item=>item.ShowDrink());
// Coffee MyDrink = new Soda(true);
/**
 * Basically we don't have the same base type
 * If we want to be able to convert Soda to coffee,
 * We need to agree on 1 interface
 * But Soda is superior so no don't do it
 */