using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();

            if (int.Parse(num) == 0)
            {
                break;
            }
            numbers.Add(int.Parse(num));
        }

        int sum = 0;
        float average = 0.0f;
        int largestNumber = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        average = sum / numbers.Count;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}