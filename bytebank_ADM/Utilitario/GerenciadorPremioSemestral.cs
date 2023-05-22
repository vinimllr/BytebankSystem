using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    internal class GerenciadorPremioSemestral
    {
        public double TotalPremioSemestral { get; private set; }
        public double Registrar(Funcionario funcionario)
        {
            return this.TotalPremioSemestral += funcionario.PremioSemestral();
        }
    }
}
