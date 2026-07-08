using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System;
using System.Numerics;

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

    public int TakeDamage(int damage)
    {
        int realDamage = Math.Max(0, damage - Defense);
        if (Hp < 0)
        {
            Hp = 0;
        }
        Hp -= realDamage;
        return realDamage;
    }
    public void FullHeal()
    {
        Hp = MaxHp;
        Mp = MaxMp;
    }
    public void UpStatus()
    {
        MaxHp += 50;
        MaxMp += 50;
        Attack += 5;
        Defense += 3;
    }
    public void UseHpPotion()
    {
        Hp += 50;
        if (Hp > MaxHp)
        {
            Hp = MaxHp;
        }
    }
    public void UseMpPotion()
    {
        Mp += 50;
        if (Mp > MaxMp)
        {
            Mp = MaxMp;
        }
    }
    public void LoadStatus(int hp, int maxHp, int mp, int maxMp, int attack, int defense)
    {
        Hp = hp;
        MaxHp = maxHp;
        Mp = mp;
        MaxMp = maxMp;
        Attack = attack;
        Defense = defense;
    }
}
