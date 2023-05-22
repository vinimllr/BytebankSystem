using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionarioAutenticavel, string email, string senha)
        {
            bool usuarioAutenticado = funcionarioAutenticavel.Autenticar(email,senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao Sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Email ou Senha incorretos!");
                return false;
            }
        }
    }
}
