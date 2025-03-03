using System;
using System.Linq;

class Student
{
    private string name;
    private int age;
    private int grade;

    public Student(string name, int age, int grade)
    {
        this.name = name;
        this.age = age;
        SetGrade(grade);
    }

    public void SetGrade(int value)
    {
        if (value >= 1 && value <= 5)
        {
            grade = value;
        }
        else
        {
            Console.WriteLine("Оценка должна быть в диапазоне от 1 до 5.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Успеваемость: {grade}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Анвар", 19, 4);
        Student student2 = new Student("Артём", 17, 5);
        Student student3 = new Student("Самир", 17, 3);

        student1.DisplayInfo();
        student2.DisplayInfo();
        student3.DisplayInfo();

        student1.SetGrade(6);
        student1.SetGrade(3);
        student1.DisplayInfo();
    }
}