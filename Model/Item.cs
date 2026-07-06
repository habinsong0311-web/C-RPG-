using ConsoleGameFramework.Models;
using System;
using System.Collections;
using System.Xml.Linq;
enum TYPE
{
    검,
    방패,
    활,
    완드
}
public class Item
{
    public string Name { get; private set; }
    public string Type { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int MaxHp { get; private set; }
    public int Hp { get; private set; }
    public int MaxMp { get; private set; }
    public int Mp { get; private set; }
}
public Item(string name, string type,int maxHp, int maxMp, int attack, int defense)
{
    Name = name;
    this.Type = type
    MaxHp = maxHp;
    Hp = maxHp;
    MaxMp = maxMp;
    Mp = maxMp;
    Attack = attack;
    Defense = defense;
}
public class WoodSword : Item
{
    public WoodSword(string name) : base("나무 검",TYPE.검,0,0,10,0)
    {
    }
}
