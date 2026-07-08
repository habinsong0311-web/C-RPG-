using System;
using System.ComponentModel;

namespace ConsoleGameFramework.Models;

public class Enemy : Character
{
    public int Exp { get; set; }
    public Item HasItem { get; set; }
    public Enemy(string name, int maxHp, int maxMp, int attack, int defense) : base(name, maxHp, maxMp, attack, defense)
	{
	}
}
public class Slime : Enemy
{
	public Slime() : base("슬라임",30,0,10,0)
	{
		Exp = 1;
		HasItem = new SlimeCore();

    }
}
public class Goblin : Enemy
{
	public Goblin(): base("고블린", 50, 0, 20, 10)
	{
		Exp = 3;
        HasItem = new GoblinEar();
    }
}
public class Skeleton : Enemy
{
	public Skeleton() : base("스켈레톤", 50, 0 ,20, 5)
	{
		Exp = 5;
        HasItem = new Skeletonbone();
    }
	
}
public class GoblinMage : Enemy
{
	public GoblinMage() : base("고블린 매이지", 40, 200, 10, 5)
	{
		HasItem = new CrudeCane();
		
        Exp = 7;
    }
}
public class Hobgoblin : Enemy
{
	public Hobgoblin() : base("홉고블린", 70, 50, 30, 20)
	{
        HasItem = new CrudeSword();
        Exp = 10;
    }
}
public class LittleDevil : Enemy
{
	public LittleDevil() : base("꼬마 악마", 100,50,40,25)
	{
		Exp = 20;
	}
}
public class GatekeeperGolem : Enemy
{
	public GatekeeperGolem() : base("수문장골렘", 300, 0, 30, 40)
	{
		Exp = 35;
	}
}
public class Orc : Enemy
{
    public Orc() : base("오크",120,20,25,20)
	{
        Exp = 15;
    }
}
public class Gargoyle : Enemy
{
	public Gargoyle() : base("가고일",150 ,0,20,30)
	{
		Exp = 20;
	}
}
public class WaterSpirit : Enemy
{
	public WaterSpirit() : base("물의정령",100,100,20,20)
	{
        Exp = 25;
    }
}
public class Dragon : Enemy
{
    public Dragon(string name, int maxHp, int maxMp, int attack, int defense) : base("드래곤",9999,9999,999,999)
	{
        Exp = 0;
    }
}


