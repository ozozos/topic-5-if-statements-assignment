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

            if (part == 3)
            {
                part3();
            }


            static void part3()
            {
                string answer1;
                string answer2;
                string answer3;
                string answer4;
                string answer5;
                double points;
                points = 0;
                Console.WriteLine("WELCOME to the how well do you know calvin quiz!");
                Console.WriteLine("this quiz will consist of 3 yes or no answers");
                Console.WriteLine("and 2 multiple choice for a total of 5 questions!");
                Console.WriteLine("you start with 0 points and will gain one for a right answer and then you will lose 1 if you get it wrong");
                Console.WriteLine("");
                Console.WriteLine("okay for your first question");
                Console.WriteLine();
                Console.WriteLine();
                question1();
                void question1()
                {
                    Console.WriteLine("does calvin have long or short hair?");
                    Console.WriteLine("     true            false  ");
                    answer1 = Console.ReadLine();
                    if (answer1 == "true")
                    {
                        points = points + 1;
                        Console.WriteLine("Correct Calvin does infact have long hair +1 point for a total of " + points);

                    }
                    else if (answer1 == "false")
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin has AMAZING locks of hair");

                    }
                    else
                    {
                        Console.WriteLine("thats an inpropper answer try again");
                        question1();
                    }
                }
                Console.WriteLine();
                Console.WriteLine();

                question2();
                void question2()
                {
                    Console.WriteLine("NEXT question has Calvin taken music every year so far?");
                    Console.WriteLine("       true          false");
                    answer2 = Console.ReadLine();
                    if (answer2 == "true")
                    {
                        points = (points + 1);
                        Console.WriteLine("Correct Calvin has taken music every year +1 point for a total of " + points);
                    }
                    else if (answer2 == "false")
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin loves music for at total points of " + points);
                    }
                    else
                    {
                        Console.WriteLine("thats an inpropper answer try again");
                        question2();
                    }
                }
                Console.WriteLine();
                Console.WriteLine();

                question3();
                void question3()
                {
                    Console.WriteLine("FINAL true or false does Calvin do martial arts?");
                    Console.WriteLine("       true          false");
                    answer3 = Console.ReadLine();
                    if (answer3 == "true")
                    {
                        points = (points + 1);
                        Console.WriteLine("Correct Calvin has done martial arts since he was 8 now a total points of  " + points);
                    }
                    else if (answer3 == "false")
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin is Martial artist now a total of " + points);
                    }
                    else
                    {
                        Console.WriteLine("thats an inpropper answer try again");
                        question3();
                    }

                }
                Console.WriteLine();
                Console.WriteLine();

                question4();
                void question4()
                {
                    Console.WriteLine("now onto the multiple choice questions!");
                    Console.WriteLine("what genre of music does Calvin like the most?");
                    Console.WriteLine(" A. post-hardcore       B.goth rock");
                    Console.WriteLine(" C. pop rock            D.old school rock");
                    answer4 = Console.ReadLine().ToLower();
                    if (answer4 == ("a"))
                    {
                        points = (points + 1);
                        Console.WriteLine("Correct Calvin has been listening to post-hardcore for little over a year now with bands including pierce the veil. total points of  " + points);
                    }
                    else if (answer4 == "b")
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin does listen to goth rock like the bauhaus but its not his favourite. total points of  " + points);
                    }
                    else if (answer4 == ("c"))
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin does like pop rock it has a catchy vibe mixed with rock but its not his favourite. total points of  " + points);
                    }
                    else if (answer4 == ("d"))
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin does love old school rock with it mainly consisting of the 60's to the 80's but not his fav. total points of  " + points);
                    }
                    else
                    {
                        Console.WriteLine("thats an inpropper answer try again");
                        question4();
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                question5();
                void question5()
                {
                    Console.WriteLine(" you've made it this far with " + points + " this is the last question hope your ready!");
                    Console.WriteLine("Who is Calvins Favourite music artist?");
                    Console.WriteLine("A. The smashing pumpkins         B.Peirce the veil");
                    Console.WriteLine("C. Domonic Fike                  D.bauhaus");
                    answer5 = Console.ReadLine().ToLower();
                    if (answer5 == ("c"))
                    {
                        points = (points + 1);
                        Console.WriteLine("Correct Calvin has been listening to Domonic Fike for many years with his most recent song being white keys. total points of  " + points);
                    }
                    else if (answer5 == "b")
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong that was a trick question post hardcore may be his favourite genre but not his favourite artis. total points of  " + points);
                    }
                    else if (answer5 == ("a"))
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin does ADORE the smashing pumpkins with his favourite song byu them being bullet iwth butterfly wings. total points of  " + points);
                    }
                    else if (answer5 == ("d"))
                    {
                        points = (points - 1);
                        Console.WriteLine("ohhh sorry thats wrong Calvin does listen to them on the daily but not his favourite even though there the founding fathers of goth rock. total points of  " + points);
                    }
                    else
                    {
                        Console.WriteLine("thats an inpropper answer try again");
                        question5();
                    }
                }
                    Console.WriteLine("");
                    Console.WriteLine();
                    Console.WriteLine("CONGRADULATIONS YOUVE FINISHED THE TEST with a score of!");
                    Console.WriteLine(points);
                    Console.WriteLine("thats a " + (points / 5) * 100 + " percent");
                
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
                        Console.WriteLine("on neptune you weigh " + weight * 1.23 + " lbs");
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

