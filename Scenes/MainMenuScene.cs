using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System;
using System.Diagnostics;
using System.Xml.Linq;

public class MainMenu : SceneBase
{
    public override SceneKey Key => SceneKey.MainMenu;
    private static readonly List<MenuOption> mainMenu = new List<MenuOption>
    {
        new MenuOption(1,"인벤토리",""),
        new MenuOption(2,"장비창",""),
        new MenuOption(3,"세이브",""),
        new MenuOption(4,"로드",""),
        new MenuOption(5,"설정",""),
        new MenuOption(9, "게임종료", "")
    };
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("메인메뉴", "X키 입력으로 되돌아가기");
        context.PrintStat();
        ConsoleUI.WriteMenu(mainMenu, "메뉴 선택");


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
                    context.Game.PushScene(SceneKey.inventory);
                    return;
                    //인벤토리 이동
                case 2:
                    context.Game.PushScene(SceneKey.Equipment);
                    return;
                    //장비창 이동
                    break;
                case 3:
                    //세이브 이동
                    SaveManager.Save(context);
                    Console.WriteLine("저장되었습니다.");
                    Console.ReadKey(true);
                    break;
                case 4:
                    SaveManager.LoadToGame(context);
                    Console.WriteLine("로드되었습니다.");
                    Console.ReadKey(true);
                    context.Game.ChangeScene(SceneKey.playerHomeMap);

                    Console.ReadKey(true);
                    break;
                case 5:
                    //설정 이동
                    break;
                case 9:
                    context.Game.RequestQuit();
                    break;
            }
    }

}
