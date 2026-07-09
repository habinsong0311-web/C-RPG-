using ConsoleGameFramework.Core;

public class SaveData
{
    public string Name { get; set; }
    public string Job { get; set; }

    public int Level { get; set; }
    public int Exp { get; set; }
    public int MaxExp { get; set; }
    public int Money { get; set; }

    public int Hp { get; set; }
    public int MaxHp { get; set; }
    public int Mp { get; set; }
    public int MaxMp { get; set; }

    public int Attack { get; set; }
    public int Defense { get; set; }


    public List<string> InventoryItemNames { get; set; } = new();

    public string? EquippedWeaponName { get; set; }
    public string? EquippedShieldName { get; set; }
    public string? EquippedArmorName { get; set; }
}