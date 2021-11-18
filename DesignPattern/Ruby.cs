using DesignPattern.Contract;

namespace DesignPattern
{
    public class Ruby : IProgrammingLanguage
    {
        public string WriteHelloWorld()
        {
            return "puts 'Hello, World!'";
        }
    }
}
