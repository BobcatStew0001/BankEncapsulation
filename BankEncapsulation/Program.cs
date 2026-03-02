using System.IO.Pipes;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var zach = new BankAccount();

            Console.WriteLine($"Your balance is {zach.GetBalance():C}");

            
            Console.WriteLine("What is the amount you would like to deposit?");
            
            var amountToDeposit = double.Parse(Console.ReadLine());
            
            zach.Deposit(amountToDeposit);
            
            Console.WriteLine($"Your current balance is: {zach.GetBalance():C}");
        }
    }
}
