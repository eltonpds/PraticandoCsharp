using System;
using System.Collections.Generic;
using System.Globalization;

namespace PraticandoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            //2021/10/15 08:10
            Console.WriteLine("Insira a hora e o minuto em que deu entrada: ");
            TimeSpan manha = new TimeSpan(08, 00, 0);
            TimeSpan entrada = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Insira a hora e o minuto em que saiu para o almoço: ");
            TimeSpan almoco = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("");

            TimeSpan voltaAlmoco = almoco + TimeSpan.Parse("01:30") - (manha - entrada);
            TimeSpan largar = TimeSpan.Parse("17:30");
            TimeSpan jornadaDiaria = TimeSpan.FromHours(8);

            Console.WriteLine($"Você deve retornar do almoço no máximo às {voltaAlmoco} para não ficar devendo horas");
            Console.WriteLine("");

            Console.WriteLine("Insira a hora e o minuto em que voltou do almoço: ");
            TimeSpan voltaAlmoco2 = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("");


            TimeSpan horarioLargada = largar + (voltaAlmoco2 - voltaAlmoco);
            TimeSpan horasTrabalhadas = entrada + almoco - voltaAlmoco2 + largar;

            Console.WriteLine($"Você deve largar às { (horarioLargada) } para não ficar negativo no Banco de Horas");
            Console.WriteLine("");

            //Console.WriteLine("Informe o horário em que pretende bater o ponto");
            //largar = DateTime.Parse(Console.ReadLine());
            //jornadaDiaria = (largar - voltaAlmoco) + (almoco - manha);

            //if (jornadaDiaria.Hours > 8)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine($"Você está fazendo { jornadaDiaria.Minutes } minutos extras");
            //    Console.WriteLine("");
            //}
            //else
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine($"Minutos restantes para bater o ponto: { jornadaDiaria.Minutes }");
            //}



        }
        //int numero, limite;
        //Console.WriteLine("Digita um número");
        //numero = int.Parse(Console.ReadLine());

        //Console.WriteLine("");
        //Console.WriteLine("Digite o valor do limite");
        //limite = int.Parse(Console.ReadLine());

        //while(numero <= limite)
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine("Contagem atual: {0}", numero);
        //    numero++;
        //}

        // Console.WriteLine("Entre os dados do produto:");
        // Console.Write("Nome: ");
        // string nome = Console.ReadLine();

        // Console.Write("Preço: ");
        // double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // Console.Write("Quantidade no estoque: ");
        // int qte = int.Parse(Console.ReadLine());
        // Console.WriteLine();

        //Produto p = new Produto(nome, preco, qte);

        // Console.WriteLine("Dados do produto: " + p);
        // Console.WriteLine();
        // Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        // qte = int.Parse(Console.ReadLine());

        // p.AdicionarProdutos(qte);
        // Console.WriteLine();
        // Console.WriteLine("Dados atualizados: " + p);
        // Console.WriteLine();
        // Console.Write("Digite o número de produtos a ser removido do estoque: ");

        // qte = int.Parse(Console.ReadLine());
        // p.RemoverProdutos(qte);
        // Console.WriteLine();
        // Console.WriteLine("Dados atualizados: " + p);

        // List<Produto> produtos = new List<Produto>();
        // produtos.Add(p);

        // Console.WriteLine("------------------------------------------------------");
        // Console.WriteLine("----------------------- MENU -------------------------");
        // Console.WriteLine("------------------------------------------------------");
        // Console.WriteLine("- Escola ---------------------------------------------");
        // Console.WriteLine("- Para Inserir um novo produto digite 1 --------------");
        // Console.WriteLine("- Para mudar a quantidade de um produto digite 2 -----");
        // Console.WriteLine("- Para remover um produto digite 3 -------------------");
        // Console.WriteLine("------------------------------------------------------");

        // int opcao = int.Parse(Console.ReadLine());

        // switch (opcao)
        // {
        //     case 1:
        //         Console.WriteLine("");
        //         Console.WriteLine("INSERIR UM NOVO PRODUTO");
        //         Console.WriteLine("");
        //         Console.WriteLine("Entre os dados do produto:");
        //         Console.Write("Nome: ");
        //         nome = Console.ReadLine();

        //         Console.Write("Preço: ");
        //         preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //         Console.Write("Quantidade no estoque: ");
        //         qte = int.Parse(Console.ReadLine());
        //         Console.WriteLine();

        //         Produto novoP = new Produto(nome, preco, qte);
        //         produtos.Add(novoP);
        //         break;

        //     case 2:
        //         Console.WriteLine("");
        //         Console.WriteLine("Para aumentar digite 1, para diminuir digite 2");
        //         int escolha = int.Parse(Console.ReadLine());

        //         string prod;
        //         switch (escolha)
        //         {
        //             case 1:
        //                 Console.WriteLine("Qual produto você gostaria de aumentar?");
        //                 foreach(var item in produtos)
        //                 {
        //                     Console.WriteLine(item);
        //                 }

        //                 prod = Console.ReadLine();
        //                 produtos.;

        //                 Console.WriteLine("Digite a quantidade que gostaria de adicionar");
        //                 int aumento = int.Parse(Console.ReadLine());
        //                 break;

        //             case 2:
        //                 break;
        //         }
        //         break;
        //}



    }
}
