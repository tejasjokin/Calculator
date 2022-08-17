namespace Calculator
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            bool Flag = true;
            do
            {
                Console.WriteLine("\nEnter the operation to be performed: ");
                Console.WriteLine("\n1.Addition.");
                Console.WriteLine("\n2.Subtraction");
                Console.WriteLine("\n3.Multiplication");
                Console.WriteLine("\n4.Division");
                Console.WriteLine("\n5.Exit");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the first number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        var num3 = CalculatorFunctions.Add(num1, num2);
                        Console.WriteLine($"The addition of {num1} {num2} is: {num3}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the first number: ");
                        var num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        var num5 = Convert.ToInt32(Console.ReadLine());
                        var num6 = CalculatorFunctions.Subtract(num4, num5);
                        Console.WriteLine($"The subtraction of {num4} {num5} is: {num6}");
                        break;
                    case 3:
                        Console.WriteLine("Enter the first number: ");
                        var num7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        var num8 = Convert.ToInt32(Console.ReadLine());
                        var num9 = CalculatorFunctions.Multiply(num7, num8);
                        Console.WriteLine($"The multiplication of {num7} {num8} is: {num9}");
                        break;
                    case 4:
                        Console.WriteLine("Enter the first number: ");
                        var num10 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        var num11 = Convert.ToInt32(Console.ReadLine());
                        var num12 = CalculatorFunctions.Multiply(num10, num11);
                        Console.WriteLine($"The division of {num10} {num11} is: {num12}");
                        break;
                    case 5:
                        Flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            } while (Flag);
            return 0;
        }
    }
}