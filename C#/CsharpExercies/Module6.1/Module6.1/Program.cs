using System;

namespace Module6._1
{
    class Circle
    {
        public string Name { get; set; }
        public int Radie { get; set; }


        public Circle(string n)
        {
            Name = n;
            Radie = 5;
        }

        public Circle(string n, int r)
        {
            Name = n;
            Radie = r;           
        }

        public Circle(int r, string n)
        {
            Radie = 5;
            Name = n;
        }

        internal void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {Name}!");

        }

        internal void WriteArea()
        {
            Console.WriteLine($"My name is {Name}. I have a radius of {Radie} and an area of {Math.PI * (Radie * Radie)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);
            Circle ali = new Circle("Ali");
            Circle Unknown = new Circle("");

            bob.SayHello();
            lisa.SayHello();

            Console.WriteLine();

           bob.WriteArea();
           lisa.WriteArea();
            ali.WriteArea();
            Unknown.WriteArea();
        }
    }
}
