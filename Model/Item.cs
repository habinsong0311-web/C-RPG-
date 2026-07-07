using ConsoleGameFramework.Models;
using System;
using System.Collections;
using System.Xml.Linq;
namespace ConsoleGameFramework.Models;

public enum TYPE
{
    옷,
    한손검,
    단검,
    방패,
    활,
    완드,
    소모품,
    기타

}
public class Item
{
    public string Name { get; private set; }
    public TYPE Type { get; private set; }
    public string Description { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int MaxHp { get; private set; }
    public int Hp { get; private set; }
    public int MaxMp { get; private set; }
    public int Mp { get; private set; }
    public Item(string name, TYPE type, int maxHp, int maxMp, int attack, int defense, string description)
    {
        Name = name;
        this.Type = type;
        MaxHp = maxHp;
        Hp = maxHp;
        MaxMp = maxMp;
        Mp = maxMp;
        Attack = attack;
        Defense = defense;
        Description = description;
    }
}

public class WoodSword : Item
{
    public WoodSword() : base("나무 검", TYPE.한손검, 0, 0, 10, 0, "나무로 만든 낡은 나무 검이다\n착용시 공격력이 10증가한다")
    {
    }
};
public class WoodShield : Item
{
    public WoodShield() : base("나무 방패",TYPE.방패, 0, 0, 0, 10, "나무로 만든 낡은 나무 방패이다\n착용시 방어력이 10증가한다")
    {
    }
};
public class WoodDagger : Item
{
    public WoodDagger() : base("나무 단검",TYPE.단검, 0, 0, 15, 0, "나무로 만든 낡은 나무 단검이다\n착용시 공격력이 15증가한다")
    {
    }
};
public class Woodwand : Item
{
    public Woodwand() : base("나무 완드",TYPE.완드, 0, 20, 5, 0, "나무로 만든 낡은 나무 완드이다\n착용시 공격력이 5증가하고 마나가 20 증가한다")
    {
    }
}; 
public class ClothClothes : Item
{
    public ClothClothes() : base("천 옷",TYPE.옷, 0, 0, 0, 5, "입으면 움직이기 편한 천 옷이다\n착용시 방어력이 5증가한다")
    {
    }
};
public class HpPotion : Item
{
    public HpPotion() : base("HP포션",TYPE.소모품, 0, 0, 0, 0, "체력을 회복시켜주는 포션이다\n사용시 HP를 50 회복한다")
    {
    }
};
public class MpPotion : Item
{
    public MpPotion() : base("MP포션",TYPE.소모품, 0, 0, 0, 0, "마나를 회복시켜주는 포션이다\n사용시 MP를 50 회복한다")
    {
    }
};





