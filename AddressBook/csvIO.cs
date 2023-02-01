using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class csvIO
    {
        static string _file = @"C:\Users\scorp\Desktop\AddressBook\AddressBook\FileIO\contacts.csv";
        public static void WriteCSV(List<Contacts> data)
        {
            if (!File.Exists(_file)) { File.Create(_file); }

 

            CsvFileDescription csvFileDesciption= new CsvFileDescription()
            {
                FirstLineHasColumnNames= true,
                SeparatorChar= ','
            };

            CsvContext csvContext = new CsvContext();

            csvContext.Write(data, _file, csvFileDesciption);


        }

        public static void ReadCSV()
        {
            if(File.Exists(_file))
            {
                CsvFileDescription csvFileDesciption = new CsvFileDescription()
                {
                    FirstLineHasColumnNames = true,
                    SeparatorChar = ','
                };
                CsvContext csvContext = new CsvContext();

                var Persons = csvContext.Read<Contacts>(_file, csvFileDesciption);

                foreach(var Person in Persons)
                {
                    Console.WriteLine(Person.FirstName+" | "+Person.LastName+" | "+Person.Email+" | "+Person.PhoneNumber);
                }
            }
            else
            {
                Console.WriteLine("Something Went Wrong");
            }
        }
    }
}
