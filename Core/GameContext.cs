using ConsoleGameFramework.Models;
using ConsoleGameFramework.Core;
using ConsoleGameFramework.UI;
using System;

namespace ConsoleGameFramework.Core;

/// <summary>
/// 게임 전체에서 공유해야 하는 데이터를 모아두는 클래스입니다.
///
/// 이 프레임워크에는 게임 내용이 빠져 있으므로 지금은 아주 단순합니다.
/// 실습에서 캐릭터, 인벤토리, 스테이지 같은 데이터가 필요해지면
/// 이 클래스에 프로퍼티를 추가하고, 관련 로직은 별도의 Systems/ 폴더를 만들어 분리하는 걸 권장합니다.
/// (예: Player Player, Inventory Inventory, BattleSystem Battle 등)
/// </summary>
public class GameContext
{
    private const int MaxLogCount = 8;

    public GameContext(GameManager game)
    {
        Game = game;
    }

    /// <summary>
    /// 화면 전환과 프로그램 종료를 담당하는 매니저입니다.
    /// Scene에서 context.Game.ChangeScene(...) 형태로 사용합니다.
    /// </summary>
    public GameManager Game { get; }

    /// <summary>
    /// 난수 생성기입니다. 전투 데미지, 랜덤 이벤트 등 무작위 요소가 필요할 때 사용합니다.
    /// Random을 여기저기서 각각 새로 만들면 같은 시드로 인해 패턴이 반복될 수 있으므로,
    /// 프로그램 전체에서 이 인스턴스 하나만 공유해서 씁니다.
    /// </summary>
    public Random Random { get; } = new Random();

    /// <summary>
    /// 화면 하단에 보여줄 최근 진행 로그입니다.
    /// ConsoleUI.WriteLog(context.Logs)로 그대로 출력할 수 있습니다.
    /// </summary>
    public List<string> Logs { get; } = new List<string>();

    /// <summary>
    /// 게임 루프를 계속 실행할지 판단하는 플래그입니다.
    /// false가 되면 프로그램이 종료됩니다.
    /// </summary>
    public bool IsRunning { get; set; } = true;
   
    /// <summary>
    /// 최근 로그를 추가합니다. 로그가 너무 길어지지 않도록 오래된 로그는 제거합니다.
    /// </summary>
    public void AddLog(string message)
    {
        Logs.Add($"[{DateTime.Now:HH:mm:ss}] {message}");

        while (Logs.Count > MaxLogCount)
        {
            Logs.RemoveAt(0);
        }
    }
    public SceneKey BattleMapKey { get; set; }
    public int BattleMonsterY { get; set; }
    public int BattleMonsterX { get; set; }
    public bool IsMonsterDefeated { get; set; }
    public Player? Player { get; set; }
    public void PrintStat()
    {
        if (Player == null)
        {
            Console.WriteLine("플레이어 정보가 없습니다.");
            return;
        }
        Console.WriteLine($"{Player.Name} / Level : {Player.Level} /직업: {Player.Job}");
        Console.WriteLine($"HP:{Player.Hp} / {Player.MaxHp} MP:{Player.Mp} / {Player.MaxMp}");
        Console.WriteLine($"현재 경험치:{Player.Exp} / {Player.MaxExp}");
        Console.WriteLine($"공격력:{Player.Attack} 방어력:{Player.Defense}");
        Console.WriteLine($"소지금:{Player.Money}원");
    }
    public void PlayerLevelUp()
    {
        if(Player.Exp >= Player.MaxExp)
        {
            Player.Exp -= Player.MaxExp;
            Player.MaxExp *= 2;
            Player.UpStatus();
            Player.FullHeal();
            Console.WriteLine($"레벨업!\n레벨이 {Player.Level} -> {Player.Level + 1}이 되었습니다");
            Player.Level += 1;
        }
        return;
    }


}
