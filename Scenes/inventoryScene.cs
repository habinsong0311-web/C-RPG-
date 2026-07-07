using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

public class inventoryScene : SceneBase
{
    public override SceneKey Key => SceneKey.inventory;

    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("인벤토리","X키 입력으로 되돌아가기");
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
                context.Game.ItemEquipment(item);
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
