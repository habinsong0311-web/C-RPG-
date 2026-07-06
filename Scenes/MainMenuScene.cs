using ConsoleGameFramework.Core;
using ConsoleGameFramework.UI;
using System;

public class MainMenu : SceneBase
{
    public override SceneKey Key => SceneKey.MainMenu;
    private static readonly List<MenuOption> mainMenu = new List<MenuOption>
    {
        new MenuOption(1,"인벤토리",""),
        new MenuOption(2,"장비창",""),
        new MenuOption(3,"세이브",""),
        new MenuOption(4,"로드",""),
        new MenuOption(4,"설정",""),
        new MenuOption(9, "게임종료", "")
    };
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("메인메뉴");
        context.PrintStat();
        ConsoleUI.WriteMenu(mainMenu, "메뉴 선택");

    }
    //인벤토리
    // 20개 배열과 중복되는건 X2 이런식으로 나타내기
    //장비창 // 장비창 열고 처음 기본장비들을 장착하고있어야함 장착했을때 능력치 오르고 빠졌을떄 능력치 빼야됨?
    //플레이어 데이터 창이 따로 있어야 하는가?
    //세이브
    //로드
    //설정?// 필요한가?
    //게임종료
    //플레이어 상태창을 만들어 보여준다
    public override void HandleInput(GameContext context)
    { }



}
