using System;

namespace buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x;
            x = 20;
            Console.WriteLine(x+15);
            Console.WriteLine(x+"Xuan huy");
            Student s1 = new Student();
            s1.showIf();
            Social.Hello();
            Console.WriteLine(Social.FirsofWeek+10);
        }
    }
}