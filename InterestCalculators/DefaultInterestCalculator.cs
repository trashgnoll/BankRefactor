using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRefactor.InterestCalculators
{
    public class DefaultInterestCalculator : IInterestCalculator
    {
        /// <summary>
        /// Расчет процентной ставки обычного аккаунта по правилам банка
        /// </summary>
        public double CalculateInterest( Account account )
        {
            if( account is null )
                return 0;

            double result = account.Balance * 0.4;
            if (account.Balance < 1000)
                result -= account.Balance * 0.2;
            else if (account.Balance >= 1000)
                result -= account.Balance * 0.4;
            return result;
        }
    }
}
