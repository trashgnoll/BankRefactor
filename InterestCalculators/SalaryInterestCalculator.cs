using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRefactor.InterestCalculators
{
    public class SalaryInterestCalculator: IInterestCalculator
    {
        /// <summary>
        /// Расчет процентной ставк зарплатного аккаунта по правилам банка
        /// </summary>
        public double CalculateInterest( Account account )
        {
            if (account is null)
                return 0;

            return account.Balance * 0.5;
        }
    }
}
