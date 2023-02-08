using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    public class AddressbookFileIO
    {
        public static void FileExists()
        {
            String path = @"E:\RFP-245\Address-Book\AddressBook\ContactBook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines()
        {
            String path = @"E:\RFP-245\Address-Book\AddressBook\ContactBook.txt";
            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            Console.WriteLine(lines[4]);
            Console.WriteLine(lines[5]);
            Console.WriteLine(lines[6]);

            Console.ReadKey();
        }
        
        public static void ReadFromStreamReader()
        {
            String path = "E:\\RFP-245\\Address-Book\\AddressBook\\ContactBook.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
        public static void WriteUsingStreamWriter()
        {
            String path = "E:\\RFP-245\\Address-Book\\AddressBook\\ContactBook.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("First Name :Sneha \nLastName:Sawant \nAddress:Pune \nPhoneNumber:9850786512");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}

