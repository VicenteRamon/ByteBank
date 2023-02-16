using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.5;
        }



        public GerenteDeContas(string cpf, string nome) : base(cpf, nome, 4000)
        {
        }

    }
}


