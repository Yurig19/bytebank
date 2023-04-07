using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
       
        public GerenteDeContas(string Cpf) : base(Cpf,4000)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}
