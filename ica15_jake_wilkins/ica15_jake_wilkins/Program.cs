using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility_Library;

namespace ica15_jake_wilkins
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities use = new Utilities();
            double value = 0.0;
            int integer = 0;

            integer = Utilities.GetInt("Enter an integer: ");
            Console.WriteLine("integer = {0}", integer);

            integer = Utilities.GetInt("Enter a positive integer: ", 0);
            Console.WriteLine("integer = {0}", integer);

            integer = Utilities.GetInt("Enter an integer from 0 to 100: ", 0, 100);
            Console.WriteLine("integer = {0}", integer);

            value = Utilities.GetDouble("Enter a double: ");
            Console.WriteLine("value = {0}", value);

            value = Utilities.GetDouble("Enter a positive double: ", 0.0);
            Console.WriteLine("value = {0}", value);

            value = Utilities.GetDouble("Enter a double from 0.0 to 100.0: ", 0, 100);
            Console.WriteLine("value = {0}", value);

            Utilities.Pause("Press any key to exit: ");

        }
    }
}
