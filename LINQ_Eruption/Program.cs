// See https://aka.ms/new-console-template for more information
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
List<Eruption> result = new List<Eruption>();

/* Getting first element */
Eruption? FirstEruption = eruptions.Select(item => item).First();
if (FirstEruption!=null){
    result.Add(FirstEruption); 
    PrintEach(result, "First Element in List");
    result.Clear();
}else
    Console.WriteLine("List is empty");

/* Getting first "Hawaiian Is" location */
Eruption? firstHawaiianIs = eruptions.Where(item => String.Compare(item.Location, "Hawaiian Is") == 0).FirstOrDefault();
if(firstHawaiianIs != null){
    result.Add(firstHawaiianIs);
    PrintEach(result, "First Hawaiian Is location");
}else{
    Console.WriteLine("No Hawaiian Is Eruption found");
}
result.Clear();

/* Getting first "Greenland" location */
Eruption? firstGreenland = eruptions.Where(item => String.Compare(item.Location, "Greenland") == 0).FirstOrDefault();
if (firstGreenland != null)
{
    result.Add(firstGreenland);
    PrintEach(result, "First Greenland location");
}
else
{
    Console.WriteLine("No Greenland Eruption found");
}
result.Clear();

/* Getting first "New Zealand" location */
Eruption? firstZealand1900 = eruptions.Where(item => String.Compare(item.Location, "New Zealand") == 0 && item.Year > 1900)
    .FirstOrDefault();
if (firstZealand1900 != null)
{
    result.Add(firstZealand1900);
    PrintEach(result, "First New Zealand location after 1900");
}
else
{
    Console.WriteLine("No Eruption found");
}
result.Clear();

/* All eruption where elevation is over 2000m */
if(eruptions.Count>0)
    PrintEach(eruptions.Where(item => item.ElevationInMeters > 2000), "All eruption over 2000m elevation");
else
    Console.WriteLine("No Eruption over 2000m elevation");

/* All vocano's name starts with 'L' */
List<Eruption> LVolcano = eruptions.Where(item=>char.Equals(item.Volcano[0],'L')).ToList();
if(LVolcano.Count>0)
    PrintEach(LVolcano, "All volcano's name start with 'L'");
else
    Console.WriteLine("No volcano's name start with 'L'");

/* Find max elevation */
if(eruptions.Count>0){
    int highest = eruptions.Max(item => item.ElevationInMeters);
    Console.WriteLine($"Max Elevation: {highest}" );
    Console.WriteLine($"Volcano: {eruptions.FirstOrDefault(item=>item.ElevationInMeters==highest)?.Volcano}");
}
/* Print all Volcanoes name alphabetically */
if(eruptions.Count>0){
    List<string> AllVolcano = eruptions.Select(item=>item.Volcano).Order().ToList();
    Console.WriteLine($"Aphabetically Name: {String.Join(", ", AllVolcano)}");
}

/* Sum all Elevation */
if(eruptions.Count>0)
    Console.WriteLine($"Sum all elevation: {eruptions.Sum(item=>item.ElevationInMeters)}");

/* Any volcano erupted in 2000 */
if(eruptions.Count>0)
    if(eruptions.Any(item=>item.Year==2000))
        Console.WriteLine("Volcano does erupt in 2000");
    else
        Console.WriteLine("No Volcano erupt in 2000");

/* First three Stratovolcanoes */
PrintEach(stratovolcanoEruptions.Take(3), "First three Stratovolcanoes");

/* All eruptions that happend before 1000 alphabetically */
PrintEach(stratovolcanoEruptions.Where(item=>item.Year<1000).OrderBy(item=>item.Volcano), "Alphabetically Volcano name before 1000");

/* Redo last query to print only name */
Console.WriteLine(String.Join(", ", (stratovolcanoEruptions.Where(item=>item.Year<1000).OrderBy(item=>item.Volcano)).Select(item=>item.Volcano)));

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}