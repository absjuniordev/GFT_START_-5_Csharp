using System;
using Questao_02.Entities;

namespace Questao_02
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Qua o valor do recebivel");
            System.Console.WriteLine("1-Cheque\n2-Promissoria\n3-Titulo do Governo");
            int escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 1:
                    Cheque();
                    break;
                case 2:
                    Promissoria();
                    break;
                case 3:
                    TituloDoGoverno();
                    break;
                default:
                    System.Console.WriteLine("Opção invalida");
                    break;
            }

            Console.Clear();

            void Cheque()
            {
                System.Console.Write("Digite o valor do recebivel: ");
                double valor = double.Parse(Console.ReadLine());
                System.Console.Write("Digite o prazo do vencimento: ");
                int prazo = int.Parse(Console.ReadLine());

                 Cheques cheques = new Cheques();

                cheques.calcularValorRecebivel(valor, prazo);

                System.Console.WriteLine(cheques);
            }

            void Promissoria()
            {
                System.Console.Write("Digite o valor do recebivel: ");
                double valor = double.Parse(Console.ReadLine());
                System.Console.Write("Digite o prazo do vencimento: ");
                int prazo = int.Parse(Console.ReadLine());

                
               

            }

            void TituloDoGoverno()
            {
                System.Console.Write("Digite o valor do recebivel: ");
                double valor = double.Parse(Console.ReadLine());
                System.Console.Write("Digite o prazo do vencimento: ");
                int prazo = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }

  
}