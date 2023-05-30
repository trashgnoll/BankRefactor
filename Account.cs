using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRefactor
{
    public class Account
    {
        public Account()
        {
            Type = "Обычный";
        }

        /// <summary>
        /// Тип учетной записи
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Баланс учетной записи
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double Interest { get; set; }
    }
}
