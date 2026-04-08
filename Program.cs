using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Student s = new Student();
        s.BirthDate = new DateTime(2000, 1, 1);

        s.AddGrade('A');
        s.AddGrade('B');

        s.AddAddress("123 Main St");
        s.AddAddress("456 Oak Ave");

        Console.WriteLine("Student Age: " + s.CalculateAge());
        Console.WriteLine("Student GPA: " + s.CalculateGPA());

        Console.WriteLine("Student Addresses:");
        foreach (var addr in s.GetAddresses())
        {
            Console.WriteLine(addr);
        }

        Console.WriteLine();


        Instructor i = new Instructor();
        i.BirthDate = new DateTime(1980, 1, 1);
        i.Salary = 50000;
        i.JoinDate = new DateTime(2010, 1, 1);

        i.AddAddress("789 College Rd");

        Console.WriteLine("Instructor Salary: " + i.CalculateSalary());

        Console.WriteLine("Instructor Addresses:");
        foreach (var addr in i.GetAddresses())
        {
            Console.WriteLine(addr);
        }

        Console.WriteLine();


        Ball b = new Ball(5, new Color(255, 0, 0));

        b.Throw();
        b.Throw();
        b.Pop();    
        b.Throw();  

        Console.WriteLine("Ball throws: " + b.GetThrowCount());
    }
}


class Person
{
    private DateTime birthDate;
    private decimal salary;
    private List<string> addresses = new List<string>();

    public DateTime BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public decimal Salary
    {
        get { return salary < 0 ? 0 : salary; }
        set { salary = value < 0 ? 0 : value; }
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }

    public int CalculateAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;
        if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            age--;
        return age;
    }

    public virtual decimal CalculateSalary()
    {
        return Salary;
    }
}


class Student : Person, IStudentService
{
    private List<char> grades = new List<char>();

    public void AddGrade(char grade)
    {
        grades.Add(grade);
    }

    public double CalculateGPA()
    {
        double total = 0;

        foreach (char g in grades)
        {
            if (g == 'A') total += 4;
            else if (g == 'B') total += 3;
            else if (g == 'C') total += 2;
            else if (g == 'D') total += 1;
        }

        return grades.Count == 0 ? 0 : total / grades.Count;
    }
}


class Instructor : Person, IInstructorService
{
    public DateTime JoinDate { get; set; }

    public override decimal CalculateSalary()
    {
        int years = DateTime.Now.Year - JoinDate.Year;
        return Salary + (years * 1000);
    }
}


interface IPersonService
{
    int CalculateAge();
}

interface IStudentService : IPersonService { }

interface IInstructorService : IPersonService { }


class Color
{
    private int r, g, b, a;

    public Color(int r, int g, int b, int a = 255)
    {
        this.r = r;
        this.g = g;
        this.b = b;
        this.a = a;
    }

    public int GetRed() => r;
    public int GetGreen() => g;
    public int GetBlue() => b;
    public int GetAlpha() => a;

    public void SetRed(int value) => r = value;
    public void SetGreen(int value) => g = value;
    public void SetBlue(int value) => b = value;
    public void SetAlpha(int value) => a = value;

    public int GetGrayScale()
    {
        return (r + g + b) / 3;
    }
}

class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
    }

    public void Throw()
    {
        if (size > 0)
            throwCount++;
    }

    public void Pop()
    {
        size = 0;
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}