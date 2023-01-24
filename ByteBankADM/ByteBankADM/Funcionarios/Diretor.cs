using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }

        public override double GetBonus()
        {
            return this.Salario * .5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
