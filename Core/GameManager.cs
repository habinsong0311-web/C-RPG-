using ConsoleGameFramework.Models;
using ConsoleGameFramework.Scenes;
using ConsoleGameFramework.UI;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleGameFramework.Core;

/// <summary>
/// 게임의 전체 흐름을 담당하는 클래스입니다.
///
/// 역할:
/// 1. Scene 등록
/// 2. 현재 Scene 실행
/// 3. Scene 전환
/// 4. 프로그램 종료 요청 처리
///
/// 참고: 이 클래스는 프로그램 전체에서 단 하나만 존재해야 하므로 Singleton 패턴으로 작성되어 있습니다.
/// (생성자를 private으로 막고, 정적 Instance 프로퍼티로만 접근을 허용)
/// </summary>
public class GameManager
{
    private readonly Dictionary<SceneKey, IScene> _scenes = new Dictionary<SceneKey, IScene>();
    private IScene? _currentScene;

    /// <summary>
    /// 프로그램 전체에서 하나만 사용하는 GameManager 인스턴스입니다.
    /// </summary>
    public static GameManager Instance { get; } = new GameManager();

    private GameManager()
    {
        Context = new GameContext(this);
        RegisterScenes();
    }

    public GameContext Context { get; }

    /// <summary>
    /// 게임에서 사용할 화면들을 등록합니다.
    /// 새 화면을 만들었다면 이곳에 AddScene(new MyScene()) 형식으로 추가합니다.
    /// </summary>
    private void RegisterScenes()
    {
        AddScene(new TitleScene());
        AddScene(new SampleScene());
        AddScene(new BattleScene());
        AddScene(new CharacterCreationScene());
        AddScene(new playerHomeMapScene());
        AddScene(new MainMenu());
        AddScene(new inventoryScene());
        AddScene(new Equipment());
        AddScene(new LabyrinthVillageScene());
        AddScene(new Labyrinth1FScene());
        AddScene(new Labyrinth2FScene());
        AddScene(new Labyrinth3FScene());
        AddScene(new Labyrinth4FScene());
        AddScene(new Labyrinth5FScene());
        AddScene(new Labyrinth6FScene());
        AddScene(new Labyrinth7FScene());
        AddScene(new Labyrinth8FScene());
        AddScene(new Labyrinth9FScene());
        AddScene(new Labyrinth10FScene());
        AddScene(new ShopchoiceScene());
        AddScene(new EquipmentShopScene());
        AddScene(new ConsumablesShopScene());
        AddScene(new SellShopScene());



    }

    private void AddScene(IScene scene)
    {
        _scenes[scene.Key] = scene;
    }

    /// <summary>
    /// 프로그램의 메인 루프입니다.
    /// 현재 Scene을 그리고(Render), 화면에 반영(Present), 입력을 처리(HandleInput)하는 과정을 반복합니다.
    /// </summary>
    public void Run()
    {
        ChangeScene(SceneKey.Title);

        while (Context.IsRunning && _currentScene is not null)
        {
            _currentScene.Render(Context);
            ConsoleUI.Present();
            _currentScene.HandleInput(Context);
        }

        ConsoleUI.Clear();
        ConsoleUI.WriteTitle("게임 종료", "수고하셨습니다.");
        ConsoleUI.WriteBox(new[]
        {
            "미궁RPG가 종료되었습니다.",
        }, "Good Bye", ConsoleColor.DarkCyan);
        ConsoleUI.Present();
    }

    /// <summary>
    /// 다른 화면으로 전환합니다.
    /// </summary>
    public void ChangeScene(SceneKey key)
    {
        if (!_scenes.TryGetValue(key, out IScene? nextScene))
        {
            Context.AddLog($"등록되지 않은 화면입니다: {key}");
            return;
        }

        _currentScene?.Exit(Context);
        _currentScene = nextScene;
        _currentScene.Enter(Context);
    }

    /// <summary>
    /// 게임 종료를 요청합니다.
    /// </summary>
    public void RequestQuit()
    {
        Context.IsRunning = false;
    }
    private readonly Stack<SceneKey> Menu = new();
    public void PushScene(SceneKey nextScene)//다음창으로 넘어가는 스택
    {
        Menu.Push(_currentScene.Key);
        ChangeScene(nextScene);
    }
    public void PopScene() // 되돌아가는 함수
    {
        SceneKey backScene = Menu.Pop();
        ChangeScene(backScene);
    }



    public readonly List<Item> inventory = new List<Item>();//인벤토리 구현화

    public void PrintInventory()// 인벤토리를 출력하는 함수
    {

        ConsoleUI.WriteSubtitle("인벤토리 목록");
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"{i}.{inventory[i].Name}");
        }
    }

    public void AddItem(Item item) // 인벤토리에 아이템 추가
    {
        inventory.Add(item);
    }
    public void RemoveItem(Item item) // 인벤토리에 아이템 삭제
    {
        inventory.Remove(item);
    }
    public void SellItem(Item item)
    {
        Console.WriteLine("================================");
        Console.WriteLine($"아이템을 {item.SellMoney}원에 판매하시겠습니까?\n1.Yes / 2.NO");
        string inputA = Console.ReadLine();
        if (inputA == "1")
        {
            Context.Player.AddMoney(item.SellMoney);
            RemoveItem(item);
        }
        else if (inputA == "2")
        {
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("잘못 입력된 키입니다");
        }
    }
    
    public void PrintItem(Item item)
    {
        Console.WriteLine($"{item.Name} / 타입 : {item.Type}");
        Console.WriteLine($"HP {item.MaxHp} / MP{item.MaxMp}");
        Console.WriteLine($"공격력 {item.Attack} / 방어력{item.Defense}");
        Console.WriteLine($"{item.Description}");
    }
    public void ItemEquipment(Item item)
    {
        if (item.Type == TYPE.소모품)
        {
            Console.WriteLine("================================");
            Console.WriteLine("사용하시겠습니까?\n1.Yes / 2.NO");

            string inputA = Console.ReadLine();

            if (inputA == "1")
            {
                if (item.Name == "HP포션")
                {
                    RemoveItem(item);
                    Context.Player.UseHpPotion();
                }
                else if (item.Name == "MP포션")
                {
                    RemoveItem(item);
                    Context.Player.UseMpPotion();
                }
            }

            return;
        }
        else if (item.Type == TYPE.기타 || item.Type == TYPE.전리품)
        {
            Console.WriteLine("================================");
            Console.ReadKey(true);
            return;
        }
        else
        {
            Console.WriteLine("================================");
            Console.WriteLine("착용하시겠습니까?\n1.Yes / 2.NO");

            string input = Console.ReadLine();

            if (input == "1")
            {
                if (item.Type == TYPE.방패)
                {
                    if (EquippedShield != null)
                        SwapEquipment(EquippedShield, item);
                    else
                    {
                        AddEquipment(item);
                        Context.Player.ItemStatusUp(item);
                        RemoveItem(item);
                    }
                }
                else if (item.Type == TYPE.옷)
                {
                    if (EquippedArmor != null)
                        SwapEquipment(EquippedArmor, item);
                    else
                    {
                        AddEquipment(item);
                        Context.Player.ItemStatusUp(item);
                        RemoveItem(item);
                    }
                }
                else
                {
                    if (EquippedWeapon != null)
                        SwapEquipment(EquippedWeapon, item);
                    else
                    {
                        AddEquipment(item);
                        Context.Player.ItemStatusUp(item);
                        RemoveItem(item);
                    }
                }
            }
        }
    }
    public void SwapEquipment(Item itemA, Item itemB)
    {
        Context.Player.ItemStatusDown(itemA);
        Context.Player.ItemStatusUp(itemB);
        inventory.Add(itemA);
        AddEquipment(itemB);
        inventory.Remove(itemB);
    }

    public Item? EquippedWeapon { get; private set; }
    public Item? EquippedShield { get; private set; }
    public Item? EquippedArmor { get; private set; }


    public void PrintEquipment()// 장비를 출력하는 함수
    {
        ConsoleUI.WriteSubtitle("착용중인 장비");
        Console.WriteLine($"1.무기 : {(EquippedWeapon == null ? "장착아이템이 없습니다." : EquippedWeapon.Name)}");
        Console.WriteLine($"2.방패 : {(EquippedShield == null ? "장착아이템이 없습니다." : EquippedShield.Name)}");
        Console.WriteLine($"3.갑옷 : {(EquippedArmor == null ? "장착아이템이 없습니다." : EquippedArmor.Name)}");


    }
    
    public void AddEquipment(Item item)
    {
        if (item.Type == TYPE.방패)
        {
            EquippedShield = item;
            return;
        }
        else if (item.Type == TYPE.옷)
        {
            EquippedArmor = item;
            return;
        }
        else
        {
            EquippedWeapon = item;
            return;
        }

    }
    public void RemoveEquipment(Item item)
    {
        if (item.Type == TYPE.방패)
        {
            EquippedShield = null;
            return;
        }
        else if (item.Type == TYPE.옷)
        {
            EquippedArmor = null;
            return;
        }
        else
        {
            EquippedWeapon = null;
            return;
        }
    }
    public void RemoveEquipmentChoice(Item item)
    {
        Console.Clear();
        if (item == null)
        {
            Console.WriteLine("장착 중인 무기가 없습니다.");
            Console.ReadKey(true);
            return;
        }
        Console.WriteLine($"현재 {item.Name}을(를) 장착중입니다 해제하시겠습니까?");
        Console.WriteLine($"1 Yes / 2. No");
        string inputA = Console.ReadLine();
        if (inputA == "1")
        {
            AddItem(item);
            RemoveEquipment(item);
            Context.Player.ItemStatusDown(item);
        }
        else if (inputA == "2")
        {
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("잘못 입력된 키입니다");
        }
    }
    public void PlayerMove(MapTileType[,] Map, int playerY, int playerX)
    {

        return;
    }
    public void ClearEquipment()
    {
        EquippedWeapon = null;
        EquippedShield = null;
        EquippedArmor = null;
    }

}



