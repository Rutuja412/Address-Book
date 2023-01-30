using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AddressBook
{
    public class Person
    {
         List<Contacts> person = new List<Contacts>();
        Dictionary<string, List<Contacts>> addressBook = new Dictionary<string, List<Contacts>>();
        public void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter EmailID ");
            contacts.Email = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode ");
            contacts.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Created new contact \n");

            person.Add(contacts);
            Console.WriteLine("Contact added to your Address book");

        }
        public  void Display()
        {
            foreach (var data in person)
            {
                Console.WriteLine();
                Console.WriteLine("1.FirstName: " + data.FirstName + "2.LastName: " + data.LastName + "3.Address: " + data.Address + "4.City: " + data.City + "5.State: " + data.State + "6.Zipcode: " + data.Zipcode + "7.PhoneNumber: " + data.PhoneNumber);
            }
        }
        public  void editContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string fName = Console.ReadLine();
                                data.FirstName = fName;
                                break;

                            case 2:
                                string lName = Console.ReadLine();
                                data.LastName = lName;
                                break;

                            case 3:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;

                            case 4:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;

                            case 5:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;

                            case 6:
                                int zipcode = Convert.ToInt32(Console.ReadLine());
                                data.Zipcode = zipcode;
                                break;

                            case 7:
                                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = phoneNumber;
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match");
                    }
                }
            }
        }
        public  void DeleteContact(string name)
        {
            Contacts contacts = new Contacts();
            foreach (var data in person)
            {
                if (data.FirstName == name)
                {
                    contacts = data;
                }
            }
            person.Remove(contacts);
        }

    }  }   