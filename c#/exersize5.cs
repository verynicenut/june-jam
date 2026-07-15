/*
EXERCISE 5: INTERFACES
You are making a roleplaying game where characters can attack and heal.
1. Create an interface IAttackable containing the method: void Attack();
2. Create an interface IHealable containing the method: void Heal();
3. Modify the Knight class so that it implements both interfaces.
4. The Attack() method should display: "{Name} swings a holy sword!"
5. The Heal() method should display: "{Name} casts a healing spell!"
*/

using System;

public interface IAttackable
{
    void Attack();
}

public interface IHealable
{
    void Heal();
}

public class Character
{
    public string Name { get; set; }
    public Character(string name)
    {
        Name = name;
    }
}

public class Knight : Character, IAttackable, IHealable
{
    public Knight(string name) : base(name)
    {
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} swings a holy sword!");
    }

    public void Heal()
    {
        Console.WriteLine($"{Name} casts a healing spell!");
    }
}

class Program
{
    static void Main()
    {
        Knight knight = new Knight("Arthur");
        knight.Attack();
        knight.Heal();
    }
}