using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    class Menu
    {
        public Menu()
        {
        }
        public void MainChoices()
        { 
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("");
            
            Console.WriteLine("1. All Organizations");
            Console.WriteLine("2. All Employees");
            Console.WriteLine("3. Organization Details");
            Console.WriteLine("4. Create New Employee");
            Console.WriteLine("5. Quit");
            Console.Write("Please make a selection: ");
            
            try
            {
                int option = Convert.ToInt32(Console.Read());
                if (Convert.ToInt32(option) == 1)
                { 
                    OrgDetails org = new OrgDetails();
                    org.OrganizationDetails();
                }
                if (Convert.ToInt32(option) == 2)
                { 
                    AllEmployees AE = new AllEmployees();
                    AE.listEmployees();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            Console.Clear();
        }   
    }
    class OrgDetails
    { 
        public void OrganizationDetails()
        { 
                Console.WriteLine("All Organizations");
                Console.WriteLine("-----------------");

                Console.WriteLine("Apple: " + "\t" + "\t" + "Cupertino, California");
                Console.WriteLine("Google: " + "\t" + "Mountainview, California");
                Console.WriteLine("IBM: " + "\t" + "\t" + "Armonk, New York");
                Console.WriteLine("Microsoft: " + "\t" + "Remond, Washington");
                Console.WriteLine("");

                Console.WriteLine("Please ENTER to continue");
                Console.ReadLine();
                Console.Clear();
        }
    }
    class AllEmployees
    { 
        public AllEmployees()
        { 
        }
        public void listEmployees()
        {
        Console.WriteLine("EMPLOYEES");
        Console.WriteLine("ALL EMPLOYEES");

        
        
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
        Console.Clear();
        }
    }
}