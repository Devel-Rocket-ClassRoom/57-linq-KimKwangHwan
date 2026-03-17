using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

{
    int[] numbers = { 1, 2, 3, 4, 5 };

    IEnumerable<int> result = numbers.Where(n => n > 3);

    foreach (int n in result)
    {
        Console.WriteLine(n);
    }
}
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    var filtered = names.Where(n => n.Contains("a"));

    foreach (var name in filtered)
    {
        Console.WriteLine(name); 
    }
}

{
    string[] names = { "Tom", "Dick", "Harry" };

    var uppercased = names.Select(n => n.ToUpper());

    foreach (var name in uppercased)
    {
        Console.WriteLine(name);
    }
}

{
    string[] colors = { "Red", "Green", "Blue" };

    var sorted = colors.OrderBy(c => c);

    foreach (var color in sorted)
    {
        Console.WriteLine(color); 
    }
}

{
    int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };
    var descending = numbers.OrderByDescending(n => n);

    foreach (var n in descending)
    {
        Console.WriteLine(n + " "); 
    }
}

{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    var query = names
        .Where(n => n.Contains("a"))
        .OrderBy(n => n.Length)
        .Select(n => n.ToUpper());

    foreach (var name in query)
    {
        Console.WriteLine(name);
    }
}

{
    int[] numbers = { 1, 2, 3, 4, 5 };

    var query = from n in numbers
                where n % 2 == 0
                select n;

    foreach (var n in query)
    {
        Console.WriteLine(n);
    }
}

{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    var query = from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper();

    foreach (var name in query)
    {
        Console.WriteLine(name);
    }
}

{
    int[] numbers = { 3, 2, 1, 4, 5 };

    var methodResult = numbers.Where(n => n % 2 == 1).OrderBy(n => n);

    var queryResult = from n in numbers
                      where n % 2 == 1
                      orderby n
                      select n;
    Console.WriteLine("메서드 구문");
    foreach (var n in methodResult)
    {
        Console.WriteLine(n + " "); 
    }
    Console.WriteLine("\n쿼리 구문");
    foreach (var n in queryResult)
    {
        Console.WriteLine(n + " ");
    }
}

{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int sum = numbers.Sum();
    int count = numbers.Count();
    double average = numbers.Average();

    Console.WriteLine($"합계: {sum}");
    Console.WriteLine($"개수: {count}");
    Console.WriteLine($"평균: {average}");
}

{
    int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };

    int min = numbers.Min();
    int max = numbers.Max();

    Console.WriteLine($"최솟값: {min}");
    Console.WriteLine($"최댓값: {max}");
}

{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int evenSum = numbers.Where(n => n % 2 == 0).Sum();

    int countOver5 = numbers.Count(n => n > 5);

    Console.WriteLine($"짝수 합계: {evenSum}");
    Console.WriteLine($"5보다 큰 숫자 개수: {countOver5}");
}

{
    int[] numbers = { 10, 20, 30, 40, 50 };

    int first = numbers.First();
    int last = numbers.Last();

    Console.WriteLine($"첫 번째: {first}");
    Console.WriteLine($"마지막: {last}");
}

{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int firstOver3 = numbers.First(n => n > 3);

    Console.WriteLine($"3보다 큰 첫 번째: {firstOver3}");
}

{
    int[] numbers = { 10, 20, 30, 40, 50 };

    var firstThree = numbers.Take(3);

    var skipTwo = numbers.Skip(2);

    Console.WriteLine("처음 3개");
    foreach (var n in firstThree)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine("\n2개 건너뛴 후");
    foreach (var n in skipTwo)
    {
        Console.Write(n + " ");
    }
}

{
    int[] numbers = { 1, 2, 3, 4, 5 };

    bool hasAny = numbers.Any();
    bool hasEven = numbers.Any(n => n % 2 == 0);
    bool allPositive = numbers.All(n => n > 0);

    Console.WriteLine($"요소 존재: {hasAny}");
    Console.WriteLine($"짝수 존재: {hasEven}");
    Console.WriteLine($"모두 양수: {allPositive}");
}
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    bool has3 = numbers.Contains(3);
    bool has10 = numbers.Contains(10);

    Console.WriteLine($"3 포함: {has3}");
    Console.WriteLine($"10 포함: {has10}");
}

{
    int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 5 };

    var distinct = numbers.Distinct();

    foreach (var n in distinct)
    {
        Console.Write(n + " ");
    }
}

{
    int[] first = { 1, 2, 3, };
    int[] second = { 3, 4, 5 };

    var concat = first.Concat(second);
    var union = first.Union(second);

    Console.WriteLine("Concat:");
    foreach (var n in concat)
    {
        Console.WriteLine(n + " ");
    }
    Console.WriteLine("\nUnion:");
    foreach (var n in union)
    {
        Console.WriteLine(n + " ");
    }
}

{
    var numbers = new List<int> { 1, 2, 3 };
    var query = numbers.Where(n => n > 1);

    numbers.Add(4);

    Console.WriteLine("결과");
    foreach (var n in query)
    {
        Console.WriteLine(n);
    }
}

{
    var numbers = new List<int> { 1, 2, 3 };
    int count = numbers.Count();

    numbers.Add(4);

    Console.WriteLine($"개수: {count}");
}

{
    var numbers = new List<int> { 1, 2, 3 };
    var result = numbers.Where(n => n > 1).ToList();

    numbers.Add(4);

    Console.WriteLine("결과: ");
    foreach (var n in result)
    {
        Console.WriteLine(n);
    }
}

{
    var names = new List<string> { "홍길동", "김철수", "이영희" };
    var result = names.Select(n => new {Name = n, Length = n.Length});

    foreach (var item in result)
    {
        Console.WriteLine($"이름: {item.Name}, 길이: {item.Length}");
    }
}

{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
    int count = (from n in names
                 where n.Contains("a")
                 select n).Count();

    Console.WriteLine($"'a' 포함 이름 개수: {count}");
    string first = (from n in names
                    orderby n
                    select n).First();
    Console.WriteLine($"알파벳 순 첫 번째: {first}");
}