/*
EXERCISE 4: INHERITANCE
You are making a fighting a game where a player fights a boss.
1. In the GameEntity class, create a protected field "name" of type string.
2. Ensure that the Player class inherits from the GameEntity class.
3. Ensure that the Player constructor uses "base" to reference the GameEntity constructor.
4. Ensure that the Boss class inherits from the Player class.
5. Mark the "Boss" class as sealed.
6. Ensure that the Boss constructor uses "base" to reference the Player constructor.
*/

using System;

class GameEntity
{
    protected string name;

    public GameEntity(string name)
    {
        this.name = name;
    }
}

class Player : GameEntity
{
    public Player(string name)
        : base(name)
    {
    }

    public void Attack()
    {
        Console.WriteLine($"Player {name} attacks!");
    }
}

sealed class Boss : Player
{
    public Boss(string name)
        : base(name)
    {
    }
}

class Program
{
    static void Main()
    {
        Player p = new Player("Hero");
        Boss b = new Boss("Dragon Lord");
        p.Attack();
        b.Attack();
    }
}