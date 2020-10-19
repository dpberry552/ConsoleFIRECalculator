using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFIRECalculator
{
    public class FIRECalculatorApp
    {
        decimal _annualExpenses;
        decimal _withdrawalRate;

        public void Start()
        {
            Console.WriteLine(StandardMessages.ApplicationStartMessage());
            Console.WriteLine("Press Enter to start...");
            Console.ReadLine();
            _annualExpenses = GetUserNumberInput("number for annual expenses");
            _withdrawalRate = Decimal.Divide(GetUserNumberInput("desired withdrawal rate"), 100);
            CalculateFIRENumber();
        }

        private decimal GetUserNumberInput(string description)
        {
            bool inputValid = true;
            string input;
            do
            {
                if (!inputValid) Console.WriteLine(StandardMessages.InvalidInputMessage(description));
                Console.Write("Please enter your " + description + ": ");
                input = Console.ReadLine();
                inputValid = Validator.IsValidDecimal(input);
            }
            while (!inputValid);

            return decimal.Parse(input);
        }

        private void CalculateFIRENumber()
        {
            var fireNumber = Decimal.Divide(_annualExpenses, _withdrawalRate);
            Console.WriteLine("Your FIRE number is " + fireNumber.ToString("C2"));
        }
    }
}
