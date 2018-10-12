using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class SearchCustomerView: ConsoleView
    {
        public override string Display()
        {
            Console.WriteLine("Search Customer..");
            Console.ReadKey();
            return base.Display();
        }
    }
}
