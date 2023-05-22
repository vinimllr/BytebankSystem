using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string email, string senha)
        {
            return (this.Senha == senha && this.Email == email);
        }
    }
}
