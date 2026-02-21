using System;

namespace myProjects
{
    /*
        This is a simple calculator program that allows the user to perform
         basic arithmetic operations (addition, subtraction, multiplication, and division) on two numbers.
         The program includes error handling for invalid input and division by zero, and it prompts the user
         to continue or exit after each calculation.
    */
    static public class Calculator
    {
        static public void Validation()
        {
            double userNumber1;
            double userNumber2;
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");
            try
            {
                Console.Write("Enter number 1:  ");
                userNumber1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2:  ");
                userNumber2 = Convert.ToDouble(Console.ReadLine());


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
                if (userNumber2 == 0.0 && userOption == "/")
                {
                    Console.WriteLine("You may not devide by zero!");
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
