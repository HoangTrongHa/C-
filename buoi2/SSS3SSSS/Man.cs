using System;

namespace buoi2.SSS3SSSS
{
    public class Man : Human,IHuman
    {
        public void add()
        {
            throw new NotImplementedException();
        }

        public void sayHello()
        {
            Console.WriteLine("Helllooo every body");
        }

        public void sayHello(string msg)
        {
            Console.WriteLine(msg);
        }

        public override void AddFriend()
        {
            throw new NotImplementedException();
        }
    }
}