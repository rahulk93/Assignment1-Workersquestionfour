using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workersquestionfour
{
    class Employee
    {
        // The four things below are auto-implemented properties. 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearStarted { get; set; }
        public int YearsWorked { get; set; }//This auto-implemented property is important because it assists the system how many years a employee worked in a company. 
        
        //This below is parameteried constructor with string firstName and string lastName. Furthermore display message "Creating new Employee record...".
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Creating new Employee record...");
        }

        public string GetFullName()
        {
            return FirstName + LastName;
        }
        // The 'Date.Time is imporant is imporant because it helps to calculate number of years that a employee worked.
        public int GetYearsWorked()
        {
            YearsWorked = DateTime.Now.Year - YearStarted;
            return YearsWorked;
            
        }

        

        

      
    }
}
