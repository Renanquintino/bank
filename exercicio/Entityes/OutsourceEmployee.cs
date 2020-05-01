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
        public override double Payment()
        {
            return base.Payment()+ Additionalchange*1.1;

        }
      

    }
}
