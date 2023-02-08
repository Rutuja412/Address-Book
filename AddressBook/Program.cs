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
                    "1) Find the Create Contacts\n" +
                    "2) Find the Display of Contacts\n" +
                    "3) Find the edit contacts\n" +
                    "4) Find the delete contacts\n" +
                    "5) Ability to add Multiple person in AddressBook\n" +
                     "6) Add multiple address book\n" +
                     "7) Display new list\n" +
                     "8)Check Duplicate entry\n"+
                     "9)search person by name and city name\n" +
                     "10)View Person by city name \n" +
                     "11) Count person from city name\n" +
                     "12)Sort Person\n " +
                     "13) Sort By city name\n" +
                     "14) Sort By Zipcode \n"+
                     "15) FileIO\n" +
                     "16) ReadAllLines\n"+
                     "17)ReadFromStreamReader\n" +
                     "18)WriteUsingStreamWriter\n"+
                     "19)ImplementCSVDataHandling\n"+
                     "20)ImplementCSVToJSON\n"+
                     "21)Enter Correct number");     
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

                    case 4:
                        Console.WriteLine("Enter name to delete the record");
                        string name = Console.ReadLine();
                        Person.DeleteContact(name);
                        break;

                    case 5:
                        Person.AddMultipleContacts();
                        break;
                    case 6:
                        person.NewUser();
                        break;
                    case 7:
                        person.DisplayList();
                        break;
                    case 8:
                        Person.DuplicateContact();
                        break;
                    case 9:
                        Person.SearchPersonByCity();
                        break;
                        case 10:
                        Person.ViewPersonByCity();
                        break;
                    case 11:
                        Person.CountPerson();
                        break;
                        case 12:
                        Person.SortPersonName();
                        break;
                    case 13:
                        Person.SortbyCityName();
                        break;

                    case 14:
                        Person.SortbyZipcode();
                        break;
                    case 15:
                        AddressbookFileIO.FileExists();
                        break;

                    case 16:
                        AddressbookFileIO.ReadAllLines();
                        break;
                    case 17:
                        AddressbookFileIO.ReadFromStreamReader();
                        break;

                    case 18:
                        AddressbookFileIO.WriteUsingStreamWriter();
                        break;

                    case 19:
                        AddressBookCSVFile.ImplementCSVDataHandling();
                        break;
                    case 20:
                        ReadCSV_And_WriteJSON.ImplementCSVToJSON();
                        break;

                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
   }    }
}
