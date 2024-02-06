using System;

namespace aula_02
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            if(args.GetLength(0) > 0) {
                Console.Write(args.GetValue(0));
            }
        }
    }
}