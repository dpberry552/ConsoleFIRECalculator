using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFIRECalculator
{
    public static class Validator
    {
        public static bool IsValidDecimal(string input)
        {
            return Decimal.TryParse(input, out decimal result);
        }
    }
}
