using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class RegisterNewCustomer:ConsoleView
    {
        public override string Display()
        {            
            bool notSufficientInfo = true;
            do
            {
                base.Display();
                Console.Write("FirstName: ");
                string firstName = Console.ReadLine();

                Console.Write("LastName: ");
                string lastName = Console.ReadLine();

                Console.Write("SSN; ");
                string socialSecurityNumber = Console.ReadLine();
                Console.WriteLine("Is this correct? (Y)es,(N)o");
                var consoleKeyInfo = Console.ReadKey();
                if(consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    notSufficientInfo = false;

                }
                else
                {

                }
            } while (notSufficientInfo);
            return "";
        }

    }
}
