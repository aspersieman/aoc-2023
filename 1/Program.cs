using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string line;
        int total = 0;
        try
        {
            StreamReader sr = new StreamReader("./calibrations.txt");
            line = sr.ReadLine()!;
            while (line != null)
            {
                String numbers = Regex.Replace(line, "[^0-9]", "");
                Console.WriteLine(numbers);
                String first = "0";
                String last = "0";
                if (numbers.Length > 0)
                {
                    first = numbers.Substring(0, 1);
                    Console.WriteLine("First number: " + first);
                    last = numbers.Substring(numbers.Length - 1);
                    Console.WriteLine("Last number: " + last);
                }
                int number = int.Parse(first + last);
                total += number;

                line = sr.ReadLine()!;
            }
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        Console.WriteLine("Total: " + total);
    }
}
