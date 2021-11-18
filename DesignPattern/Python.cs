using DesignPattern.Contract;

namespace DesignPattern
{
    public class Python : IProgrammingLanguage
    {
        public string WriteHelloWorld()
        {
            return "print \"Hello, World!\"";
        }
    }
}
