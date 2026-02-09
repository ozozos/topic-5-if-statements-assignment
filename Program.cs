using System.ComponentModel.Design;
using System.Numerics;

namespace topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int part;
            Console.WriteLine("what part do you want?");
            part = Convert.ToInt32(Console.ReadLine());
            if (part == 1)
            {
                part1();
            }
            if (part == 2)
            {
                part2();
            }
            static void part2()
            {
                double number1;
                int operation;
                double number2;
                Console.WriteLine("welcome to the personal calculator what is your first number?");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("perfect now what operation would you like to do?");
                wrong();
                void wrong()
                {
                    Console.WriteLine("1. addition      2. subtract");
                    Console.WriteLine("3. multiplication     4. division ");
                    operation = Convert.ToInt32(Console.ReadLine());

                    if (operation == 1)
                    {
                        Console.WriteLine(" addition good choice");
                        Console.WriteLine(+number1 + "+");
                        Console.WriteLine("now for what is your last number?");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("your equation is " + number1 + " + " + number2);
                        Console.WriteLine("your answer is " + (number1 + number2));
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine(" subtraction good choice");
                        Console.WriteLine(+number1 + "-");
                        Console.WriteLine("now for what is your last number?");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("your equation is " + number1 + " - " + number2);
                        Console.WriteLine("your answer is " + (number1 - number2));
                    }
                    else if (operation == 3)
                    {
                        Console.WriteLine(" multiplication good choice");
                        Console.WriteLine(+number1 + "X");
                        Console.WriteLine("now for what is your last number?");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("your equation is " + number1 + " X " + number2);
                        Console.WriteLine("your answer is " + (number1 * number2));
                    }
                    else if (operation == 4)
                    {
                        Console.WriteLine(" Division good choice");
                        Console.WriteLine(+number1 + "/");
                        Console.WriteLine("now for what is your last number?");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("your equation is " + number1 + " / " + number2);
                        Console.WriteLine("your answer is " + (number1 / number2));
                    }
                    else
                    {
                        Console.WriteLine("sorry im not that smart of a calculator I dont have that oppperation");
                        wrong();
                    }
                }
            }
        }




























            static void part1()
            {
                double weight;

                Console.WriteLine("Hello professional space boxer how much do you weigh?");
                weight = double.Parse(Console.ReadLine());
                Console.WriteLine("great professional now which planet are you  fighting on?");
                planets();
                void planets()
                {
                    int planet;
                    Console.WriteLine("1.Venus          2.Mars          3.Jupiter");

                    Console.WriteLine("4.Saturn         5.Uranus        6.Neptune");

                    planet = Convert.ToInt32(Console.ReadLine());
                    if (planet == 1)
                    {
                        Console.WriteLine("on venus you weigh " + weight * 0.78 + " lbs");
                    }
                    else if (planet == 2)
                    {
                        Console.WriteLine("on Mars you weigh " + weight * 0.39 + " lbs");
                    }
                    else if (planet == 3)
                    {
                        Console.WriteLine("on Jupiter you weigh " + weight * 2.65 + " lbs");
                    }
                    else if (planet == 4)
                    {
                        Console.WriteLine("on Saturn you weigh " + weight * 1.17 + " lbs");
                    }
                    else if (planet == 5)
                    {
                        Console.WriteLine("on Uranus you weigh " + weight * 1.05 + " lbs");
                    }
                    else if (planet == 6)
                    {
                        Console.WriteLine("on neptune you weigh " +weight * 1.23 + " lbs");
                    }
                    else
                    {
                        Console.WriteLine("im sorry fighter i dont have that planet but I do have 1-6");
                        planets();

                    }
                }
            }
        }
    }

