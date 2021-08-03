using Monefy.Model.Holders;
using System;

namespace Monefy.Model.Expences
{
    class HealthExpence : IExpence
    {
        public double TotalSum { get; set; }
        public DateTime ExecutionDate { get; set; }
        public Expence ExpenceType { get; set; }

        public HealthExpence() : this(0) { }

        public HealthExpence(double sum)
        {
            TotalSum = sum;
            ExecutionDate = DateTime.Now;
            ExpenceType = Expence.healthExpence;
        }
    }
}
