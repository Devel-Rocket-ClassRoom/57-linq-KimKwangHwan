using System;
using System.Collections.Generic;
using System.Linq;

GameItem[] inventory = new GameItem[]
{
    new GameItem("나무 검", "무기", "일반", 100, 3),
    new GameItem("강철 대검", "무기", "희귀", 800, 1),
    new GameItem("용의 검", "무기", "전설", 5000, 1),
    new GameItem("가죽 갑옷", "방어구", "일반", 200, 2),
    new GameItem("미스릴 갑옷", "방어구", "희귀", 1200, 1),
    new GameItem("드래곤 갑옷", "방어구", "전설", 8000, 0),
    new GameItem("체력 물약", "소비", "일반", 50, 10),
    new GameItem("마나 물약", "소비", "일반", 80, 5),
    new GameItem("고급 물약", "소비", "희귀", 500, 0),
    new GameItem("엘릭서", "소비", "전설", 3000, 2),
};


Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");
var query1 = from item in inventory
             where item.Price >= 500
             orderby item.Price descending
             select item;
foreach (var item in query1)
{
    Console.WriteLine($"{item.Name} - {item.Type} - {item.Price}원");
}
Dictionary<string, int> orders = new Dictionary<string, int>
{
    { "일반", 0 },
    { "희귀", 1 },
    { "전설", 2 }
};

Console.WriteLine("\n=== 쿼리 2: 무기 타입 (등급순) ===");
var query2 = from item in inventory
             where item.Type == "무기"
             orderby orders[item.Grade]
             select item;
foreach (var item in query2)
{
    Console.WriteLine($"{item.Name} - {item.Type} - {item.Price}원");
}

Console.WriteLine("\n=== 쿼리 3: 총 가치 1000 이상 ===");
var query3 = from item in inventory
             let total = item.Price * item.Quantity
             where total >= 1000
             select new { Name = item.Name, Total = total };
foreach (var item in query3)
{
    Console.WriteLine($"{item.Name} - 총 가치: {item.Total}");
}

Console.WriteLine("\n=== 쿼리 4: 품절 아이템 (이름순) ===");
var query4 = from item in inventory
             where item.Quantity == 0
             orderby item.Name
             select item;
foreach (var item in query4)
{
    Console.WriteLine($"{item.Name}");
}

Console.WriteLine("\n=== 쿼리 5: 전설 등급 (이름과 가격) ===");
var query5 = from item in inventory
             where item.Grade == "전설"
             select new { Name = item.Name, Price = item.Price };
foreach (var item in query5)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}