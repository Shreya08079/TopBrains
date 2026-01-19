using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter upto: ");
        int range = int.Parse(Console.ReadLine());

        int[] result = MultiplicationTable(n, range);

        Console.WriteLine(string.Join(", ", result));
    }

    static int[] MultiplicationTable(int n, int range)
    {
        int[] row = new int[range];

        for (int i = 1; i <= range; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }
}
