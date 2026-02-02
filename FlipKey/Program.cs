using System;
using System.Text;

class Program
{
    public string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return string.Empty;
        }

        foreach (char ch in input)
        {
            if (!char.IsLetter(ch))
            {
                return string.Empty;
            }
        }

        input = input.ToLower();

        StringBuilder filtered = new StringBuilder();
        foreach (char ch in input)
        {
            if ((int)ch % 2 != 0)
            {
                filtered.Append(ch);
            }
        }

        char[] arr = filtered.ToString().ToCharArray();
        Array.Reverse(arr);

        // Convert even index characters to uppercase
        for (int idx = 0; idx < arr.Length; idx++)
        {
            if (idx % 2 == 0)
            {
                arr[idx] = char.ToUpper(arr[idx]);
            }
        }

        return new string(arr);
    }

    static void Main()
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        Program obj = new Program();
        string result = obj.CleanseAndInvert(input);

        if (result == string.Empty)
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("The generated key is - " + result);
        }
    }
}
