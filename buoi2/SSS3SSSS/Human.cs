using System;

namespace buoi2.SSS3SSSS
{
    public abstract class Human
    {
        protected string name;
        protected int age;

        public abstract void AddFriend();

        public virtual void Running()
        {
            Console.WriteLine("avbs");
        }

        public void eat()
        {
            Console.WriteLine("an");
        }
    }
    
}