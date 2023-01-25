using ByteBankADM.Funcionarios;
using ByteBankADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.SistemaInterno
{
    public class SistemInterno
    {
        public bool Logar(IAutenticavel usuarioAutenticavel, string login, string senha)
        {
            bool usuarioAutenticado = usuarioAutenticavel.Autenticar(login, senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema!");

                return true;
            }
            else
            {
                Console.WriteLine("Login e ou senha incorretos!");

                return false;
            }
        }
    }
}
