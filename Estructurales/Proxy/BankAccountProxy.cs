
namespace Proxy
{
    public class BankAccountProxy : IBankAccount
    {
        private RealBankAccount _realBankAccount;
        private string _password;

        public BankAccountProxy(string password)
        {
            _realBankAccount = new RealBankAccount();
            _password = password;
        }

        private bool Authenticate(string password)
        {
            return _password == password;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine("Access denied: Unauthorized operation.");
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("Access denied: Unauthorized operation.");
        }

        public double GetBalance()
        {
            Console.WriteLine("Access denied: Unauthorized operation.");
            return 0;
        }

        public void Deposit(double amount, string password)
        {
            if (Authenticate(password))
            {
                _realBankAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Access denied: Incorrect password.");
            }
        }

        public void Withdraw(double amount, string password)
        {
            if (Authenticate(password))
            {
                _realBankAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Access denied: Incorrect password.");
            }
        }

        public double GetBalance(string password)
        {
            if (Authenticate(password))
            {
                return _realBankAccount.GetBalance();
            }
            else
            {
                Console.WriteLine("Access denied: Incorrect password.");
                return 0;
            }
        }
    }

}
