using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Java
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
