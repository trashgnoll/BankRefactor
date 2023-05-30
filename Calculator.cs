using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankRefactor.InterestCalculators;

namespace BankRefactor
{
    public static class Calculator
    {
        private static void SetAccountInterest(in Account account, IInterestCalculator interestCalculator)
        {
            account.Interest = interestCalculator.CalculateInterest( account );
        }
        // Метод для расчета процентной ставки
        public static void CalculateInterest(Account account)
        {
            if (account.Type == "Обычный")
                SetAccountInterest( account, new DefaultInterestCalculator() );
            else if (account.Type == "Зарплатный")
                SetAccountInterest( account, new SalaryInterestCalculator() );
        }
    }
}
