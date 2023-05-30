namespace BankRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountDefault = new() { Balance = 10000 },
                    accounSalary = new() { Balance = 1000, Type = "Зарплатный" };
            
            Calculator.CalculateInterest(accountDefault);
            Console.WriteLine($"Default, balance {accountDefault.Balance} = {accountDefault.Interest}");

            accountDefault.Balance = 500;
            Calculator.CalculateInterest(accountDefault);
            Console.WriteLine($"Default, balance {accountDefault.Balance} = {accountDefault.Interest}");

            Calculator.CalculateInterest(accounSalary);
            Console.WriteLine($"Salary, balance {accounSalary.Balance} = {accounSalary.Interest}");

        }
    }
}