using System;
namespace deliverable3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter and integer number between 1 and 100:");
        int input = int.Parse(Console.ReadLine());

        Console.Write("Specify the series type :Even of Odd");
        string series = Console.ReadLine();

        if (series == "Odd")
        {
            Console.Write("You have selected" + series + " series. The numbers between 0 and " + input + "are:");
            for (int i = 1; i < input; i = i + 2)
            {
                Console.WriteLine(i);
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected" + series + "series. The numbers between 0 and" + input + "are:");
                for (int i = 0; i < input; i = i +2)
                {
                    Console.WriteLine(i);
                }


            }

            {

            }
        }
    }
}
