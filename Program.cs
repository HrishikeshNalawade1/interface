using System;

namespace staticc1
{
    class Program
    {
        int x = 100;
        static int y=200;
        public Program(int a)
        {
            this.x = a;
           
        }
        static void Main(string[] args)
        {
            
            Program c = new Program(20);
            Program cc = new Program(320);
            Console.WriteLine(c.x);
            Console.WriteLine(cc.x);
            Console.WriteLine(y);          
        }
    }
}
