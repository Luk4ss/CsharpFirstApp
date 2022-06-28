using System;
using System.Globalization;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int id = int.Parse(Console.ReadLine());
         
            Console.Write("Entre com o titular da conta: ");
            String nome = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial(s/n)?  ");
            char opt = char.Parse(Console.ReadLine());

            Conta c1 = new Conta(id, nome);

            if(opt == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(id, nome, deposito);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(c1);

            
            Console.Write("\nEntre com o valor para depósito: ");
            c1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(c1);

            Console.Write("\nEntre com o valor para saque: ");
            c1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(c1);




        }
    }
}
