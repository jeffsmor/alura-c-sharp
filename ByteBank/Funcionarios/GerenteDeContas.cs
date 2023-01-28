using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }

        public override double GetBonus()
        {
            return this.Salario * .25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
