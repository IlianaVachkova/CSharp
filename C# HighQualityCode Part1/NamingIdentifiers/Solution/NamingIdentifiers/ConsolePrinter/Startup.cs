using System;

namespace ConsolePrinter
{
    public class Startup
    {
        public static void Main()
        {
            var boolVariable = new Converter();
            var boolVariableAsStr = boolVariable.ConvertBoolToString(true);

            Console.WriteLine(boolVariableAsStr);
        }
    }
}