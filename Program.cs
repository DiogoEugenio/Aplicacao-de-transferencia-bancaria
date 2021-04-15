using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static List<conta> ListConta = new List<conta>();

        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObeterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                     case "3":
                        transferir();
                        break;
                     case "4":
                        sacar();
                        break;
                    case "5":
                        depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException() ;                                                                                 
                }
                opcaoUsuario = ObeterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nosso serviço. :D");
            Console.ReadLine();
        }
         private static void transferir()
         {
             Console.Write("Conta de Origem?: ");
             int indeceContaOrigin = int.Parse(Console.ReadLine());
             Console.Write("Conta de Destino?: ");
             int indeceContaDestino = int.Parse(Console.ReadLine());
             Console.Write("Valor de Transferência?: ");
             double valorTransferencia = double.Parse(Console.ReadLine());

            ListConta[indeceContaOrigin].transferir(valorTransferencia,  ListConta[indeceContaDestino]);

         }

        private static void sacar()
        {
            Console.Write("Digite o Número da Conta: ");
            int indeceConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Valor a ser Sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            ListConta[indeceConta].sacar(valorSaque);

        }
         private static void depositar()
         {
            Console.Write("Digite o Número da Conta: ");
            int indeceConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor a Ser Depositado: ");
            double valorDepositar = double.Parse(Console.ReadLine());

            ListConta[indeceConta].depositar(valorDepositar);
         }

        private static void InserirConta()
        {
            Console.WriteLine("Insrir nova Conta:");

            Console.WriteLine("Digite (1) Para Conta fisica ou (2) Para Conta Juridica");
            int entradatipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo  Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            conta novaConta = new conta(tipodeConta: (tipodeConta)
            entradatipoConta,
            Saldo: entradaSaldo,
            Credito: entradaCredito,
            Nome: entradaNome);

            ListConta.Add(novaConta);
            Console.Clear();
                                                       
        }
        private static void  ListarContas()
        {
            Console.WriteLine("Listar Contas");
            if(ListConta.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta cadastrada");
                return;
            }
            for(int i = 0; i <ListConta.Count; i++)
            {
                conta Conta = ListConta[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(Conta);

            }
        }

        private static string  ObeterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Digital Bank a seu dispor!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Lista de Contas");
            Console.WriteLine("2- Inserir nova Conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
