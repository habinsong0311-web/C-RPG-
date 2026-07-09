using System;
using System.Collections;
using System.Xml.Linq;
namespace ConsoleGameFramework.Models;

public static class ItemFactory
{
    private static readonly Dictionary<string, Func<Item>> Items = new()
    {
         // 장비
         { "나무 검", () => new WoodSword() },
         { "철 검", () => new IronSword() },
         { "미스릴 검", () => new MithrilSword() },
         { "나무 방패", () => new WoodShield() },
         { "철 방패", () => new IronShield() },
         { "나무 단검", () => new WoodDagger() },
         { "철 단검", () => new WoodDagger() },
         { "미스릴 단검", () => new IronDagger() },
         { "나무 완드", () => new MithrilDagger() },
         { "고목나무 완드", () => new OldTreewand() },
         { "대마법사의 지팡이", () => new StaffOfTheArchmage() },
         { "천 옷", () => new ClothClothes() },
         { "가죽 옷", () => new LeatherClothes() },
         { "마법사의 로브", () => new MageRobe() },
         { "철 갑옷", () => new IronArmor() },
         
         // 소모품
         { "HP포션", () => new HpPotion() },
         { "MP포션", () => new MpPotion() },
         
         // 전리품
         { "슬라임의 핵", () => new SlimeCore() },
         { "고블린의 귀", () => new GoblinEar() },
         { "뼈다귀", () => new Skeletonbone() },
         { "조잡한지팡이", () => new CrudeCane() },
         { "조잡한검", () => new CrudeSword() },
         { "악마의뿔", () => new DevilHorns() },
         { "골램의핵", () => new GolemCore() },
         { "오크의어금니", () => new OrcFang() },
         { "가고일의 발톱", () => new GargoyleClaw() },
         { "정령석", () => new SpiritStone() },
    };

    public static Item Create(string name)
    {
        if (Items.TryGetValue(name, out Func<Item>? create))
        {
            return create();
        }

        throw new Exception($"등록되지 않은 아이템입니다: {name}");
    }
}