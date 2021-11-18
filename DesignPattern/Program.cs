using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new HelloWorldWriter().Write(new CSharp());
            new HelloWorldWriter().Write(new Go());

            Console.ReadKey();
        }
    }
}