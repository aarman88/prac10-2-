using System;

// Определение интерфейса IStudent
public interface IStudent
{
    string Name { get; set; }
    string FullName { get; set; }
    int[] Grades { get; set; }

    string GetName();
    string GetFullName();
    double GetAvgGrade();
}

// Реализация интерфейса IStudent в классе Student
public class Student : IStudent
{
    public string Name { get; set; }
    public string FullName { get; set; }
    public int[] Grades { get; set; }

    public Student(string name, string fullName, int[] grades)
    {
        Name = name;
        FullName = fullName;
        Grades = grades;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetFullName()
    {
        return FullName;
    }

    public double GetAvgGrade()
    {
        if (Grades.Length == 0)
        {
            return 0.0;
        }

        int sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }

        return (double)sum / Grades.Length;
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта Student и использование методов интерфейса
        IStudent student = new Student("John", "John Smith", new int[] { 90, 85, 92, 78, 88 });
        Console.WriteLine("Name: " + student.GetName());
        Console.WriteLine("Full Name: " + student.GetFullName());
        Console.WriteLine("Average Grade: " + student.GetAvgGrade());
    }
}
