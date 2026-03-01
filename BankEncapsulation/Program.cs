using System.IO.Pipes;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var zach = new BankAccount();

            var currentBalance = zach.GetBalance();
            Console.WriteLine(currentBalance);

            zach.Deposit(5000.25); 
            Console.WriteLine(zach.GetBalance());

            zach.Deposit(-2000.00); //I added this to make sure it was keeping a running tally of the balance
            Console.WriteLine(zach.GetBalance());
        }
    }
}
