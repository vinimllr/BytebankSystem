using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome;
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

        public virtual double PremioSemestral()
        {
            return this.Salario * 0.20;
        }
        public virtual void ExibirDados()
        {
            Console.WriteLine(this.Nome);
            Console.WriteLine(this.Cpf);
            Console.WriteLine("Salario: " + this.Salario);
            Console.WriteLine("Bonificação: " + GetBonificacao());
            Console.WriteLine("Premio Semestral " + PremioSemestral());
        }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;

        }
    }
}
