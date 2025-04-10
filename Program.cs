using System;

namespace ArrayPractice;

class Program
{
    static void Main(string[] args)
    {
        //Массив палетт под номирами сортировка
        //The array of pallets under the numbers is sorted

        string[] pallets = ["B14", "A11", "B12", "A13"];

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");

        }

        Console.WriteLine($"\nBefore: {pallets[0]}");
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"After: {pallets[0]}");

        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Console.WriteLine(value);
        foreach (var i in valueArray)
        {
            Console.Write($"\t{i}");
        }
        Console.WriteLine();
        Array.Reverse(valueArray);
        foreach (var i in valueArray)
        {
            Console.Write($"\t{i}");
        }
        string result = new string(valueArray);
        Console.WriteLine();
        Console.WriteLine(result);

        result = String.Join(",", valueArray);
        Console.WriteLine(result);


        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}
