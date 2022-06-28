using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstExercise
{
    class Conta
    {
 
        public int Id { get; private set; }
        public String Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int id, String nome)
        {
            Id = id;
            Nome = nome;
        }

        public Conta(int id, String nome, double saldo): this(id, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5); 
        }

        public override string ToString()
        {
            return "Conta: " + Id + ", Titular: " + Nome + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
