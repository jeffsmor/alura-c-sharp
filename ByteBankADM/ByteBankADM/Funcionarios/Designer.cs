using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        public override double GetBonus()
        {
            return this.Salario * .17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
