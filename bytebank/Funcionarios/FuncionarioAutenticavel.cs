using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, string nome, double salario) : base(cpf, nome, salario)
        {
        }

        public string Senha { get; set; }
        
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
