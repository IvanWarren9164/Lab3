using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isrunning = true;

            while (isrunning == true)
            {
                Console.WriteLine("Enter an integer between 1 and 100: \n");
                int userinput = int.Parse(Console.ReadLine());

                if (userinput >= 1 && userinput <= 100)
                {
                    if (userinput % 2 != 0)
                    {
                        Console.WriteLine("Odd \n");
                    }

                    else if (userinput >= 2 && userinput <= 25 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Even and Less than 25 \n");
                    }

                    else if (userinput >= 26 && userinput <= 60 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Even \n");
                    }

                    else if (userinput > 60 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Even \n");
                    }

                    else if (userinput > 60 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Odd \n");
                    }
                }
                else
                {
                    Console.WriteLine("Error incorrect input \n");
                }

                Console.WriteLine("Would you like to try another number? \n");
                string loopbreak = Console.ReadLine();

                if (loopbreak == "yes" || loopbreak =="Yes")
                {
                    Console.WriteLine(" \n");
                }
                else
                {
                    isrunning = false;
                }
            }
        }
    }
}
