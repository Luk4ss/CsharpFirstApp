using System;
using System.Globalization;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented?: ");
            int n = int.Parse(Console.ReadLine());

            Reserva[] quarto = new Reserva[10];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent #" + (i+1) +":");
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Email: ");
                String email = Console.ReadLine();
                Console.Write("Room: ");
                int id = int.Parse(Console.ReadLine());
                quarto[id] = new Reserva {Name = name, Email = email, Room = id};
            }

            Console.WriteLine("\nBusy rooms: ");
            for(int i = 0; i < 10; i++)
            {
                   if(quarto[i] != null)
                    {
                    Console.WriteLine(quarto[i]);
                    }
            }
    
        }
    }
}
