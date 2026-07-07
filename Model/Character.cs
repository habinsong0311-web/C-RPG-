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
    public void ItemStatusUp(Item item)
    {
        Hp += item.MaxHp;
        MaxHp += item.MaxHp;
        Mp += item.MaxMp;
        MaxMp += item.MaxMp;
        Attack += item.Attack;
        Defense += item.Defense;
    }
    public void ItemStatusDown(Item item)
    {
        Hp -= item.MaxHp;
        if(Hp <= 0)
        {
            Hp = 1;
        }
        MaxHp -= item.MaxHp;
        Mp -= item.MaxMp;
        if(Mp < 0)
        {
            Mp = 0;
        }
        MaxMp -= item.MaxMp;
        Attack -= item.Attack;
        Defense -= item.Defense;

    }

    public void TakeDamage(int damage)
    {
        Hp = Math.Max(0, Hp - damage);
    }
}
