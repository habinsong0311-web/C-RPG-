using System;

namespace ConsoleGameFramework.Models;

public class Player : Character
{
    public string Job { get; set; }

    public int Level { get; set; } = 1;

    public int Exp { get; set; } = 0;

    public int MaxExp { get; set; } = 5;

    public int Money{ get; set; } = 500;

    public Player(string name, int maxHp, int maxMp, int attack, int defense) : base(name, maxHp, maxMp,attack, defense)
	{
	}
    public void AddMoney(int money)
    {
        Money += money;
    }
}

public class Warrior : Player
{
    public Warrior(string name) : base(name, 200, 50, 30, 30)
    {
        Job = "전사";
    }
}
public class Assassin : Player
{
    public Assassin(string name) : base(name, 100,100,40,10)
    {
        Job = "암살자";
    }

}
public class Mage : Player
{
    public Mage(string name) : base(name, 150, 200, 10, 20)
    {
        Job = "마법사";
    }
}

