using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Model.Income
{
    interface IIncome
    {
        double TotalIncome { get; set; }

        DateTime ExecutionDate { get; set; }
    }
}
