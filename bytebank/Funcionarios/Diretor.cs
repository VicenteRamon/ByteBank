using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace bytebank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public override double GetBonificacao()
        {
            return this.Salario += this.Salario * 0.1;
        }

        public Diretor(string cpf, string nome) : base(cpf, nome, 5000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
