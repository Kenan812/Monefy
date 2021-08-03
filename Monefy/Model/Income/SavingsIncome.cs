using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Model.Income
{
    class SavingsIncome : IIncome
    {
        public double TotalIncome { get; set; }
        public DateTime ExecutionDate { get; set; }

        public SavingsIncome() : this(0) { }

        public SavingsIncome(double sum)
        {
            TotalIncome = sum;
            ExecutionDate = DateTime.Now;
        }
    }
}
