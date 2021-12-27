using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourBank
{
    internal class Conta
    {
        public int NumeroDaConta { get; set; }
        private decimal Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public Conta(int numeroDaConta,decimal saldo, Cliente cliente)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
            Cliente = cliente;
        }
        public Conta() {}
                
        public decimal Depositar(decimal saldo)
        {
            decimal valor;
            Console.Write("Digite o valor que deseja depositar R$:");
            valor = decimal.Parse(Console.ReadLine());
            if(valor < 0)
            {
                Console.WriteLine($"O valor digitado foi R$:{valor}, não é possivel depositar este valor");
            } else
            {
                Console.WriteLine("\n" + $"Deposito realizado com sucesso no valor de R$:{valor}");
                saldo = saldo + valor;
            }
            return saldo;
        }

        public decimal Transferir(decimal saldo)
        {
            Decimal valor;
            Console.Write("Digite o valor que deseja Transferir R$:");
            valor = decimal.Parse(Console.ReadLine());
            if (valor < 0 || saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente, não será possivel transferir o valor.");
            }
            else {
                Console.WriteLine($"Transferencia realizada com sucesso, Valor transferido R${valor}");
                saldo = saldo - valor;
            }
            return saldo;
        }

        public void ConsultarClienteSaldo(decimal saldo, Cliente cliente)
        {
            string tCliente = "comum";
            Console.Write("\n" + $"Esta conta pertence a: {cliente.Nome} - CPF: {cliente.Cpf}");
            Console.Write("\n" + "Número da conta: 000001-1");
            Console.Write("\n" + $"Seu saldo é de: R$ {saldo} \n");
            tCliente = cliente.DefineTipoCliente(saldo);
            Console.Write($"\nO cliente é do tipo {tCliente} \n");
        }
    }
}
