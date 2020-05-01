using System;
using Entityes.exercicio;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();


            Console.Write("Enter the number of Employees:  ");
            int E = int.Parse(Console.ReadLine());
            for (int i = 1; i <= E; i++)
            {
                Console.WriteLine("Employee   #" + i);
                Console.WriteLine(" Employee is   outsurce? (y/n)");
                char A = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:  ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value Per Hours: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (A == 'y')
                {
                    Console.WriteLine("Enter the Additionalchange");
                    double additionalchange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valueHour, additionalchange));


                }
                else
                {
                    list.Add(new Employee(name, hours, valueHour));
                }
                

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENT");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "-  $" + emp.Payment());
            }

        }

    }
}








