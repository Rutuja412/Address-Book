using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to AddressBook");
            Person person = new Person();
            while (true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Select Option:\n" +
                    "1) Find the Create Contacts\n");

                int option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Person.CreateContacts();
                        break;
                    case 2:
                        Person.Display();
                        break;
                    case 3:
                        Person.editContact();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
   }    }
}
