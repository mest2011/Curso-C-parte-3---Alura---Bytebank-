using System;
using Bytebank.Funcionarios;

namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria controle de total de bonificações
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //novo funcionario
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "987.654.321-94";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            //novo funcionario
            Funcionario camila = new Diretor();

            camila.Nome = "Camila";
            camila.CPF = "123.456.789-95";
            camila.Salario = 5000;

            gerenciador.Registrar(camila);

            Console.WriteLine(camila.Nome);
            Console.WriteLine(camila.GetBonificacao());
            

            //Imprime total de bonificações
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
