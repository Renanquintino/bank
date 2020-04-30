using Entityes.exercicio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entityes.exercicio
{
    class OutsourceEmployee:Employee
    {
        public double Additionalchange { get; set; }
        public OutsourceEmployee(string name, int hours, double valuePerHours, double additionalchange):
            base (name,hours,valuePerHours)
        {
            Additionalchange = additionalchange;
        }

        public double Payment(double additional)
        {
            additional+= ValuePerHours * Hours;
            return additional;
        }

    }
}
