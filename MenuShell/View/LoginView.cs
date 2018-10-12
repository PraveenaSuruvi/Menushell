using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class LoginView:ConsoleView
    {
        public override string Display()
        {
            
            bool loginSucceeded=false;
            do
            {
                base.Display();
                Console.WriteLine("Please Log in\n");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("\nIs this correct? (Y)es (N)o");

                var keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Y)
                {
                    if (username == "john" && password == "secret")
                    {
                        loginSucceeded = true;

                    }
                    else
                    {
                        Console.WriteLine("Wrong! Try again");
                        Thread.Sleep(2000);
                    }
                }
                else if (keyinfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                }


            } while (!loginSucceeded);

            return ""; 
        }
    }
}
