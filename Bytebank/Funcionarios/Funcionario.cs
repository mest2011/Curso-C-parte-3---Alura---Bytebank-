using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            //Console.WriteLine("Criando funcionario!");
            TotalFuncionarios++;
            //Console.WriteLine("Total de Funcionario: " + TotalFuncionarios);
            CPF = cpf;
            Salario = salario;
        }

        public Funcionario(string cpf) : this(1500, cpf) // o this no construtor indica qual construtor será executado antes
        {
            // Ahá! Nosso código está sem repetições e simplificado "Chama o Contrutor Fucionario(salario, cpf) passando os parametros"
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
