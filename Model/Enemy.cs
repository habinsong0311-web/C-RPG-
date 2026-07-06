using System;

namespace ConsoleGameFramework.Models;

public class Enemy : Character
{
	public Enemy(string name, int maxHp, int maxMp, int attack, int defense) : base(name, maxHp, maxMp, attack, defense)
	{
	}
}
public class Slime : Character
{
	public Slime(string name, int maxHp, int maxMp, int attack, int defense) : base("슬라임",30,0,10,0)
	{ }
}
public class Goblin :Character
{
	public Goblin(string name, int maxHp, int maxMp, int attack, int defense) : base("고블린", 50, 0, 20, 10)
	{
	}
}
public class GoblinMage : Character
{
	public GoblinMage(string name, int maxHp, int maxMp, int attack, int defense) : base("고블린 매이지", 40, 200, 10, 5)
	{ 
	}
}
public class Hobgoblin : Character
{
	public Hobgoblin(string name, int maxHp, int maxMp, int attack, int defense) : base("홉고블린", 70, 50, 30, 20)
	{ }
}
public class Orc : Character
{
    public Orc(string name, int maxHp, int maxMp, int attack, int defense) : base("오크",120,20,25,20)
	{
	}
}
public class dragon : Character
{
    public dragon(string name, int maxHp, int maxMp, int attack, int defense) : base("드래곤",9999,9999,999,999)
	{ }
}


