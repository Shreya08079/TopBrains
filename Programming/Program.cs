using System;
public class Program{
    static void Main(){
        Console.WriteLine("Enter a number: ");
        int x = int.Parse(Console.ReadLine());

        if(x>1 && !IsPrime(x) && IsLuckyNumber(x)){
            Console.WriteLine($"{x} is lucky number");
        }
        else{
            Console.WriteLine($"{x} not a lucky number");
        }
    }

    public static bool IsLuckyNumber(int x){
        int sumN = SumOfDigits(x);
        int square = x* x;
        int sumSquare = SumOfDigits(square);

        return sumSquare == sumN * sumN;
    }

    public static int SumOfDigits(int n){
        int sum =  0;
        while(n>0){
            sum+= n%10;
            n/=10;
        }   
        return sum;
        }

    public static bool IsPrime(int n){
        if(n<=1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

}