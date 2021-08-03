using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Model.Income
{
    class SalaryIncome : IIncome
    {
        public double TotalIncome { get; set; }
        public DateTime ExecutionDate { get; set; }

        public SalaryIncome() : this(0) { }

        public SalaryIncome(double sum)
        {
            TotalIncome = sum;
            ExecutionDate = DateTime.Now;
        }
    }
}
