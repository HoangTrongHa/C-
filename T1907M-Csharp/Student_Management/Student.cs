using System;
using System.Collections.Generic;
using buoi2.Lab2;

namespace buoi2.Student_Management
{
    public class Student
    {
        protected int id;
        protected string name;
        protected int age;
        protected string address;
        protected int gpa;

        public Student()
        {
        }
        public Student(int id, string name, int age, string address, int gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public int Gpa
        {
            get => gpa;
            set => gpa = value;
        }

        public void showInfor()
        {
            Console.WriteLine(id+"Id"+name+"Name"+age+"Age"+gpa+"Gpa");
        }
        public abstract class StudentFunction
        {
            public abstract void addStudent(string name);
            public abstract void EditStudent(int id,string name,int age,int newid,string newName,int newAge);
            public abstract void removeStudent(int id);
            public abstract void SortGpa(int gpa);
            public abstract void SortName(string name);

        }
        public class ListStudent : StudentFunction
        {
            protected List<Student> a;

            public List<Student> A
            {
                get => a;
                set => a = value;
            }

            public override void addStudent(string name)
            {
                foreach (Student s in a)
                {
                    if (s.name.Equals(name))
                    {
                        return;
                    }
                    s.name=s.name +":"+s.age+":" + s.gpa;
                }
            }
            public override void EditStudent(int id, string name, int age, int newid, string newName, int newAge)
            {
                foreach (Student s in a)
                {
                    if (s.name.Equals(name))

                    {
                        s.id = newid;
                        s.name = newName;
                        s.age = newAge;
                    }
                }
            }
            public override void removeStudent(int id)
            {
                foreach (Student s in a)
                {
                    if (s.id.Equals(id))

                    {
                        a.RemoveAt(id);
                        return;
                    }
                }
            }

            public override void SortGpa(int gpa)
            {
                foreach (Student s in a)
                {
                    a.Sort();  
                    
                }
            }

            public override void SortName(string name)
            {
                foreach (Student s in a)
                {
                    a.Sort();
                }
            }
        }
        public static void Main(string[] args)
        {
            
        }
       
    }
}