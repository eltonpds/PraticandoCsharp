using DesignPattern.Contract;
using System;

namespace DesignPattern
{
    public class Go : IProgrammingLanguage
    {
        public string WriteHelloWorld()
        {
            var hello = string.Empty;

            hello += "public static void main(String args[]) {" + Environment.NewLine;
            hello += "  System.out.println(\"Hello, World!\");" + Environment.NewLine;
            hello += "}";

            return hello;
        }
    }
}
