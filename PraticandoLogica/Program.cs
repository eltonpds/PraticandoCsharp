using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticandoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAlunos = 3;
            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 1; i <= quantidadeAlunos; i++)
            {
                Console.WriteLine($"Aluno número #{i}");
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a idade do aluno: ");
                int idade = int.Parse(Console.ReadLine());

                listaAlunos.Add(new Aluno(nome, idade));
            }

            int quantidadePessoas = QuantasPessoasMaior18Anos(listaAlunos);
            Console.WriteLine($"Quantidade de pessoas maiores que 18 anos é de: {quantidadePessoas}");

            //int mediaIdades = CalcularMediaIdade(listaAlunos);
            //Console.WriteLine($"A média de idade dos alunos é: {mediaIdades}");
        }

        private static int QuantasPessoasMaior18Anos(List<Aluno> listaAlunos)
        {
            int quantidadePessoas = 0;
            foreach(Aluno aluno in listaAlunos)
            {
                if (aluno.Idade > 18)
                    quantidadePessoas++;
            }
            return quantidadePessoas;
        }

        private static int CalcularMediaIdade(List<Aluno> listaAlunos)
        {
            int idade = 0;
            foreach (Aluno alunos in listaAlunos)
            {
                idade += alunos.Idade;
            }
            return idade / listaAlunos.Count();
        }
    }
}
