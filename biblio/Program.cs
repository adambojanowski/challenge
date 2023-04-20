using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
//komentarz
namespace biblio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ocena pracownika");
            List<string> lista = new List<string>();
            Console.WriteLine("Wpisz 5 razy: imie spacja ocena");
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("Wpisz 5 razy: imie spacja ocena");
                var wpis = Console.ReadLine();
                //avoid problems with empty or nullstrings
                if (!String.IsNullOrEmpty(wpis))
                {
                    lista.Add(wpis);
                }
            }
            foreach(string a in lista)
            {
                Console.WriteLine(a);
            }
            // Create the file, or overwrite if exists.

            string path = "/home/adam/Projects/biblio/biblio/plik.txt";
           
            File.WriteAllLines(path, lista);
        }
    }
}
