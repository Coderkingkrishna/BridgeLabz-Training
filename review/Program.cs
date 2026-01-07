using System;
class Address{
    // private String name;
    // private String region;
    // private int pincode;
    // private String state;
    public string name{
        get{return value;}
        set{name = value;}
    }
    public string region{
        get{return value;}
        set{region = value;}
    }
    public string state{
        get{return value;}
        set{state = value;}
    }
    public int pincode{
        get{return value;}
        set{pinCode = value;}
    }
}
interface Ifunction{
    void AddAddress(Address Add);
    void SearchAddress(String key);
    void DisplayAll();
}


sealed class utility : Ifunction{
    Address[] StoreAddress = new Address[100];
    int i =0;
    void AddAddress(Address Add){
        StoreAddress[i] = Add;
        Console.WriteLine("Address add");
    }
    void SearchAddress(String Key){
        for(Address add in StoreAddress){
            if(add.name[0]== Key){
                ConsoleReadLine(StoreAddress[j].get(name));
            }
        }
    }
    void DisplayAll(){
        for(Address add in StoreAddress){
            Console.WriteLine(add.name);
            Console.WriteLine(add.region);
            Console.WriteLine(add.pincode);
            Console.WriteLine(add.state);
            Console.WriteLine("Next Address");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Ifunction addressBook = new Utility(); 

        while (true)
        {
            Console.WriteLine("1. Add Address");
            Console.WriteLine("2. Search Address");
            Console.WriteLine("3. Display All");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Address address = new Address();

                    Console.Write("Enter Name: ");
                    address.name = Console.ReadLine();
                    Console.Write("Enter Region: ");
                    address.region = Console.ReadLine();
                    Console.Write("Enter State: ");
                    address.state = Console.ReadLine();
                    Console.Write("Enter Pin Code: ");
                    address.pinCode = int.Parse(Console.ReadLine());
                    addressBook.AddAddress(address);
                    break;

                case 2:
                    Console.Write("Enter Search Key (Name/Region/State/Pin): ");
                    string key = Console.ReadLine();
                    addressBook.SearchAddress(key);
                    break;

                case 3:
                    addressBook.DisplayAll();
                    break;

                case 4:
                    Console.WriteLine(" Exiting Program...");
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
