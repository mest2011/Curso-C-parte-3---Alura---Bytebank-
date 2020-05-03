using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
