using Monefy.Model.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Model.Expences
{
    public interface IExpence
    {
        double TotalSum{ get; set; }

        Expence ExpenceType { get; set; }

        DateTime ExecutionDate { get; set; }
    }
}
