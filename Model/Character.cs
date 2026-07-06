using System;

namespace ConsoleGameFramework.Models;

public class Character
{
    public string Name { get; private set; }
    public int MaxHp { get; private set; }
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int MaxMp { get; private set; }
    public int Mp { get; private set; }

    
    public bool IsAlive => Hp > 0;
    public Character(string name, int maxHp, int maxMp,int attack,int defense)
    {
        Name = name;
        MaxHp = maxHp;
        Hp = maxHp;
        MaxMp = maxMp;
        Mp = maxMp;
        Attack = attack;
        Defense = defense;
    }

    public void TakeDamage(int damage)
    {
        Hp = Math.Max(0, Hp - damage);
    }
}
