// See https://aka.ms/new-console-template for more information
Random rng = new Random();
void CoinFlip(){ 
    Console.WriteLine(rng.Next(2)==0?"Head":"Tail");
}
CoinFlip();
int DiceRoll(int sides = 6){
    return rng.Next(1,sides+1);
}
Console.WriteLine(DiceRoll());

List<int> StatRoll(int times){
    return Enumerable.Range(1, times).Select(meh=>DiceRoll()).ToList();
}
Console.WriteLine(String.Join(", ", StatRoll(4)));

string RollFor(int target, int sides = 6){
    if (target > sides)
        return "That outcome is impossible for {sides} dice";
    int count = 0;
    while(DiceRoll()!=target)
        count++;
    return $"Rolled a {target} after {count} tries";
}
Console.WriteLine(RollFor(1));

Console.WriteLine("Now, how many side dice do you want to roll?");
int sides;
while(true)
    if (int.TryParse(Console.ReadLine(), out sides))
        break;
    else
        Console.WriteLine("Take your time...");
while(true){
    Console.WriteLine($"Dice Rolled: {DiceRoll(sides)}");
    Console.WriteLine("Are you satisfied with this result?");
    string? input = Console.ReadLine();
    if (input?.Equals("y") == true || input?.Equals("yes") == true)
        break;
}
