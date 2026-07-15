/*
EXERCISE 3: ENCAPSULATION
You are making a game which stores information about characters.
Complete the Character class such that it follows proper encapsulation principles.
1. Create a private integer field health.
2. Create a public property Health, and ensure that Health cannot be set below 0.
3. Create a public static property CharacterCount to count the number of characters. Make the set method private.
*/

using System;

public class Character
{
    private int health;
    public int Health
    {
        get { return health; }
        set { health = value < 0 ? 0 : value; }
    }

    public static int CharacterCount { get; private set; }

    public Character(int health)
    {
        Health = health;
        CharacterCount++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Character c1 = new Character(100);
        Character c2 = new Character(50);
        c1.Health = -10;
        Console.WriteLine(c1.Health); // 0
        Console.WriteLine(Character.CharacterCount); // 2
    }
}