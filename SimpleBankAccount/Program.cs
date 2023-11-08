namespace SimpleBankAccount;

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
    {
        if (Balance < 0)
        {
            throw new Exception();
        }
        Balance = balance;

    }

    public  decimal Deposit(decimal amount)
    {

        if (amount < 0)
        {
            throw new Exception();
        }
        Balance += amount;

        return Balance;

    }

    public decimal Withdrawal(decimal amount)
    {
        if(amount > Balance)
        {
            throw new Exception();
        }
       return Balance -= amount;
    }

    public decimal GetBalance()
    {
        return Balance;
    }
    
}

    
class Program
{
    static void Main(string[] args)
    {
        BankAccount ban = new BankAccount(550);
        ban.Deposit(255);
        Console.WriteLine(ban.GetBalance());


    }
}