using System;

namespace SimpleFIRECalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new FIRECalculatorApp();
            do
            {
                app.Start();
                Console.WriteLine("Calculate again (y/n)?");
            }
            while (Console.ReadLine().ToLower().Equals("y"));
            Console.WriteLine(StandardMessages.ApplicationExitMessage());
        }
    }
}
