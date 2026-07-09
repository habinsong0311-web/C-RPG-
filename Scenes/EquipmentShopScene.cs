using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Data.SqlTypes;
using System.Text;

public class EquipmentShopScene : SceneBase
{
    public override SceneKey Key => SceneKey.LabyrinthVillage;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("상점", "X키 입력으로 되돌아가기");
        List<MenuOption> buyMenu = new List<MenuOption>
        {
        new MenuOption(1, "철 검", $"{new IronSword().BuyMoney}G"),
        new MenuOption(2, "미스릴 검", $"{new MithrilSword().BuyMoney}G"),
        new MenuOption(3, "철 방패", $"{new IronShield().BuyMoney}G"),
        new MenuOption(4, "철 단검", $"{new IronDagger().BuyMoney}G"),
        new MenuOption(5, "미스릴 단검", $"{new MithrilDagger().BuyMoney}G"),
        new MenuOption(6, "고목나무 완드", $"{new OldTreewand().BuyMoney}G"),
        new MenuOption(7, "대마법사의 지팡이", $"{new StaffOfTheArchmage().BuyMoney}G"),
        new MenuOption(8, "가죽 옷", $"{new LeatherClothes().BuyMoney}G"),
        new MenuOption(9, "마법사의 로브", $"{new MageRobe().BuyMoney}G"),
        new MenuOption(10, "철 갑옷", $"{new IronArmor().BuyMoney}G")
        };
        ConsoleUI.WriteMenu(buyMenu, "구매 목록");
    }
    public override void HandleInput(GameContext context)
    {
        string input = Console.ReadLine();
        if (input == "x" || input == "X")
        {
            context.Game.PopScene();
            return;
        }
        if (int.TryParse(input, out int choice))
            switch (choice)
            {
                case 1:
                    if (context.Player.Money > )
                    {
                        context.Game.AddItem(new IronSword());
                    }
                    return;

                    //case 2:
            }
    }
}