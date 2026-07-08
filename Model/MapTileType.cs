using System;

namespace ConsoleGameFramework.Models;

public enum MapTileType
{
    floor,//바닥
    wall,//벽
    player,//플레이어
    fenceA,//l자 울타리 또는 가벽
    fenceB,//ㅡ자 울타리
    LabyrinthIngress,// 미궁입구
    Up,//층 위로
    Down, // 층 아래로
    monster,//몬스터
    slime,//슬라임
    goblin,//고블린
    skeleton,//스켈레톤
    goblinMage,//고블린메이지
    hobgoblin,//홉고블린
    orc,//오크
    gargoyle,//가고일
    waterSpirit,//물의정령
    littleDevil,//꼬마악마
    gatekeeperGolem,//수문장골렘
    dragon,//드레곤
    door,//문 또는 입구
}


