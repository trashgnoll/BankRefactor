using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRefactor
{
    public interface IInterestCalculator
    {
        public double CalculateInterest( Account account );
    }
}
