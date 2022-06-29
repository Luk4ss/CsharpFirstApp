using System;
using System.Collections.Generic;
using System.Globalization;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmployee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee { Id = id, Name = name, Salary = salary });
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int empId = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(emp => emp.Id == empId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            
        }
    }
}
