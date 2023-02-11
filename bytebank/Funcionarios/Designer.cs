using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Designer:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }



        public Designer(string cpf, string nome) : base(cpf, nome, 3000)
        {
        }
    }
}

