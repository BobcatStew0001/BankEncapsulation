namespace BankEncapsulation;

public partial class BankAccount
{
    private double _balance;
    
    
    public double Deposit(double amount)
    {
        _balance += amount;
        return _balance;
    }
    
    public double GetBalance()
    {
        return _balance;
    }
   
    
    
}