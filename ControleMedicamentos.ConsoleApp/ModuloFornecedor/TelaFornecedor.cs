using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ApresentarCabecalho();

                Console.WriteLine("Visualizando Fornecedores...");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                "Id", "Nome do Fornecedor", "Telefone", "CNPJ"
            );

            EntidadeBase[] fornecedoresCadastrados = repositorio.SelecionarTodos();

            foreach (Fornecedor fornecedor in fornecedoresCadastrados)
            {
                if (fornecedor == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                    fornecedor.Id, fornecedor.Nome, fornecedor.Telefone, fornecedor.Cnpj
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do fornecedor: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone do fornecedor: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o CNPJ do fornecedor: ");
            string cnpj = Console.ReadLine();

            Fornecedor novoFornecedor = new Fornecedor(nome, telefone, cnpj);

            return novoFornecedor;
        }

        public void CadastrarEntidadeTeste()
        {
            Fornecedor fornecedor = new Fornecedor("BioLab Farmacêutica", "49 9916 - 5628", "34.739.108/0001-20");

            repositorio.Cadastrar(fornecedor);
        }
    }
}
