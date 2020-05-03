﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor( string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}