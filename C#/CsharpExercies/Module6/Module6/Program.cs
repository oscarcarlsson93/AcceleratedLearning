using System;

namespace Module6
{

    class car
    {

        public int Weight { get; set; }
        public string Color { get; set; }
        public int Lengt { get; set; }
      

        public car(string c, int w, int l)
        {
            Color = c;
            Weight = w;
            Lengt = l;
            
        }
        public car(string c, int w)
        {
            Color = c;
            Weight = w;
            
        }
        public car(string c)
        {
            Color = c;
        }
        public car(int y)
        {
            Year = y;
        }
        public car()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new car("röd", 1200, 3);
            var c2 = new car("röd");
            var c3 = new car("lila", 800, 4);
            

            
            c3.Color = 
            c3.Weight =
            c3.Lengt =
            



            Console.WriteLine($"Färgen på bilen 'c1' är {c1.Color} och väger {c1.Weight} och är {c1.Lengt} meter lång. Bilen är från {c1.Year}");
            Console.WriteLine($"Färgen på bilen 'c2' är {c2.Color} och väger {c2.Weight} och är {c2.Lengt} meter lång. Bilen är från {c2.Year} ");
            Console.WriteLine($"Färgen på bilen 'c3 är {c3.Color} och väger {c3.Weight} och är {c3.Lengt} meter lång. Bilen är från {c3.Year} ");
            Console.WriteLine($"Färgen på bilen 'c3 är {c4.Color} och väger {c4.Weight} och är {c4.Lengt} meter lång. Bilen är från {c4.Year} ");






        }

    }
}
