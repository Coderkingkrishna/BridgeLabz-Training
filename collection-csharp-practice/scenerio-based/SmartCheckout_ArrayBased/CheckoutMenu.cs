using System;

class CheckoutMenu
{
    private ICheckout checkout;

    public CheckoutMenu()
    {
        checkout = new CheckoutUtility();
    }

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine("Smart Checkout Menu");
            Console.WriteLine("1 Add Customer to Queue");
            Console.WriteLine("2 Process Billing");
            Console.WriteLine("3 Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    checkout.AddCustomer();
                    break;
                case 2:
                    checkout.ProcessBilling();
                    break;
            }
        } while (choice != 3);
    }
}
