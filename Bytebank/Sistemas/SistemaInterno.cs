using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel autenticavel, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }
    }
}
