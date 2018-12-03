using System;
using System.Collections.Generic;
using System.Data;

namespace Module3
{
    class Program
    {
        private const string Separator = ",";

        static void Main(string[] args)
        {
            // WhenDidYouGoToSleep();
            //EnterYourName();
            //ForLoop();
            //SplitAndForeach();
            //IfStatement();
            ConditionalOperator();
            

        }


        private static void WhenDidYouGoToSleep()
        {
                
            Console.Write("When did you go to sleep yesterday? ");
            int goBed = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wakeUp = int.Parse(Console.ReadLine());

            int timeSlept = 24 - goBed + wakeUp;
          

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (timeSlept >= 14)

            {
                Console.WriteLine($"You've slept {timeSlept} hours. That's alot.");

            }
            else if (timeSlept <= 3)
            {
                Console.WriteLine($"You've only slept {timeSlept}. Go back to bed!");

            }
            else
            {
                Console.WriteLine($"You've slept well. ({timeSlept} hours)");
            }
            Console.ResetColor();
            Console.WriteLine();
            throw new NotImplementedException();
        }


        private static void EnterYourName()
        {
            Console.Write("Enter your name: ");
           string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int i = 0;
            Console.ForegroundColor = ConsoleColor.Green;

            while( i < times)
            {
                Console.WriteLine($"Your name is {name}");
                i++;
            }
            Console.ResetColor();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
            }
        }


        private static void ForLoop()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Console.Write("Enter numbers of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
           
            Console.ForegroundColor = ConsoleColor.Green;
         

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{name} ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine();


        }

        private static void SplitAndForeach()
        {
            Console.Write("Enter names in a list: ");           
            string input = Console.ReadLine();

          
            Console.Write("Skriv in efternamn: ");
            string efternamn = Console.ReadLine();

            string[] namn = input.Split(", ");
            Console.WriteLine();
           
            Console.ForegroundColor = ConsoleColor.Green;

           
            foreach (var name in namn)
            {
                if (name == "Zelda")
                {
                    break;                    
                }
                  
                Console.WriteLine($"{name} {efternamn}");
            }
            Console.ResetColor();
            Console.WriteLine();

        }


        private static void IfStatement()
        {
            //Main + extra nr 1 & 2

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write($"What number do you want to compare {number} to ? ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            string message;
            
            if (number < input)
            {
               message =$"Lower than {input}";
            }
            else if (number == input)
            {
                message = $"Equal to {input}";
            }
            else
            {
                message = $"Higher than {input}";
            }
            Console.WriteLine(message);

            Console.ResetColor();
            Console.WriteLine();

            //  Extra nr4 :Name and gender

            Console.Write("Enter your gender (male or female): ");
            string gender = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (gender == "male")
            {
                if (age < 18)
                {
                    Console.WriteLine("You are a male teenager!");
                }
                else if (age < 65)
                {
                    Console.WriteLine("You are a male adult!");
                }
                else if (age < 90)
                {
                    Console.WriteLine("You are an old man!");
                }
                else
                {
                    Console.WriteLine("You are an old, old man!");
                }
                Console.ResetColor();
            }

            
            Console.WriteLine();
           

            if (gender == "female")
            {
                if (age < 18)
                {
                    Console.WriteLine("You are a female teenager!");
                }
                else if (age < 65)
                {
                    Console.WriteLine("You are a female adult!");
                }
                else if (age < 90)
                {
                    Console.WriteLine("You are an old woman!");
                }
                else
                {
                    Console.WriteLine("You are an old, old woman!");
                }

                Console.ResetColor();
                Console.WriteLine();
            }


        }


        private static void ConditionalOperator()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
              
        //Använd vid enkla tillfällen


            string message = (number <= 20) ? (number == 20) ? "Equal 20" : "Lower than 20" : "Higher than 20";
            Console.WriteLine(message);

            


        }
    }
}
