using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //you declare variables so the complier can allocate the right amount of memory
            int x = 0;
            int y = 6;

            //instantiate a class
            Addition addition = new Addition();
            int sum, sum2, sum3 = 0;

            sum = addition.Add(x, y); //calling public method from class
            sum2 = addition.Subtract(10, 35);
            sum3 = addition.Multiply(10, 35);

            Console.WriteLine($"{x} + {y} = {sum}");
            Console.WriteLine($"subtract = {sum2}");
            Console.WriteLine($"multiply = {sum3}");

            Console.WriteLine("Hello World");

            for (int i = 0; i < 9; i++) //for loop
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even"); //placeholder with $ and {variable name}
                }
                else
                {
                    Console.WriteLine("{0} is odd", i); //another type of placeholder
                }
            }

            Console.ReadLine();
        }
    }
}
