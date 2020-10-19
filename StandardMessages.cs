using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFIRECalculator
{
    public static class StandardMessages
    {
        private static string _startMessage = "Welcome to the FIRE Calculator!";
        private static string _exitMessage = "Goodbye!";
        public static string ApplicationStartMessage()
        {
            return _startMessage;
        }

        public static string InvalidInputMessage(string inputType)
        {
            return "Oops! That's not a valid " + inputType + ". Please try again.";
        }

        public static string ApplicationExitMessage()
        {
            return _exitMessage;
        }
    }
}
