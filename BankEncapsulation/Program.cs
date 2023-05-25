namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jigersAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            jigersAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank You! Your balance is now {jigersAccount.GetBalance()}");

        }
    }
}
