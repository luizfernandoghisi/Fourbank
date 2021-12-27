using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourBank
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public TipoCliente TipoCliente { get; set;}

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Cliente() { }

        public Cliente NovoCliente()
        {
            string nome, cpf;
            int contIf = 0;
 
            Console.Write("\n" + "Para cadastrar um cliente, digite as seguintes informações:\n");
            Console.Write("\n" + "Nome do cliente: ");
            nome = Console.ReadLine();
            Console.Write("\n" + "Digite o CPF do cliente: ");
            contIf = 0;
            do
            {
                if (contIf > 0)
                {
                    Console.Write("\n" + "CPF inválido, somente serão aceitos 11 digitos numéricos, digite o CPF sem pontos e traços: ");
                }
                cpf = Console.ReadLine();
                contIf++;
            } while (cpf.Length != 11);

            return new Cliente(nome, cpf);

        }

        public string DefineTipoCliente(decimal saldo)
        {
            int tipoCliente;
            string tCliente = "Comum";
            tipoCliente = TipoCliente.DefineTipoCliente(saldo);
            
            if(tipoCliente == 0)
            {
                tCliente = "Comum";
            } else if(tipoCliente == 1)
            {
                tCliente = "Super";
            } else if(tipoCliente == 2)
            {
                tCliente = "Premium";
            } else
            {

            }

            return tCliente;
        }

    }
}

