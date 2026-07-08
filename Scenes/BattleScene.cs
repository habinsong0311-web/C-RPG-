using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System;
using System.Numerics;

public class BattleScene : SceneBase
{
    public override SceneKey Key => SceneKey.Battle;
    private static readonly List<MenuOption> Menu = new List<MenuOption>
    {
        new MenuOption(1, "기본공격","기본공격으로 몬스터를 공격합니다."),
        new MenuOption(2, "스킬1","아직 미구현."),
        new MenuOption(3, "스킬2","아직 미구현."),
        new MenuOption(4, "테스트","데미지 0으로 공격."),
        new MenuOption(0, "포기하고 종료")
    };
    

    public override void Render(GameContext context)
    {
        
        Enemy enemy = BattleManager.Instance.Enemy;
        ConsoleUI.Clear();
        ConsoleUI.WriteTitle($"{enemy.Name}과의 전투");
        ConsoleUI.WriteStatusBar(enemy.Name, enemy.Hp, enemy.MaxHp,fillColor:ConsoleColor.Red); // 적의 이름과 HP를 가져와야한다.
        ConsoleUI.WriteStatusBar(context.Player.Name, context.Player.Hp, context.Player.MaxHp); // 플레이어의 이름과 HP를 가져와야한다.

        ConsoleUI.WriteMenu(Menu, "행동 메뉴");
        ConsoleUI.WriteLog(context.Logs);
        
    }

    public override void HandleInput(GameContext context)
    {
        Enemy enemy = BattleManager.Instance.Enemy;
        if (0>= enemy.Hp)
        {

            Console.WriteLine("전투에서 승리하였습니다");
            context.Player.Exp += enemy.Exp;
            context.PlayerLevelUp();
            context.Game.AddItem(enemy.HasItem);
            Console.WriteLine("아무 키나 누르면 돌아갑니다...");
            Console.ReadKey();
            context.Game.PopScene();
            return;
        }
        else if(0 >= context.Player.Hp)
        {
            Console.WriteLine($"게임 오버\n{enemy.Name}에게 사망하셨습니다");
            context.Game.RequestQuit();
            Console.ReadKey();
            return;
        }
        int choice = ConsoleUI.ReadMenuChoice(Menu);
        switch (choice)
        {
            case 1://일반공격
                int damege = enemy.TakeDamage(context.Player.Attack);
                context.AddLog($"{context.Player.Name}의 일반공격! {damege}의 피해를 입혔습니다");
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:
                int test = enemy.TakeDamage(0);
                context.AddLog($"{context.Player.Name}의 일반공격! {test}의 피해를 입혔습니다");
                break;
            case 0:
                context.Game.RequestQuit();
                break;
        }
        if(0 < enemy.Hp)
        {
            int damege = context.Player.TakeDamage(enemy.Attack);
            context.AddLog($"{enemy.Name}의 공격! {damege}만큼 피해를입었습니다.");

        }
    }
}
