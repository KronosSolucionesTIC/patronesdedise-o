
namespace Proxy
{
    public class RealBankAccount : IBankAccount
    {
        private double _balance;

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount}, new balance is {_balance}");
        }

        public void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount}, new balance is {_balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }

}
