using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workersquestionfour
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("firstName","lastName");//New object created with two strings firstName and lastName variables in it. This is because I have created paratermised Employee constructor at Employee class.

            char choice;// The "char choice" is an important variable since it assists to genrate while loop.

            Console.WriteLine("Enter details of new employee below:");
            Console.Write("First name: ");
            e1.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            e1.LastName = Console.ReadLine();
            
            Console.Write("\nYear employee started working for the company?: ");
            e1.YearStarted = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\n**********************************************************");
            Console.WriteLine("Employee {0} {1}, has worked for the company for {2} years",e1.FirstName,e1.LastName, e1.GetYearsWorked());

            Console.WriteLine("\nDo you want to enter another employee? (y/n) ");
            choice = Convert.ToChar(Console.ReadLine());

            while (choice == 'y' || choice == 'Y')// This line of code on the left is from https://www.youtube.com/watch?v=JTCDnty-RVQ website.
            {
                Console.WriteLine("Creating new Employee record...");
                Console.WriteLine("Enter details of new employee below:");
                Console.Write("First name: ");
                e1.FirstName = Console.ReadLine();
                Console.Write("Last Name: ");
                e1.LastName = Console.ReadLine();
                

                Console.Write("\nYear employee started working for the company?: ");
                e1.YearStarted = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\n\n**********************************************************");
                Console.WriteLine("Employee {0} {1}, has worked for the company for {2} years", e1.FirstName, e1.LastName, e1.GetYearsWorked());

                Console.WriteLine("\nDo you want to enter another employee? (y/n) ");
                choice = Convert.ToChar(Console.ReadLine());

            }

            if (choice == 'n' || choice == 'N')// This line of code on the left  is from https://www.youtube.com/watch?v=JTCDnty-RVQ website.
            {
                Console.WriteLine("\n\npress any key to exit the program");
            }

            Console.ReadKey();

            //This program is useful for the companies since it staff members to calculate of how many years they have been working there.- Rahul Khatri




        }
    }
}
