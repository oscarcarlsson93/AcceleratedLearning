using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11._2
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Customer> allCustomers = CreateListOfCustomers();

            DisplayInfoAboutCusomer(allCustomers);
        }

        private static void DisplayInfoAboutCusomer(List<Customer> allCustomers)
        {
            Console.WriteLine("Sorted list by age:");
            Console.WriteLine();
          
            foreach (var item in allCustomers.OrderBy(x => x.Age))
            {
                DisplayCustomer(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted list by first name:");
            Console.WriteLine();
            foreach (var item in allCustomers.OrderBy(x => x.FirstName))
            {
                DisplayCustomer(item);
            }

            Console.WriteLine();
            Console.WriteLine("Men older than 35:");
            Console.WriteLine();

            foreach (var item in allCustomers.Where(x => x.Gender == "Male").Where(x => x.Age > 35).OrderBy(x => x.FirstName))
            {
                DisplayCustomer(item);
            }

            Console.WriteLine();
            Console.WriteLine("Manipulated:");
            Console.WriteLine();

            foreach (var item in allCustomers.Where(x => x.Gender == "Male" && x.Age > 35).OrderBy(x => x.FirstName))
            {
                Console.WriteLine($"{item.FirstName.ToUpper()} {item.Age + 1000} {item.Gender}");
            }

            foreach (var item in allCustomers.Where(x => x.Gender == "Male" && x.Age > 35).OrderBy(x => x.FirstName).Select(x=>new Customer {
                FirstName = x.FirstName.ToUpper(),
                Age = x.Age+1000,
                Gender = x.Gender
            }))
            {
                DisplayCustomer(item);
            }
        }

        private static void DisplayCustomer(Customer item)
        {
            Console.WriteLine($"{item.FirstName} {item.Age} {item.Gender}");
        }

        private static List<Customer> CreateListOfCustomers()
        {
            string[] kunder = File.ReadAllLines(@"C:\Project\AcceleratedLearning\C#\CsharpExercies\Module11\Module11\Customers.txt");
            List<Customer> allaKunder = new List<Customer>();

            foreach (var item in kunder)
            {
                var kund = new Customer();
                var splittad = item.Split(',');
                kund.FirstName = splittad[0];
                kund.LasteName = splittad[1];
                kund.Email = splittad[2];
                kund.Gender = splittad[3];
                kund.Age = int.Parse(splittad[4]);
                           
                allaKunder.Add(kund);
            }
            return allaKunder;
        }
    }
}
