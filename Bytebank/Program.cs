using System;
using Bytebank.Funcionarios;
using Bytebank.Sistemas;

namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //cria controle de total de bonificações
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //novo funcionario
            Funcionario carlos = new Funcionario(2000, "987.654.321-94");
            carlos.Nome = "Carlos";
            //carlos.CPF = "987.654.321-94";
            //carlos.Salario = 2000;
            Console.WriteLine("salario: " + carlos.Salario);
            carlos.AumentarSalario();
            Console.WriteLine(carlos.Nome);
            gerenciador.Registrar(carlos);
            Console.WriteLine("salario depois do aumento: " + carlos.Salario);
            Console.WriteLine(carlos.GetBonificacao());

            //novo funcionario
            Funcionario camila = new Diretor(5000, "123.456.789-95");
            camila.Nome = "Camila";
            //camila.CPF = "123.456.789-95";
            //camila.Salario = 5000;
            Console.WriteLine(camila.Nome);
            Console.WriteLine("Salario: " + camila.Salario);
            camila.AumentarSalario();
            gerenciador.Registrar(camila);
            Console.WriteLine("Salario depois do aumento: " + camila.Salario);
            Console.WriteLine(camila.GetBonificacao());
            

            //Imprime total de bonificações
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            */

            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.123.132-54");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123456";

            sistemaInterno.Logar(parceiroComercial, "123456");
            sistemaInterno.Logar(roberta, "abc");
            sistemaInterno.Logar(roberta, "123");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048 - 39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("833.222.048-39");
            roberta.Nome = "Roberta";

            Auxiliar camila = new Auxiliar("833.222.048-39");
            camila.Nome = "Camila";

            GerenteDeConta igor = new GerenteDeConta("833.222.048-39");
            igor.Nome = "Igor";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(igor);

            Console.WriteLine("Total de Bonificação do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
