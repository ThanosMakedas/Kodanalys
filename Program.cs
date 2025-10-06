using Kodanalys.Models;
using System;

namespace Kodanalys
{
    class Program //Ändrade klassnamn från program till Program
    {
        static string[] celestialWhispers = new string[10];
        static int magicConstant = 0;

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
                    if (userCount < 10)
                    {
                        celestialWhispers[magicConstant] = strUsr;
                        magicConstant++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (unicornSparkle == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < magicConstant; i++)
                    {
                        Console.WriteLine(celestialWhispers[i]);
                    }
                }
                else if (unicornSparkle == "3")
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
                else if (unicornSparkle == "4")
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
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (unicornSparkle == "5")
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
