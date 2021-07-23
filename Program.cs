using System;
using System.Collections.Generic;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().TrimEnd().Split(' ');
                if (entry.Length == 2)
                {
                    if (!phoneBook.ContainsKey(entry[0]))
                    {
                        phoneBook.Add(entry[0].ToLower(), int.Parse(entry[1]));
                    }
                }

            }

            searchEntry(phoneBook);
        }

        private static void searchEntry(Dictionary<string, int> phoneBook)
        {
            string search = null;
            while (true)
            {

                search = Console.ReadLine();
                if ((search == null) || (search == ""))
                {
                    break;
                }

                else 
                { 
                    if (phoneBook.ContainsKey(search))
                    {
                        Console.WriteLine($"{search}={phoneBook[search]}");
                    }
                    else
                    {
                        Console.WriteLine($"Not found");
                    }
                }

            } 

        }
    }
}
