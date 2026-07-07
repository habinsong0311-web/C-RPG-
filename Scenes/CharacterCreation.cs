using System.Text;
using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;

public class CharacterCreationScene : SceneBase
{
    private static readonly List<MenuOption> JobMenu = new List<MenuOption>
    {
        new MenuOption(1,"전사","검과 방패를 사용하며 체력과 방어력이 높다"),
        new MenuOption(2,"암살자","단검을 사용하며 공격력이 높다"),
        new MenuOption(3,"마법사","완드를 사용하며 마법공격을 할수있다"),
        new MenuOption(9, "타이틀로", "첫 화면으로 돌아갑니다.")
    };
    public override SceneKey Key => SceneKey.CharacterCreation;
    public override void Render(GameContext context)
    {
        context.Game.AddEquipment(new WoodSword());
        context.Game.AddEquipment(new WoodShield());
        context.Game.AddEquipment(new ClothClothes());
        context.Game.RemoveEquipment(new ClothClothes());
        //임시
        Console.Clear();
        ConsoleUI.WriteBox(new[]
        {
            "먼저 이름을 입력하고,",
            "원하는 직업을 선택하세요."
        }, "안내", ConsoleColor.DarkCyan);

        ConsoleUI.WriteMenu(JobMenu, "직업 선택");
    }
    public override void HandleInput(GameContext context)
    {
        string name = ConsoleUI.ReadString("이름을 입력하세요");

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "플레이어";
        }

        int choice = ConsoleUI.ReadMenuChoice(JobMenu);
        switch (choice)
        {
            case 1:
                context.AddLog($"{name} 님이 전사를 선택했습니다.");
                context.Player = new Warrior(name);
                context.Game.AddItem(new WoodSword());
                context.Game.AddItem(new WoodShield());
                context.Game.AddItem(new ClothClothes());
                context.Game.AddItem(new HpPotion());
                context.Game.AddItem(new MpPotion());
                GoTo(context, SceneKey.playerHomeMap);
                break;

            case 2:
                context.AddLog($"{name} 님이 암살자를 선택했습니다.");
                context.Player = new Assassin(name);
                context.Game.AddItem(new WoodDagger());
                context.Game.AddItem(new ClothClothes());
                context.Game.AddItem(new HpPotion());
                context.Game.AddItem(new MpPotion());
                GoTo(context, SceneKey.playerHomeMap);
                break;

            case 3:
                context.AddLog($"{name} 님이 마법사를 선택했습니다.");
                context.Player = new Mage(name);
                context.Game.AddItem(new Woodwand());
                context.Game.AddItem(new ClothClothes());
                context.Game.AddItem(new HpPotion());
                context.Game.AddItem(new MpPotion());
                GoTo(context, SceneKey.playerHomeMap);
                break;

            case 9:
                GoTo(context, SceneKey.Title);
                break;
        }
    }
}