using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MainChoices();
            OrgDetails org = new OrgDetails();
            org.OrganizationDetails();

        }
    }
}
