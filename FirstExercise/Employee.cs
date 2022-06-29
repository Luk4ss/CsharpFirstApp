using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstExercise
{
    class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary *= (1 + percentage / 100); 
            
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
