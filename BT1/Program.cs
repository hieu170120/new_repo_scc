using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.LoiChao();
            Student student = new Student();
            student.HocBai();
            student.SetAge(20);
            student.Thongbaotuoi();
            Teacher teacher = new Teacher();
            teacher.Giangday();


        }
    }
}

public class Person
{
    protected int age;

    public Person()
    {
    }

    public void LoiChao()
    {
        Console.WriteLine("Xin chao");
    }

    public void SetAge(int n)
    {
        age = n;
    }
}
public class Teacher : Person
{
    public Teacher()
    {
    }
    public void Giangday()
    {
        Console.WriteLine("Oke vo tiet hoc");
    }
}
public class Student : Person
{
    public Student()
    {
    }
    public void HocBai()
    {
        Console.WriteLine("Dang hoc bai");
    }
    public void Thongbaotuoi()
    {
        Console.WriteLine("Tuoi cua hoc sinh la: " + age);
    }
}   