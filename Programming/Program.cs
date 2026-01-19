using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter second Number: ");
        int end = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (i > 1 && !IsPrime(i) && IsLuckyNumber(i))
            {
                count++;
            }
        }

        Console.WriteLine($"Lucky numbers count: {count}");
    }

    static bool IsLuckyNumber(int x)
    {
        int sumX = SumOfDigits(x);
        int sumSquare = SumOfDigits(x * x);

        return sumSquare == sumX * sumX;
    }

    static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
