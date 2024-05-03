using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class Funcionario : EntidadeBase
    {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Cpf { get; set; }

            public Funcionario(string nome, string telefone, string cpf)
            {
                Nome = nome;
                Telefone = telefone;
                Cpf = cpf;
            }

            public override string[] Validar()
            {
                string[] erros = new string[3];
                int contadorErros = 0;

                if (Nome.Length < 3)
                    erros[contadorErros++] = "O Nome do funcionário precisa conter ao menos 3 caracteres";

                if (string.IsNullOrEmpty(Telefone))
                    erros[contadorErros++] = "O Telefone precisa ser preenchido";

                if (string.IsNullOrEmpty(Cpf))
                    erros[contadorErros++] = "O CPF precisa ser preenchido";

                string[] errosFiltrados = new string[contadorErros];

                Array.Copy(erros, errosFiltrados, contadorErros);

                return errosFiltrados;
            }
        }
}
