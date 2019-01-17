using System;

namespace DemoWithOneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitContext context = new FruitContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            context.Fruits.Add(new Fruit { Name = "Äpple", Color="Rött" });

            foreach (var item in context.Fruits)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Color);
            }

            //var newfruit = new Fruit
            //{
            //    Name = "Banan"
            //};

            //context.Fruits.Add(newfruit);
            context.SaveChanges();
        }
    }
}
