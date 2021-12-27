using System;

namespace FourBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string tCliente = "comum";
            int opcao = 0, contP = 0;
            decimal saldo, valor;
            bool resposta = false;
            saldo = 0;
            valor = 0;
            Cliente cliente = new Cliente();
            Conta conta = new Conta();

            do
            {
                if (contP == 0)
                {
                    Console.WriteLine("Bem vindo ao 4bank, para prosseguir selecione uma opção: \n");
                }
                if (contP > 0)
                {
                    Console.WriteLine($"Bem vindo {cliente.Nome}, para prosseguir selecione uma opção: \n");
                }

                Console.WriteLine("                1. Cadastrar Novo Cliente \n");
                Console.WriteLine("                2. Depositar Dinheiro \n");
                Console.WriteLine("                3. Transferir Dinheiro \n");
                Console.WriteLine("                4. Consultar Saldo/Dados da conta \n");
                Console.Write("                5. Sair \n");
                Linha();
                Console.Write("Digite o número da opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                Linha();

                switch (opcao)
                {
                    case 1:
                        cliente = cliente.NovoCliente();
                        Linha();
                        break;

                    case 2:
                        saldo = conta.Depositar(saldo);
                        Console.Write("\n" + $"{cliente.Nome}, seu saldo é de: R$ {saldo} \n");
                        Linha();
                        break;

                    case 3:
                        saldo = conta.Transferir(saldo);
                        Console.Write($"\n{cliente.Nome}, seu saldo é de: R$ {saldo} \n");
                        Linha();
                        break;

                    case 4:
                        conta.ConsultarClienteSaldo(saldo, cliente);
                        Linha();
                        break;

                    case 5:
                        Console.Write($"\n{cliente.Nome}, agradecemos pela preferencia, até a próxima!\n");
                        resposta = true;
                        Linha();
                        break;
                }
                contP = 0;
                contP++;
            } while (resposta == false);


        }
        public static void Linha()
        {
            for (int i = 0; i < 65; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\n");
                }
                Console.Write("-");
                if (i == 64)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}

