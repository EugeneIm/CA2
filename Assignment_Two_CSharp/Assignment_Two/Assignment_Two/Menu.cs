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
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                { 
                    Console.Clear();
                    OrgDetails org = new OrgDetails();
                    org.OrganizationDetails();
                }
                else if (option == 2)
                { 
                    Console.Clear();
                    AllEmployees AE = new AllEmployees();
                    AE.listEmployees();
                }
                else if (option == 3)
                { 
                    Console.Clear();
                    OrgInfo OI = new OrgInfo();
                    OI.OrgSpecifics();
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
    class OrgInfo
    {
        public OrgInfo()
        { 
        }

        public void OrgSpecifics()
        { 
            Console.WriteLine("ORGANIZATION SELECTION");
            Console.WriteLine("");

            Console.WriteLine("Please enter the organization name:");
            Console.WriteLine("1) Apple");
            Console.WriteLine("2) Google");
            Console.WriteLine("3) IBM");
            Console.WriteLine("4) Microsoft");

            Console.WriteLine("");
            Console.Write("Please enter a selection: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            try
            { 
                if (choice == 1)
                { 
                    Console.WriteLine("====================================");
                    Console.WriteLine("Organization:    Apple");
                    Console.WriteLine("State:           California");
                    Console.WriteLine("City:            Cupertino");
                    Console.WriteLine("Timezone:        Pacific Standard Time");
                    Console.WriteLine("====================================");

                    Console.WriteLine("");
                    Console.WriteLine("EMPLOYEES");
                    Console.WriteLine("");
                }
                else if (choice == 2)
                { 
                    Console.WriteLine("====================================");
                    Console.WriteLine("Organization:    Google");
                    Console.WriteLine("State:           California");
                    Console.WriteLine("City:            Mountainview");
                    Console.WriteLine("Timezone:        Pacific Standard Time");
                    Console.WriteLine("====================================");

                    Console.WriteLine("");
                    Console.WriteLine("EMPLOYEES");
                    Console.WriteLine("");
                }
                else if (choice == 3)
                { 
                    Console.WriteLine("====================================");
                    Console.WriteLine("Organization:    IBM");
                    Console.WriteLine("State:           New York");
                    Console.WriteLine("City:            Armonk");
                    Console.WriteLine("Timezone:        Eastern Standard Time");
                    Console.WriteLine("====================================");

                    Console.WriteLine("");
                    Console.WriteLine("EMPLOYEES");
                    Console.WriteLine("");
                }
                else
                { 
                    Console.WriteLine("====================================");
                    Console.WriteLine("Organization:    Microsoft");
                    Console.WriteLine("State:           Washington");
                    Console.WriteLine("City:            Remond");
                    Console.WriteLine("Timezone:        Pacific Standard Time");
                    Console.WriteLine("====================================");

                    Console.WriteLine("");
                    Console.WriteLine("EMPLOYEES");
                    Console.WriteLine("");
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
        }


    }
}