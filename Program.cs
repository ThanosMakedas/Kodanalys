using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program //Ändrade klassnamn från program till Program
    {
        static List<string> users = new List<string>(); // ersatt statisk array med dynamisk lista 
        static void Main(string[] args)
        {
            bool programHalted = true;
            while (programHalted)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string choice = Console.ReadLine(); //Förbättrade variabelnamn för tydlighet

                if (choice == "1")
                {
                    Console.Write("Ange namn: ");
                    string name = Console.ReadLine();
                    users.Add(name); // Lagt till användare i listan
                }

                else if (choice == "2")
                {
                    Console.WriteLine("Användare:");
                    foreach (var user in users) // Använder foreach för att hjälpa med iteration
                    {
                        Console.WriteLine(user);
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Ange namn att ta bort: "); // Förenklade borttagning av användare
                    string nameToRemove = Console.ReadLine();

                    if (users.Remove(nameToRemove))
                    {
                        Console.WriteLine("Användaren togs bort.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (choice == "4")
                {
                    Console.Write("Ange namn att söka: "); // Förenklade sökning av användare
                    string nameToSearch = Console.ReadLine();

                    if (users.Contains(nameToSearch))
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (choice == "5")
                {
                    programHalted = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
