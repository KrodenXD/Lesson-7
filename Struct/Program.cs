using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1 program1 = new Program1();
            program1.Method();
        }
    }

    struct Program1
    {
        public int Method()
        {
            Console.WriteLine("xd");
            return 0;
        }
    }
}
