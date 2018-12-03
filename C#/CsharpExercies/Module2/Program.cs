using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            // WhatsYourName();
            //WhatsYourName_withTypes();
            EnterThreeFruits();
        }


        private static void WhatsYourName()
        {

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            string age = Console.ReadLine();

            Console.Write("What is your favorite letter? ");
            string letter = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Thank you!");

            Console.WriteLine();

            Console.WriteLine($"Your name is:{name}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine($"Your favorite letter is {letter}");

            Console.Write(Environment.NewLine);
        }

        private static void WhatsYourName_withTypes()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            string age = Console.ReadLine();
            int input = int.Parse(age);

            Console.Write("What is your favorite character? ");
            char chararcter = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            bool userLikesNumbers = char.IsNumber(chararcter);
                
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You have {65 - input} years until retirement");

            if (userLikesNumbers)
            {
                Console.WriteLine("You like numbers");
            }
            else
            {
                Console.WriteLine("You dont like numbers");
            }


        }  
        

        private static void EnterThreeFruits()
        {
            Console.Write("Enter fruit 1: ");
            string frukt1 = Console.ReadLine();
            Console.Write("Enter fruit 2: ");
            string frukt2 = Console.ReadLine();
            Console.Write("Enter fruit 3: ");
            string frukt3 = Console.ReadLine();

            string result = string.Format("You have entered three fruits; {0}, {1}, {2}", frukt1, frukt2, frukt3);  

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            
           string message1 = ($"You have entered three fruits: {frukt1}, {frukt2}, {frukt3}");
           string message2 = ("You have entered three fruits: " + frukt1 + ", " + frukt2 +", " + frukt3 +"");
           string message3 = string.Format("You have entered three fruits; {0}, {1}, {2}", frukt1, frukt2, frukt3);

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
           
            Console.ResetColor();
            Console.WriteLine();
            
        }
    }
}
