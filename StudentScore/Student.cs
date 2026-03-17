using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }

    public Student() { }
    public Student(string name, string subject, int score)
    {
        Name = name;
        Subject = subject;
        Score = score;
    }
    public override string ToString()
    {
        return $"{Name} - {Subject}: {Score}점";
    }
}