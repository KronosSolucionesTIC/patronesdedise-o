using Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        IBankAccount bankAccount = new BankAccountProxy("securepassword");

        // Operaciones sin autenticación
        bankAccount.Deposit(1000); // Access denied
        bankAccount.Withdraw(500); // Access denied
        bankAccount.GetBalance();  // Access denied

        // Operaciones con autenticación
        BankAccountProxy proxy = bankAccount as BankAccountProxy;
        if (proxy != null)
        {
            proxy.Deposit(1000, "securepassword"); // Deposited 1000, new balance is 1000
            proxy.Withdraw(500, "securepassword"); // Withdrew 500, new balance is 500
            Console.WriteLine($"Balance: {proxy.GetBalance("securepassword")}"); // Balance: 500
        }
    }
}

