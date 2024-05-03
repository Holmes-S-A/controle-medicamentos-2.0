using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class TelaFuncionario : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ApresentarCabecalho();

                Console.WriteLine("Visualizando Funcionarios...");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                "Id", "Nome", "Telefone", "CPF"
            );

            EntidadeBase[] funcionariosCadastrados = repositorio.SelecionarTodos();

            foreach (Funcionario funcionario in funcionariosCadastrados)
            {
                if (funcionario == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                    funcionario.Id, funcionario.Nome, funcionario.Telefone, funcionario.Cpf
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do Funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone do Funcionario: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o CPF do Funcionario: ");
            string cpf = Console.ReadLine();

            Funcionario novoFuncionario = new Funcionario(nome, telefone, cpf);

            return novoFuncionario;
        }

        public void CadastrarEntidadeTeste()
        {
            Funcionario funcionario = new Funcionario("Leonardo da Silva ", "49 9999-9523", "01208964789");

            repositorio.Cadastrar(funcionario);
        }
    }
}

