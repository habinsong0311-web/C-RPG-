using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System;

public class SellShopScene : SceneBase
{
    public override SceneKey Key => SceneKey.SellShop;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("판매", "X키 입력으로 되돌아가기");
        context.Game.PrintInventory();
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
        {
            if (choice >= 0 && choice < context.Game.inventory.Count)
            {
                Item item = context.Game.inventory[choice];
                Console.Clear();
                context.Game.PrintItem(item);
                context.Game.SellItem(item);
            }
            else
            {
                Console.WriteLine("아이템이 없습니다.");
                Console.ReadKey(true);
            }
        }
        else
        {
            Console.WriteLine("잘못 입력하셨습니다.");
            Console.ReadKey(true);
        }
    }
}
