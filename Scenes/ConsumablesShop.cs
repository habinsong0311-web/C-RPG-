using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Data.SqlTypes;
using System.Text;

public class ConsumablesShopScene : SceneBase
{
    public override SceneKey Key => SceneKey.ConsumablesShop;
    private readonly List<Item> shopItems = new()
    {
        new HpPotion(),
        new MpPotion(),
    };
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("소모품 구매", "X키 입력으로 되돌아가기");
        List<MenuOption> buyMenu = new();

        for (int i = 0; i < shopItems.Count; i++)
        {
            Item item = shopItems[i];
            buyMenu.Add(new MenuOption(i + 1, item.Name, $"{item.BuyMoney}G"));
        }
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
        {
            int index = choice - 1;

            if (index >= 0 && index < shopItems.Count)
            {
                Item item = shopItems[index];

                if (context.Player.Money >= item.BuyMoney)
                {
                    context.Player.Money -= item.BuyMoney;
                    context.Game.AddItem(ItemFactory.Create(item.Name));

                    Console.WriteLine($"{item.Name}을(를) 구매했습니다.");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("돈이 부족합니다.");
                    Console.ReadKey(true);
                }
            }
        }
    }
}





