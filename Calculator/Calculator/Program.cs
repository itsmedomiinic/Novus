using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program:Calculator
    {
        static void Main(string[] args)
        {
            int num1, num2, option, sum = 0;

            Calculator calculator = new Calculator();

            Console.WriteLine("Enter your first Number: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your second Number: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("What would you like to do? \n" +
                "1. Add \n" +
                "2. Subtract \n" +
                "3. Multiply \n" +
                "4. Divide \n" +
                "5. QUIT \n" +
                "Please enter an ineger: ");
            option = Convert.ToInt16(Console.ReadLine());

            if (option != 5)
            {
                switch (option)
                {
                    case 1:
                        sum = calculator.Add(num1, num2);
                        Console.WriteLine($"{num1} + {num2} = {sum}");
                        break;
                    case 2:
                        sum = calculator.Subtract(num1, num2);
                        Console.WriteLine($"{num1} - {num2} = {sum}");
                        break;
                    case 3:
                        sum = calculator.Multiply(num1, num2);
                        Console.WriteLine($"{num1} x {num2} = {sum}");
                        break;
                    case 4:
                        sum = calculator.Divide(num1, num2);
                        Console.WriteLine($"{num1} / {num2} = {sum}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter an integer");
            }
            Console.ReadLine();
        }
    }
}
