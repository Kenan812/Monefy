using Monefy.Model.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Model.Expences
{
    class GiftsExpence : IExpence
    {
        public double TotalSum { get; set; }
        public DateTime ExecutionDate { get; set; }
        public Expence ExpenceType { get; set; }

        public GiftsExpence() : this(0) { }

        public GiftsExpence(double sum)
        {
            TotalSum = sum;
            ExecutionDate = DateTime.Now;
            ExpenceType = Expence.giftsExpence;
        }
    }
}
