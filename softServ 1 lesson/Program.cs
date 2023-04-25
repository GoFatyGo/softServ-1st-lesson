using System;

namespace softServ_1_lesson
{

    class Program
    {
        static int Sum(int val1, int val2)
        {
            int result = val1 + val2;
            return result;
        }
        static int Substraction(int val1, int val2)
        {
            int result = val1 - val2;
            return result;
        }
        static int Multiplication(int val1, int val2)
        {
            int result = val1 * val2;
            return result;
        }
        static int Division(int val1, int val2)
        {
            int result = val1 / val2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 task.\n Define integer variables a and b." +
                              "Read values a and b from the console and \n calculate: a+b, a-b, a*b, a/b." +
                              "Output results on the console.!\n\n");
            int numericValue;
            bool isNumber1;
            bool isNumber2;
            string Value1, Value2;
            do
            {
                Console.WriteLine("Write Number1: ");
                Value1 = Console.ReadLine();
                isNumber1 = int.TryParse(Value1, out numericValue);
                if (!isNumber1)
                {
                    Console.WriteLine("Only numbers pls!");
                }
            } while (!isNumber1);
            do
            {
                Console.WriteLine("Write Number2: ");
                Value2 = Console.ReadLine();
                isNumber2 = int.TryParse(Value2, out numericValue);
                if (!isNumber2)
                {
                    Console.WriteLine("Only numbers pls!");
                }
            } while (!isNumber2);

            Console.WriteLine("Enter math action(+,-,*,/");

            int a = int.Parse(Value1);
            int b = int.Parse(Value2);
            int result;
            bool ChekAction = false;
            do
            {
                string Action = Console.ReadLine();
                if (Action == "+")
                {
                    result = Sum(a, b);
                    Console.WriteLine("\nResult = " + result);
                    ChekAction = true;
                }
                else if (Action == "-")
                {
                    result = Substraction(a, b);
                    Console.WriteLine("Result = " + result);
                    ChekAction = true;
                }
                else if (Action == "*")
                {
                    result = Multiplication(a, b);
                    Console.WriteLine("Result = " + result);
                    ChekAction = true;
                }
                else if (Action == "/" && b == 0)
                {
                    Console.WriteLine("Can't divide by zero!");
                    ChekAction = false;
                }
                else if (Action == "/")
                {
                    result = Division(a, b);
                    Console.WriteLine("Result = " + result);
                    ChekAction = true;
                }
                else
                {
                    Console.WriteLine("Only correct action pls!");
                    ChekAction = false;
                }

            } while (!ChekAction);

            //2 Task
            Console.WriteLine("\n\n2 task\nOutput question “How are you?“." +
                " Define string variable answer. Read value answer and output on the console:" +
                " “You are (answer)");

            Console.WriteLine("How are you?");
            string Answer = Console.ReadLine();
            Console.WriteLine($"- How are you?\n- I'm {Answer}");

            //3 Task

            Console.WriteLine("\n3 Task\nRead 3 variables of char type. Write message: “You enter (first char), (second char), (3 char)\n");
            Console.WriteLine("Enter First char:");
            string FirstChar = Console.ReadLine();
            Console.WriteLine("Enter Second char:");
            string SecondChar = Console.ReadLine();
            Console.WriteLine("Enter Third char:");
            string ThirdChar = Console.ReadLine();
            char achar = char.Parse(FirstChar);
            char bchar = char.Parse(FirstChar);
            char cchar = char.Parse(FirstChar);
            Console.WriteLine($"You enter ({achar}), ({bchar}), ({cchar})”");

            //4 Task 
            Console.WriteLine("\nEnter 2 integer numbers. Check if they are both positive – use bool expression\n");
            Console.WriteLine("Enter first and second int (both positive): ");

            int chek1;
            int chek2;
            bool ChekInt1;
            bool ChekInt2;
            bool ChekPositive = true;
            string Number1;
            string Number2;
            do
            {
                do
                {                                        //verification string-int
                    Number1 = Console.ReadLine();
                    Number2 = Console.ReadLine();


                    ChekInt1 = int.TryParse(Number1, out chek1);
                    ChekInt2 = int.TryParse(Number2, out chek2);
                    if (!ChekInt1)
                    {
                        Console.WriteLine("Only int, pls");
                    }
                    else if (!ChekInt2)
                    {
                        Console.WriteLine("Only int, pls");
                    }
                } while (!ChekInt1 || !ChekInt2);

                int FirstNumber = Convert.ToInt32(Number1);  //verification positive-negative
                int SecondNumber = int.Parse(Number2);
                if (FirstNumber > 0 && SecondNumber > 0)
                {
                    ChekPositive = true;
                    Console.WriteLine($"First number = {FirstNumber} and second number = {SecondNumber}");
                }
                else
                {
                    ChekPositive = false;
                    Console.WriteLine("positive, pls");
                    // break;
                }
            } while (!ChekPositive);

            //HOMEWORK
            //1.
            Console.WriteLine("\n\nHOMEWORK\n1. Define integer variable a (side of the square). " +
                "Read value from the console and calculate the area and perimeter of a square " +
                "with length a. Output results on the console.\n");


            string EnterSquarSide = Console.ReadLine();
            int SquarSide = Convert.ToInt32(EnterSquarSide);
            Console.WriteLine($"Area = {SquarSide * SquarSide} and Perimeter = {Sum(SquarSide, SquarSide)}");

            Console.WriteLine("\n\n"+"2."+
                "Define string name and integer age. Output question \"What is your name ?\"\nRead value name and output next question: \"How old are you, (name) ? \" \nRead value age and output whole information  ") ;

            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine($"How old are you {Name}?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"My {Name}. I'm {year}.");

            Console.WriteLine("\n\n" + "3." +
                "Read double number r(radius of a circle).Calculate the length(l = 2 * pi * r), area(S = pi * r * r), and volume(4 / 3 * pi * r * r * r) of a circle.\n\n");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"L = {2*3.14*r}\nS = {3.14*r*r}\nV = {4/3*3.14*r*r*r}");

        }
    }
}
