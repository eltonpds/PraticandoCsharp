using DesignPattern.Contract;
using System;

namespace DesignPattern
{
    public class HelloWorldWriter
    {
        public void Write(IProgrammingLanguage language)
        {
            Console.WriteLine(language.WriteHelloWorld() + Environment.NewLine);
        }
    }
}
