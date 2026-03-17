using System;
using System.Collections.Generic;
using System.Linq;

Product[] products = new Product[]
{
    new Product("Laptop", "Eletronics", 1200),
    new Product("Mouse", "Eletronics", 25),
    new Product("Keyboard", "Eletronics", 75),
    new Product("Shirt", "Clothing", 50),
    new Product("Pants", "Clothing", 100),
    new Product("Desk", "Furniture", 250),
    new Product("Chair", "Furniture", 150),
    new Product("Monitor", "Furniture", 300),
};
Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
foreach (var product in products.Where(p => p.Price >= 100))
{
    Console.WriteLine($"{product.Name}");
}

Console.WriteLine("\n=== 문제 2: Electronics 카테고리 ===");
foreach (var product in products.Where(p => p.Category == "Eletronics"))
{
    Console.WriteLine($"{product.Name} - {product.Category} - {product.Price}원");
}

Console.WriteLine("\n=== 문제 3: 이름순 정렬 ===");
foreach (var product in products.OrderBy(p => p.Name))
{
    Console.WriteLine($"{product.Name}");
}

Console.WriteLine("\n=== 문제 4: 평균 가격 ===");
Console.WriteLine($"{products.Average(p => p.Price)}원");

Console.WriteLine("\n=== 문제 5: 가장 저렴한 상품 ===");
Product minP = products.MinBy(p => p.Price);
Console.WriteLine($"{minP.Name} - {minP.Price}원");

Console.WriteLine("\n=== 문제 6: 가장 비싼 상품 ===");
Product maxP = products.MaxBy(p => p.Price);
Console.WriteLine($"{maxP.Name} - {maxP.Price}원");

Console.WriteLine("\n=== 문제 7: Electronics 평균 가격 ===");
Console.WriteLine($"{products.Where(p => p.Category == "Eletronics").Average(p => p.Price):F0}원");

Console.WriteLine("\n=== 문제 8: 'o' 포함 상품 (대문자) ===");
foreach (var NAME in products.Where(p => p.Name.Contains('o')).Select(p => p.Name.ToUpper()))
{
    Console.WriteLine($"{NAME}");
}

Console.WriteLine("\n=== 문제 9: Clothing 역순 ===");
foreach (var product in products.Where(p => p.Category == "Clothing").OrderByDescending(p => p.Name))
{
    Console.WriteLine($"{product.Name}");
}

Console.WriteLine("\n=== 문제 10: 가격 50~300, 복합 정렬 ===");
foreach (var product in products.Where(p => p.Price >= 50 && p.Price <= 300).OrderBy(p => p.Price).ThenBy(p => p.Name))
{
    Console.WriteLine($"{product.Name}");
}