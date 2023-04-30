// See https://aka.ms/new-console-template for more information
Random rng = new Random();
// Fundamental I
/* Print all number from 1 to 255 */
for (int i = 1; i < 256; i++)
    Console.WriteLine(i);

/* Print 5 Random Number and their sum */
int result = 0;
for (int i = 0; i < 5; i++){
    int num = rng.Next(11,20); // In between 10 and 20 mean (10,20) so [11, 19]
    Console.WriteLine(num); 
    result += num;
}
Console.WriteLine(result);

/** 
 * Print all number that is either 
 * Divisible by 3 or 5 only
 */
for (int i = 1; i < 101; i++){
    if(i%3==0 && i%5==0)
        continue;
    if(i%3==0 || i%5==0)
        Console.WriteLine(i);
}

/* The basic FizzBuzz problem */
for (int i = 1; i < 101; i++){
    string output = "";
    if(i%3==0)
        output+="Fizz";
    if(i%5==0)
        output+="Buzz";
    if(!output.Equals(""))
        Console.WriteLine(output);
}

// Fundamental II
/* Make int[10] and initialize it base on idx */
int[] iArr = new int[10];
for (int i = 0; i < 10; i++)
    iArr[i] = i;
/* Make static string[] in 1 line */
string[] sArr = new string[]{"Tim", "Martin", "Nikki", "Sara"};
/* Make a flip flop boolean[10] */
bool[] bArr = new bool[10];
for (int i = 0; i < bArr.Length; i++)
    bArr[i] = i == 0 ? !bArr[i]:!bArr[i-1];
/* Print all three array */
Array.ForEach(iArr, Console.WriteLine);
Array.ForEach(sArr, Console.WriteLine);
Array.ForEach(bArr, Console.WriteLine);

/* Given a static List remove 3rd element */
List<string> l = new List<string>{"Vanila", "Chocolate", "Strawberry", "Orange", "Coconut"};
Console.WriteLine(l.Count);
Console.WriteLine(l[2]);
l.RemoveAt(2);
Console.WriteLine(l.Count);

/** 
 * Construct a dictionary with sArr as key and previous List as value
 * Value is randomly chosen from List
 * Print all entry to verify
 */
Dictionary<string,string> d = new Dictionary<string, string>{};
foreach(var name in sArr)
    d.Add(name,l[rng.Next(0,l.Count)]);
foreach (KeyValuePair<string, string> entry in d)
    Console.WriteLine($"{entry.Key} - {entry.Value}");

// Fundamental III
/* Self explainatory make function and test them */
static void PrintList(List<string> MyList)
{
    // Your code here
    MyList.ForEach(item=>Console.WriteLine(item));
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

static void SumOfNumbers(List<int> IntList)
{
    // Your code here
    Console.WriteLine(IntList.Sum());
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);

static int FindMax(List<int> IntList)
{
    // Your code here
    return IntList.Max();
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

static List<int> SquareValues(List<int> IntList)
{
    // Your code here
    return IntList.Select(item => item * item).ToList(); ;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
Console.WriteLine(string.Join(", ", SquareValues(TestIntList3)));

static int[] NonNegatives(int[] IntArray)
{
    // Your code here
    return IntArray.Select(item => item < 0 ? 0:item).ToArray();
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
Console.WriteLine(string.Join(", ", NonNegatives(TestIntArray)));

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    // Your code here
    Console.WriteLine(string.Join(", ", MyDictionary.Select(item => item.Key + ": " + item.Value)));
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    // Your code here
    return MyDictionary.ContainsKey(SearchTerm);
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
    return Names.Select((name, idx)=>new {Key = name, Value = Numbers[idx]}).ToDictionary(item=>item.Key, item=>item.Value);
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<string> keys = new List<string>{"Julie", "Harold", "James", "Monica"};
List<int> values = new List<int>{6,12,7,10};
Dictionary<string, int> d2 = GenerateDictionary(keys, values);
Console.WriteLine(string.Join("\n", d2.Select(item => item.Key + ": " + item.Value)));