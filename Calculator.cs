using System;

namespace myProjects
{
    static public class Calculator
    {
        static public void Validation()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");
            try
            {
                Console.Write("Enter number 1:  ");
                var userNumber1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2:  ");
                var userNumber2 = Convert.ToDouble(Console.ReadLine());

                if (userNumber2 == 0.0)
                {
                    userNumber2 = Convert.ToInt32(userNumber2);
                }

                Console.WriteLine("Options:");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Devide");
                Console.Write("Enter an option: ");
                var userOption = Console.ReadLine();
                if (userOption != "+" && userOption != "-" && userOption != "*" && userOption != "/")
                {
                    Console.WriteLine("That was not a valid option!");
                    RunAgain();
                }

                Calculate(userNumber1, userNumber2, userOption);
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid number!");
                RunAgain();
            }
        }

        static public void Calculate(double number1, double number2, string option)
        {
            double result;
            try
            {
                switch (option)
                {
                    case "+":
                        result = number1 + number2;
                        ShowResult(result);
                        break;
                    case "-":
                        result = number1 - number2;
                        ShowResult(result);
                        break;
                    case "*":
                        result = number1 * number2;
                        ShowResult(result);
                        break;
                    case "/":
                        result = number1 / number2;
                        ShowResult(result);
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You may not devide by zero!");
                RunAgain();
            }

        }

        static public void ShowResult(double result)
        {
            Console.WriteLine($"Your result: {result}");
            RunAgain();
        }

        static public void RunAgain()
        {
            Console.Write("Would you like to continue? (Y/N)");
            var userRunAgain = Console.ReadLine();
            userRunAgain = userRunAgain.ToUpper();

            if (userRunAgain == "Y")
            {
                Console.Clear();
                Validation();
            }
            else if (userRunAgain == "N")
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You did not enter a valid option!");
                RunAgain();
            }
        }
    }
}
