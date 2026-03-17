using System;
using System.Collections.Generic;
using System.Linq;

Student[] students = new Student[]
{
    new Student("김철수", "수학", 85),
    new Student("김철수", "영어", 78),
    new Student("이영희", "수학", 92),
    new Student("이영희", "영어", 88),
    new Student("박민수", "수학", 76),
    new Student("박민수", "영어", 82),
    new Student("정지은", "수학", 95),
    new Student("정지은", "영어", 91),
};


Console.WriteLine("=== 문제 1: 85점 이상 ===");
var query1 = from st in students
             where st.Score >= 85
             select st;
foreach (var st in query1)
{
    Console.WriteLine(st);
}

Console.WriteLine("\n=== 문제 1: 85점 이상 ===");
var query2 = from st in students
             where st.Subject == "수학"
             select st;
foreach (var st in query2)
{
    Console.WriteLine(st);
}

Console.WriteLine("\n=== 문제 3: 점수 내림차순 ===");
var query3 = from st in students
             orderby st.Score descending
             select st;
foreach (var st in query3)
{
    Console.WriteLine(st);
}

Console.WriteLine("\n=== 문제 4: 전체 평균 ===");
var avg = (from st in students
          select st.Score).Average();
Console.WriteLine($"{avg:F3}점");

Console.WriteLine("\n=== 문제 5: 수학 최고/최저 점수 ===");
var min = (from st in students
           where st.Subject == "수학" 
           select st.Score).Min();
var max = (from st in students
           where st.Subject == "수학"
           select st.Score).Max();
Console.WriteLine($"최고: {max}점");
Console.WriteLine($"최저: {min}점");

Console.WriteLine("\n=== 문제 6: 영어 90점 이상 존재 여부 ===");
var eng90 = (from st in students
             where st.Subject == "영어"
             where st.Score >= 90
             select st).Any();
Console.WriteLine($"{eng90}");

Console.WriteLine("\n=== 문제 7: 모두 70점 이상 여부 ===");
var all70 = (from st in students
             select st).All(st => st.Score > 70);
Console.WriteLine($"{all70}");

Console.WriteLine("\n=== 문제 8: 학생 이름 (중복 제거) ===");
var query8 = (from st in students
              select st.Name).Distinct();
foreach (var st in query8)
{
    Console.WriteLine(st);
}

Console.WriteLine("\n=== 문제 9: 수학 최고점 학생 ===");
var mathMax = students.Where(st => st.Subject == "수학").MaxBy(st => st.Score);
Console.WriteLine(mathMax.Name);

Console.WriteLine("\n=== 문제 10: 과목별 정렬 ===");
Dictionary<string, int> orders = new Dictionary<string, int>
{
    { "수학", 0 },
    { "영어", 1 }
};
var query10 = from st in students
              orderby st.Score descending
              orderby orders[st.Subject]
              select st;
foreach (var st in query10)
{
    Console.WriteLine(st);
}
