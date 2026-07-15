/*
EXERCISE 1: LISTS
You are making a game where a player runs a bubble tea shop. You are given a List<String> containing 5 flavours of bubble tea.
1. Ask the user to enter a new flavour to the console and add it to the console using Add().
2. Ask the user to enter a flavor they want to remove. If the flavor exists, remove it using Remove(); otherwise, display a message saying the flavor was not found.
3. Sort the list and display it in alphabetical order using a for loop.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> flavours = new List<string>{ "Brown Sugar", "Black", "Oolong", "Earl Grey", "Green" };
        Console.Write("Enter a new flavour: ");
        string newFlavour = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newFlavour))
        {
            flavours.Add(newFlavour.Trim());
        }

        Console.Write("Enter a flavour to remove: ");
        string removeFlavour = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(removeFlavour))
        {
            removeFlavour = removeFlavour.Trim();
            if (flavours.Remove(removeFlavour))
            {
                Console.WriteLine($"Removed '{removeFlavour}' from the menu.");
            }
            else
            {
                Console.WriteLine($"{removeFlavour} was not found.");
            }
        }

        flavours.Sort();
        Console.WriteLine("\nFlavours in alphabetical order:");
        for (int i = 0; i < flavours.Count; i++)
        {
            Console.WriteLine(flavours[i]);
        }
    }
}