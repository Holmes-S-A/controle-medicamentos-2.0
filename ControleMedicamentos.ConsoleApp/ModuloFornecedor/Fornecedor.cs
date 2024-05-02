using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class Fornecedor : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }

        public Fornecedor(string nome, string telefone, string cnpj)
        {
            Nome = nome;
            Telefone = telefone;
            Cnpj = cnpj;
        }

        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (Nome.Length < 3)
                erros[contadorErros++] = "O Nome do Fornecedor precisa conter ao menos 3 caracteres";

            if (string.IsNullOrEmpty(Telefone))
                erros[contadorErros++] = "O Telefone precisa ser preenchido";

            if (string.IsNullOrEmpty(Cnpj))
                erros[contadorErros++] = "O CNPJ precisa ser preenchido";

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }
    }
}
