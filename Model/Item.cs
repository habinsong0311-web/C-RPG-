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
    전리품,
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
    public int SellMoney = 0;
    public int BuyMoney = 0;
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
public class Loot : Item
{
        public int SellMoney = 0;
        public int BuyMoney = 0;

    public Loot(string name, TYPE type, string description) : base(name, type, 0, 0, 0, 0, description)
    {
    }

}
public class SlimeCore : Loot
{
    public SlimeCore() : base("슬라임의 핵",TYPE.전리품,"슬라임이 죽고 남김 슬라임의 핵이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 10;
        BuyMoney = 10;
    }
}
public class GoblinEar : Loot
{
    public GoblinEar() : base("고블린의 귀",TYPE.전리품,"죽은 고블린의 귀이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 15;
        BuyMoney = 15;
    }
}
public class Skeletonbone : Loot
{
    public Skeletonbone() : base("뼈다귀",TYPE.전리품,"스켈레톤을 잡고 나온 뼈다귀이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 20;
        BuyMoney = 20;
    }
}
public class CrudeCane : Loot
{
    public CrudeCane() : base("조잡한지팡이", TYPE.전리품, "고블린메이지가 사용하는 조잡한 지팡이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
}
public class CrudeSword : Loot
{
    public CrudeSword() : base("조잡한검", TYPE.전리품, "홉고블린이 사용하는 조잡한 검이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 40;
        BuyMoney = 40;
    }
}
public class DevilHorns : Loot
{
    public DevilHorns() : base("악마의뿔", TYPE.전리품, "작은 악마의 뿔이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 80;
        BuyMoney = 80;
    }
}
public class GolemCore : Loot
{
    public GolemCore() : base("골램의핵", TYPE.전리품, "골램의핵이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 300;
        BuyMoney = 300;
    }
}
public class OrcFang : Loot
{
    public OrcFang() : base("오크의어금니", TYPE.전리품, "오크의 어금니이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 100;
        BuyMoney = 100;
    }
}
public class GargoyleClaw : Loot
{
    public GargoyleClaw() : base("가고일의 발톱", TYPE.전리품, "단단한 가고일의 발톱이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 120;
        BuyMoney = 120;
    }
}
public class SpiritStone : Loot
{
    public SpiritStone() : base("정령석", TYPE.전리품, "정령의힘을 머금은 돌이다 상점에 팔면 돈을 준다")
    {
        SellMoney = 150;
        BuyMoney = 150;
    }
}
public class WoodSword : Item
{
    public WoodSword() : base("나무 검", TYPE.한손검, 0, 0, 10, 0, "나무로 만든 낡은 나무 검이다\n착용시 공격력이 10증가한다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
};
public class IronSword : Item
{
    public IronSword() : base("철 검", TYPE.한손검, 0, 0, 20, 0, "철로 만든 검이다\n착용시 공격력이 20증가한다")
    {
        SellMoney = 400;
        BuyMoney = 400;
    }
};
public class MithrilSword : Item
{
    public MithrilSword() : base("미스릴 검", TYPE.한손검, 0, 0, 60, 0, "가장 단단한 광석으로 알려진 미스릴로 만든 검이다 강력한 위력을 자랑한다\n착용시 공격력이 60증가한다")
    {
        SellMoney = 2000;
        BuyMoney = 2000;
    }
};
public class WoodShield : Item
{
    public WoodShield() : base("나무 방패",TYPE.방패, 0, 0, 0, 10, "나무로 만든 낡은 나무 방패이다\n착용시 방어력이 10증가한다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
};
public class IronShield : Item
{
    public IronShield() : base("철 방패",TYPE.방패, 0, 0, 0, 30, "철로 만든 방패이다 준수한 방어력을 유지한다\n착용시 방어력이 30증가한다")
    {
        SellMoney = 500;
        BuyMoney = 500;
    }
};
public class WoodDagger : Item
{
    public WoodDagger() : base("나무 단검", TYPE.단검, 0, 0, 15, 0, "나무로 만든 낡은 나무 단검이다\n착용시 공격력이 15증가한다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
}; public class IronDagger : Item
{
    public IronDagger() : base("철 단검", TYPE.단검, 0, 0, 35, 0, "철로만든 단검이다 급소를 찌르기 편해진다\n착용시 공격력이 35증가한다")
    {
        SellMoney = 500;
        BuyMoney = 500;
    }
}; public class MithrilDagger : Item
{
    public MithrilDagger() : base("나무 단검", TYPE.단검, 0, 0, 65, 0, "가장 단단한 광석으로 알려진 미스릴로 만든 단검이다\n착용시 공격력이 65증가한다")
    {
        SellMoney = 2100;
        BuyMoney = 2100;
    }
};
public class Woodwand : Item
{
    public Woodwand() : base("나무 완드",TYPE.완드, 0, 20, 5, 0, "나무로 만든 낡은 나무 완드이다\n착용시 공격력이 5증가하고 마나가 20 증가한다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
}; 
public class OldTreewand : Item
{
    public OldTreewand() : base("고목나무 완드",TYPE.완드, 0, 50, 10, 0, "고목나무로 만든 완드이다\n착용시 공격력이 10증가하고 마나가 50 증가한다")
    {
        SellMoney = 400;
        BuyMoney = 400;
    }
}; 
public class StaffOfTheArchmage : Item
{
    public StaffOfTheArchmage() : base("대마법사의 지팡이",TYPE.완드, 0, 200, 20, 0, "대마법사가 사용하던 지팡이이다 재료는 알려지지않았다\n착용시 공격력이 20증가하고 마나가 200 증가한다")
    {
        SellMoney = 5000;
        BuyMoney = 5000;
    }
}; 
public class ClothClothes : Item
{
    public ClothClothes() : base("천 옷",TYPE.옷, 0, 0, 0, 5, "입으면 움직이기 편한 천 옷이다\n착용시 방어력이 5증가한다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
};
public class LeatherClothes : Item
{
    public LeatherClothes() : base("가죽 옷", TYPE.옷, 0, 0, 0, 10, "활동성이 좋으며 방어력이 좋은 가죽 옷이다\n착용시 방어력이 10증가한다")
    {
        SellMoney = 200;
        BuyMoney = 200;
    }
}; 
public class MageRobe : Item
{
    public MageRobe() : base("마법사의 로브", TYPE.옷, 0, 0, 0, 30, "마법사들이 주로입는 로브이다 착용하면 마나가 올라간다\n착용시 마나가 30증가한다")
    {
        SellMoney = 200;
        BuyMoney = 200;
    }
}; 
public class IronArmor : Item
{
    public IronArmor() : base("철 갑옷", TYPE.옷, 0, 0, 0, 30, "입으면 움직이기 불편하지만 방어력이 뛰어난 철 갑옷이다\n착용시 방어력이 30증가한다")
    {
        SellMoney = 30;
        BuyMoney = 30;
    }
};
public class HpPotion : Item
{
    public HpPotion() : base("HP포션",TYPE.소모품, 50, 0, 0, 0, "체력을 회복시켜주는 포션이다\n사용시 HP를 50 회복한다")
    {
        SellMoney = 100;
        BuyMoney = 100;
    }
};
public class MpPotion : Item
{
    public MpPotion() : base("MP포션",TYPE.소모품, 0, 50, 0, 0, "마나를 회복시켜주는 포션이다\n사용시 MP를 50 회복한다")
    {
        SellMoney = 100;
        BuyMoney = 100;
    }
};





