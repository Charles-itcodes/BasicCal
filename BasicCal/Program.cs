namespace BasicCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I used do while loop to give user choice to keep the program running.
            do
            {
                // I set my initial values to Zero.
                double number1 = 0;
                double number2 = 0;
                double result = 0;

                Console.WriteLine("\n-------------- Charles's Calculator Program-------------------");
              
                Console.Write("\nEnter number 1: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option you want: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter one of the above Mathematical operations: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"Your result: {number1} + {number2} = " + result);
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"Your result: {number1} - {number2} = " + result);
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"Your result: {number1} * {number2} = " + result);
                        break;
                    case "/":
                        result = number1 / number2;
                        if (number2==0) {
                        Console.WriteLine("You are trying to divide a number by Zero! Please enter another number.");
                        }
                        else
                        {
                        Console.WriteLine($"Your result: {number1} / {number2} = " + result);
                        }
                        
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while 
            (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thank you for using my calculator! (:");
            Console.ReadKey();
        }
    }
}