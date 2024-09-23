using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers. Type 0 to stop.");

        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();

            double average = numbers.Average();
        

            int max = numbers.Max();

            Console.WriteLine($"\nThe sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            int LowestPositiveNumber = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
            if (LowestPositiveNumber > 0)
            {
                Console.WriteLine($"The smallest positive number is: {LowestPositiveNumber}");
            }
            else 
            {
            Console.WriteLine("There are no positive numbers in the list.");
            }

            numbers.Sort();
            Console.WriteLine("\nThe sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);  
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

    }
}