using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {
        }

        public OperacaoFinanceiraException(string mensagem, Exception excecao) : base(mensagem, excecao)
        {
        }
    }
}
