﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class AddressBookCSVFile
    {

        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"E:\RFP-245\Address-Book\AddressBook\Utility\Import.csv";
             string exportFilePath = @"E:\RFP-245\Address-Book\AddressBook\Utility\Export.csv";
            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contacts>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (Contacts addressData in records)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.Address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.Zipcode);
                    Console.Write("\t" + addressData.PhoneNumber);
                    Console.Write("\t" + addressData.Email);
                    Console.WriteLine();

                }
                Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
                //Writing csv file

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
            //Console.WriteLine(reader);
        }
    }
}

