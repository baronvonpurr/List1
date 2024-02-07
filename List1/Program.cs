using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>();
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Skriv in ett namn eller skriv blankt för att fortsätta");
                namn.Add(Console.ReadLine());
                if (namn.Last() == "")
                {
                    namn.Sort();
                    namn.Reverse();
                    for (int i = 0; i < namn.Count; i++)
                    {
                        Console.WriteLine(namn[i]);
                        loop = false;
                    }
                }
            }
        }
    }
}