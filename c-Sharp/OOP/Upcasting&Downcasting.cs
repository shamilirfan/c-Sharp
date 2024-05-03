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
class UpcastingDowncasting
{
    public static void Main(string[] args)
    {
        // Up casting
        SavingAccount sv1 = new SavingAccount();
        sv1.interestAmount = 500;
        sv1.accountNumber = "sv-001";
        sv1.customerName = "Himal";
        sv1.Deposit(1000);
        sv1.Withdraw(500);


        // Up casting
        CheckingAccount ch1 = new CheckingAccount();
        ch1.serviceCharge = 1000;
        ch1.accountNumber = "ch-001";
        ch1.customerName = "Rupa";
        ch1.Deposit(2000);
        ch1.Withdraw(300);


        // Down casting
        BankAccount b1 = sv1;
        SavingAccount sv2 = (SavingAccount)b1;
        
        Console.WriteLine($"{sv2.interestAmount}");



    }
}