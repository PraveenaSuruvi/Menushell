using MenuShell.View;
using System;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginView loginView = new LoginView();
            ReceptionistMainView receptionistMainView = new ReceptionistMainView();
            RegisterNewCustomer registerNewCustomer = new RegisterNewCustomer();
            SearchCustomerView searchCustomerView = new SearchCustomerView();

            loginView.Display();

            var result = receptionistMainView.Display();
            if(result =="1")
            {
                registerNewCustomer.Display();
            }
            else if(result == "2")
            {
                searchCustomerView.Display();
            }
            else if(result=="3")
            {
                Environment.Exit(0);
            }
        }
    }
}
