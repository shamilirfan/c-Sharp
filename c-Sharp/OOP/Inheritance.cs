using System;

class BankAccount
{
    public string accountNumber { get; set; }
    public string customerName { get; set; }
    public double balance { get; private set; }
    public string Deposit(double amount)
    {
        balance += amount;
        return "Deposited";
    }
    public string Withdraw(double amount)
    {
        balance -= amount;
        return "Withdrawn";
    }
}
class SavingAccount : BankAccount
{
    public double interestAmount { get; set; }

}
class CheckingAccount : BankAccount
{
    public double serviceCharge { get; set; }

}
class Inheritance
{
    public static void Main(string[] args)
    {
        SavingAccount sv1 = new SavingAccount();
        sv1.interestAmount = 500;
        sv1.accountNumber = "sv-001";
        sv1.customerName = "Himal";
        sv1.Deposit(1000);
        sv1.Withdraw(500);
        Console.WriteLine($"{sv1.balance}");
        

        CheckingAccount ch1 = new CheckingAccount();
        ch1.serviceCharge = 1000;
        ch1.accountNumber = "ch-001";
        ch1.customerName = "Rupa";
        ch1.Deposit(2000);
        ch1.Withdraw(300);
        Console.WriteLine($"{ch1.balance}");
        

    }
}
