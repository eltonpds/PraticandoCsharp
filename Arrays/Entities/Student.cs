using System.Text;

namespace Arrays.Entities
{
    public class Student
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Student(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
