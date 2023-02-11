using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }



        public Auxiliar(string cpf, string nome) : base(cpf, nome, 2000)
        {
        }
    }
}
