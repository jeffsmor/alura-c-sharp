using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public override double GetBonus()
        {
            return this.Salario * .2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
