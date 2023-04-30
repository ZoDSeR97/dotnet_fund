package JavaVersion;
import java.util.Random;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.Arrays;
import java.util.Collections;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/**
 * Fundamental
 *  List, Map, Set, Collector (singular) are interfaces. 
 *  Importing them are quite useless 
 *  Unless:
 *      1. you just do not know the type 
 *      2. want to support type only
 */
public class Fundamental {
    /** 
     * Here we use List as parameter type
     * Because we do not care
     * Whether it is ArrayList or LinkedList, etc.
     * As we wrote operation that will work with base Interface
     * Not optimize to any specific Data Structure.
     */
    public static void PrintList(List<String> MyList){
        // Your code here
        System.out.println(MyList.toString());
    }
    
    public static void SumOfNumbers(List<Integer> IntList) {
        // Your code here
        System.out.println(IntList.stream().mapToInt(Integer::intValue).sum());
    }
    public static int FindMax(List<Integer> IntList){
        // Your code here
        return Collections.max(IntList);
    }
    public static List<Integer> SquareValues(List<Integer> IntList){
        // Your code here
        return IntList.stream().map(item -> item*item).collect(Collectors.toList());
    }
    public static int[] NonNegatives(int[] IntArray){
        // Your code here
        return Arrays.stream(IntArray).map(item -> item < 0 ? 0:item).toArray();
    }
    /**
     * Here, we can accomplish the same thing using Map interface
     * it just cost an import
     */
    public static void PrintHashMap(HashMap<String, String> MyHashMap){
        // Your code here
        MyHashMap.forEach((key, value)->System.out.println(key+": "+value+","));
    }
    public static HashMap<String, Integer> GenerateHashMap(List<String> Names, List<Integer> Numbers){
        // Your code here
        return IntStream.range(0, Names.size())
                .boxed()
                .collect(Collectors.toMap(Names::get, Numbers::get, (v1, v2) -> v2, HashMap::new));
    }
    public static void main(String[] args) {
        Random rng = new Random();
        // Part I
        for (int i = 1; i < 256; i++)
            System.out.println(i);
        int result = 0;
        for (int i = 0; i < 5; i++) {
            int num = 11 + rng.nextInt(10);
            System.out.println(num);
            result+=num;
        }
        System.out.println(result);

        for (int i = 1; i < 101; i++) {
            if (i % 3 == 0 && i % 5 == 0)
                continue;
            if (i % 3 == 0 || i % 5 == 0)
                System.out.println(i);
        }

        for (int i = 1; i < 101; i++) {
            String output = "";
            if (i % 3 == 0)
                output += "Fizz";
            if (i % 5 == 0)
                output += "Buzz";
            if (!output.equals(""))
                System.out.println(output);
        }
        // Part II
        int[] iArr = new int[10];
        for (int i = 0; i < 10; i++)
            iArr[i] = i;
        String[] sArr = new String[] { "Tim", "Martin", "Nikki", "Sara" };
        boolean[] bArr = new boolean[10];
        for (int i = 0; i < bArr.length; i++)
            bArr[i] = i == 0 ? !bArr[i] : !bArr[i - 1];
        System.out.println(Arrays.toString(iArr));
        System.out.println(Arrays.toString(sArr));
        System.out.println(Arrays.toString(bArr));
        ArrayList<String> l = new ArrayList<String>(Arrays.asList("Vanila", "Chocolate", "Strawberry", "Orange", "Coconut"));
        System.out.println(l.size());
        System.out.println(l.get(2));
        l.remove(2);
        System.out.println(l.size());
        HashMap<String, String> d = new HashMap<String, String>();
        for (var name : sArr)
            d.put(name, l.get(rng.nextInt(l.size())));
        for(var name : d.keySet())
            System.out.println(String.format("%s - %s", name, d.get(name)));
        //Part III
        ArrayList<String> TestStringList = new ArrayList<String>(Arrays.asList("Harry", "Steve", "Carla", "Jeanne"));
        PrintList(TestStringList);
        ArrayList<Integer> TestIntList = new ArrayList<Integer>(Arrays.asList(2, 7, 12, 9, 3));
        // You should get back 33 in this example
        SumOfNumbers(TestIntList);
        ArrayList<Integer> TestIntList2 = new ArrayList<Integer>(Arrays.asList(-9, 12, 10, 3, 17, 5));
        // You should get back 17 in this example
        System.out.println(FindMax(TestIntList2));
        ArrayList<Integer> TestIntList3 = new ArrayList<Integer>(Arrays.asList(1, 2, 3, 4, 5));
        // You should get back [1,4,9,16,25], think about how you will show that this worked
        System.out.println(SquareValues(TestIntList3));
        int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
        // You should get back [0,2,3,0,5], think about how you will show that this worked
        System.out.println(Arrays.toString(NonNegatives(TestIntArray)));
        HashMap<String, String> TestDict = new HashMap<String, String>();
        TestDict.put("HeroName", "Iron Man");
        TestDict.put("RealName", "Tony Stark");
        TestDict.put("Powers", "Money and intelligence");
        PrintHashMap(TestDict);
        // Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a
        // dictionary
        // {
        // "Julie": 6,
        // "Harold": 12,
        // "James": 7,
        // "Monica": 10
        // }
        ArrayList<String> keys = new ArrayList<String>(Arrays.asList("Julie", "Harold", "James", "Monica"));
        ArrayList<Integer> values = new ArrayList<Integer>(Arrays.asList(6,12,7,10));
        HashMap<String, Integer> m = GenerateHashMap(keys, values);
        m.forEach((key, value) -> System.out.println(key + ": " + value + ","));
    }
}