using bytebank.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario 
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }


        public abstract double GetBonificacao();

        public Funcionario(string cpf, string nome, double salario)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }



    }
}
