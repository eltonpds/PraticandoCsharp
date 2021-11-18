using DesignPattern.Contract;
using System;

namespace DesignPattern
{
    public class CSharp : IProgrammingLanguage
    {
        public string WriteHelloWorld()
        {
            var hello = string.Empty;

            hello += "public static void Main()" + Environment.NewLine;
            hello += "{" + Environment.NewLine;
            hello += "  Console.WriteLine(\"Hello, World!\");" + Environment.NewLine;
            hello += "}";

            return hello;
        }
    }
}
