### Projeto de sistema interno Bytebank
O projeto foi desenvolvido durante a formação "Aprenda a programar em C# com Orientação a Objetos" visando desenvolver noções sobre programação orientada a objeto, assim como uma perspectiva prática de herança, uso de classes abstratas e interface.

>>> Status do projeto: Finalizado.

Projeto feito para representar de forma simples o gerenciamento interno de cargos no banco fícticio **Bytebank**

##O que desenvolvido no projeto:
-- Classes para cada cargo sendo elas: Auxiliar, Designer, Diretor, Funcionário, Funcionario Autenticavel e Gerente de contas.
-- Modelo de classe para parceiro comercial.
-- Um sistema de autenticação com senha para o cargo de Diretor e Gerente de contas, restringindo acesso á um futuro sistema para esses dois cargos.
-- Classes para gerenciar a bonificação de cada funcionário.

Funcionários
-------------
- Funcionario
Classe abstrata que da origem na maioria das classes de funcionários, traz a abstração das propriedades de um funcionário do Bytebank, sendo elas, **CPF, nome, salário e total de funcionários**(esta ultima em específico como classe abstrata). também traz métodos abstratos como o aumento de salário e GetBonificação (para definir a bonificação de cada funcionário); Métodos definidos como virtual para serem sobreescrevidos quando necessário sendo o Premio semestral e um método para exibir dados. Por fim também um método construtor.
- Auxiliar e Designer
Classe que herda de funcionário, mudanças apenas nos valores.
- Funcionário Autenticavel
Classe abstrata responsável pela autenticação das classes que usarem o sistema interno, sendo elas Diretor e Gerente de contas usando um método bool que recebe como parâmetro string -email e string -senha, retornando True or False com base na senha que a classe recebe como propriedade da interface IAutenticavel
        public bool Autenticar(string email, string senha)
        {
            return (this.Senha == senha && this.Email == email);
        }
- Diretor e Gerente de contas
Classe que herda de funcionário autenticavel, que por sua vez herda de funcionário, funciona como os outros cargos, com exceção do login sobreescrito no método de IAutenticavel


Parceria
-------------
- Parceiro Comercial
Simula um parceiro comercial que por sua vez tem acesso ao sistema da empresa, porém não como funcionário, apenas assina a interface IAutenticavel.


Sistema Interno
-------------
- IAutenticavel
Define a interface responsável pela autenticação, com propriedades de email e senha, como também o método abstrato Autenticar que vai ser sobreescrito nas classes que assinam essa interface, sendo diretor e gerente de contas.
- Sistema interno
Resposável pelo método Logar, recebendo como parâmetro o FuncionarioAutenticavel, string email e string senha. A variável bool usuarioAutenticado recebe o resultado do método autenticar definido no funcionarioAutenticado, junto com o email e senha do funcionarioAutenticado, retornando uma mensagem acompanhada de true or false dependendendo do booleano:
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


Utilitario
-------------
- Grenciador de bonificação e gerenciador de plano semestral
Classes para armazenar o total de bonificação registrado pelos funcionários.
