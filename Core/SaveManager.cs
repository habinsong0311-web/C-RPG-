using System.Text.Json;
using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;

public static class SaveManager
{
    private static readonly string SavePath = "save.json";

    public static void Save(GameContext context)
    {
        if (context.Player == null)
            return;

        SaveData data = new SaveData
        {
            Name = context.Player.Name,
            Job = context.Player.Job,

            Level = context.Player.Level,
            Exp = context.Player.Exp,
            MaxExp = context.Player.MaxExp,
            Money = context.Player.Money,

            Hp = context.Player.Hp,
            MaxHp = context.Player.MaxHp,
            Mp = context.Player.Mp,
            MaxMp = context.Player.MaxMp,

            Attack = context.Player.Attack,
            Defense = context.Player.Defense,

            InventoryItemNames = context.Game.inventory
                .Select(item => item.Name)
                .ToList(),

            EquippedWeaponName = context.Game.EquippedWeapon?.Name,
            EquippedShieldName = context.Game.EquippedShield?.Name,
            EquippedArmorName = context.Game.EquippedArmor?.Name
        };

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(SavePath, json);
    }

    public static SaveData? Load()
    {
        if (!File.Exists(SavePath))
            return null;

        string json = File.ReadAllText(SavePath);
        return JsonSerializer.Deserialize<SaveData>(json);
    }

    public static void LoadToGame(GameContext context)
    {
        SaveData? data = Load();

        if (data == null)
        {
            Console.WriteLine("저장 파일이 없습니다.");
            Console.ReadKey(true);
            return;
        }

        context.Player = data.Job switch
        {
            "전사" => new Warrior(data.Name),
            "암살자" => new Assassin(data.Name),
            "마법사" => new Mage(data.Name),
            _ => new Warrior(data.Name)
        };

        context.Player.Level = data.Level;
        context.Player.Exp = data.Exp;
        context.Player.MaxExp = data.MaxExp;
        context.Player.Money = data.Money;

        context.Player.LoadStatus(
            data.Hp,
            data.MaxHp,
            data.Mp,
            data.MaxMp,
            data.Attack,
            data.Defense
        );

        context.Game.inventory.Clear();
        context.Game.ClearEquipment();

        foreach (string itemName in data.InventoryItemNames)
        {
            context.Game.AddItem(ItemFactory.Create(itemName));
        }

        if (data.EquippedWeaponName != null)
            context.Game.AddEquipment(ItemFactory.Create(data.EquippedWeaponName));

        if (data.EquippedShieldName != null)
            context.Game.AddEquipment(ItemFactory.Create(data.EquippedShieldName));

        if (data.EquippedArmorName != null)
            context.Game.AddEquipment(ItemFactory.Create(data.EquippedArmorName));
    }

    
}