using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicaoEntrada
{
    internal class RequisicaoEntrada : EntidadeBase
    {
        public DateTime DataRequisicao { get; set; }
        public Medicamento Medicamento { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Funcionario Funcionario { get; set; }
        public int QuantidadeAdicionada { get; set; }

        public RequisicaoEntrada(Medicamento medicamentoSelecionado, Fornecedor fornecedorSelecionado, Funcionario funcionarioSelecionado, int quantidadeAdicionadaSelecionada)
        {
            DataRequisicao = DateTime.Now;
            Medicamento = medicamentoSelecionado;
            Fornecedor = fornecedorSelecionado;
            Funcionario = funcionarioSelecionado;            
            QuantidadeAdicionada = quantidadeAdicionadaSelecionada;
        }

        public override string[] Validar()
        {
            string[] erros = new string[4];
            int contadorErros = 0;

            if (Medicamento == null)
                erros[contadorErros++] = "O medicamento precisa ser preenchido";

            if (Fornecedor == null)
                erros[contadorErros++] = "O fornecedor precisa ser informado";

            if (Funcionario == null)
                erros[contadorErros++] = "O funcionário precisa ser informado";

            if (QuantidadeAdicionada < 1)
                erros[contadorErros++] = "Por favor informe uma quantidade válida";

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }

        public void AdicionarMedicamento()
        {
            Medicamento.Quantidade += QuantidadeAdicionada;
        }
    }
}
