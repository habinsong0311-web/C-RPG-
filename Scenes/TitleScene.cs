using ConsoleGameFramework.Core;
using ConsoleGameFramework.UI;

namespace ConsoleGameFramework.Scenes;

/// <summary>
/// 프로그램의 첫 화면입니다.
/// 이 프레임워크는 게임 내용이 빠져 있으므로, 여기서는 화면 전환 구조만 보여줍니다.
/// 실습에서는 이 화면을 여러분의 게임에 맞는 타이틀 화면으로 바꿔서 사용하면 됩니다.
/// </summary>
public class TitleScene : SceneBase
{
    private static readonly List<MenuOption> Menu = new List<MenuOption>
    {
        new MenuOption(1, "게임 시작", "게임을 시작합니다."),
        new MenuOption(0, "종료", "프로그램을 종료합니다.")
    };

    public override SceneKey Key => SceneKey.Title;

    public override void Render(GameContext context)
    {
        ConsoleUI.Clear();
        ConsoleUI.WriteTitle("미궁 던전", "RPG");

        ConsoleUI.WriteBox(new[]
        {
            " "
        }, "프로젝트 안내", ConsoleColor.DarkCyan);

        ConsoleUI.WriteMenu(Menu, "시작 메뉴");
    }

    public override void HandleInput(GameContext context)
    {
        int choice = ConsoleUI.ReadMenuChoice(Menu);
        switch (choice)
        {
            case 1:
                GoTo(context, SceneKey.CharacterCreation);
                break;

            case 0:
                context.Game.RequestQuit();
                break;
        }
    }
}
