using System;

namespace buoi2.SSS3SSSS
{
    public class Woman : Human
    {
        public override void Running()
        {
            Console.WriteLine("Ghi de trong women");
        }

        public new void eat()
        {
            Console.WriteLine("Vua an vua hatg");
        }

        public override void AddFriend()
        {
            throw new NotImplementedException();
            
        }
    }
}