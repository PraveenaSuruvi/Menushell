using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class ReceptionistMainView:ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("(1). Register New Customer");
            Console.WriteLine("(2).Search Customer");
            Console.WriteLine("(3).Exit");

            var consoleKeyInfo = Console.ReadKey(true);
            switch(consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    return "1";
                    
                case ConsoleKey.D2:
                    return "2";                    
                case ConsoleKey.D3:
                    return "3";
                default:
                    return "";
            }


        }
    }
}
