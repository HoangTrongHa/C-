using System;

namespace buoi2.Ass5
{
    public class Program{
        public static void Main(string[] args)
        {
            phoneBook p = new phoneBook();
            p.insertPhone("Hoang Ha","21321312");   p.insertPhone("hung","0984684184");
            p.insertPhone("ngoc","4124123");
            p.removePhone("hung"); // hung delete
            p.updatePhone("ngoc","213213");
            p.insertPhone("thang","42131231");
            Console.WriteLine("Thong tin search phone");
            p.searchPhone("Hoan Ha");
            p.show();
        }
    }
}