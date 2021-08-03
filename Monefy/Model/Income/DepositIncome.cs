using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Model.Income
{
    class DepositIncome : IIncome
    {
        public double TotalIncome { get; set; }
        public DateTime ExecutionDate { get; set; }

        public DepositIncome() : this(0) { }

        public DepositIncome(double sum)
        {
            TotalIncome = sum;
            ExecutionDate = DateTime.Now;
        }
    }
}
