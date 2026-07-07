using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System;

public class Equipment : SceneBase
{
    public override SceneKey Key => SceneKey.Equipment;
    public override void Render(GameContext context)
    {
        context.Game.AddEquipment(new WoodSword());
        context.Game.AddEquipment(new WoodShield());
        context.Game.AddEquipment(new ClothClothes());
        context.Game.RemoveEquipment(new ClothClothes());
        Console.Clear();
        ConsoleUI.WriteTitle("장비창", "X키 입력으로 되돌아가기");
        context.PrintStat();
        context.Game.PrintEquipment();
        //context.Game.AddEquipment(new WoodSword());
        //현재 착용중인 장비를 보여줘야됨
    }
    public override void HandleInput(GameContext context)
    {
        string input = Console.ReadLine();
        if (input == "x" || input == "X")
        {
            context.Game.PopScene();
            return;
        }
    }
}
