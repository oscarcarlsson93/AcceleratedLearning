using System;

namespace Module6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Adresses academy = new Adresses
            {
                Street = "Långa gatan",
                //Number = "13B",
                // City = "Sundsvall",
                Zipcode = "111 22",

            };

            Console.WriteLine($"{academy.GetFullStreet()}");
            Console.WriteLine();

            
        }
       public class Adresses
        {
            //   public string City { get; set; }
            //   public string Zipcode { get; set; }
            //public string Number { get; set; }

            public string Street { get; set; }
            public string Zipcode { get; set; }


            public string ZipCode
            {
                set
                {

                }
            }
            public void SetZippyCode(string newvalue)
            {

            }




            public string GetFullStreet()
        {
            return Street + " " + Zipcode;

        }
        }
        
    }
}
