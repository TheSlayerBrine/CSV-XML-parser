﻿// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;


namespace CsvXmlParser
{
    class Program {
    static void Main(string[] args) {
         var Parse = new CSVParser();
            string path = @"C:\Users\cgame\source\repos\NewRepo2\CSV XML Parser\faithful.csv";
            Parse.SetRawCSV(path);
            Parse.SplitData();
            Parse.OutputTest();
            Console.ReadKey();
        }
    
    
    }

}