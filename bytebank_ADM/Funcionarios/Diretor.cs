using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 1.10;
        }

        public override double PremioSemestral()
        {
            return this.Salario * 1.20;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public bool Autenticar(string email, string senha)
        {
            return (this.Senha == senha && this.Email == email);
        }
    }
}
