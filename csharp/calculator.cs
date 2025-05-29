namespace oopcalculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Calculator calc = new Calculator();

                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose operation (+, -, *, /):");
                string? operate = Console.ReadLine();

                try
                {
                    double result = 0;

                    switch (operate)
                    {
                        case "+":
                            result = calc.Add(num1, num2);
                            break;
                        case "-":
                            result = calc.Subtract(num1, num2);
                            break;
                        case "*":
                            result = calc.Multiply(num1, num2);
                            break;
                        case "/":
                            result = calc.Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Invalid operation.");
                            return;
                    }

                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}