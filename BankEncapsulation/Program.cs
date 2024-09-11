using System.Transactions;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerTransactions();
        }
        public static void CustomerTransactions()
        {
            var bankAccount1 = new BankAccount();

            string response;

            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Please type 'See Balance' or 'Make Deposit' or 'Exit'");
                response = Console.ReadLine().ToLower();
                Console.WriteLine(response);
                if (response == "see balance")
                {
                    double balance = bankAccount1.GetBalance();
                    Console.WriteLine($"Your balance is {balance}");
                }
                else if (response == "make deposit")
                {
                    Console.WriteLine("Please enter deposit amount.");
                    double _depositAmount = double.Parse(Console.ReadLine());
                    bankAccount1.Deposit(_depositAmount);
                }
                else if (response == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Did not recognize that response.");
                };
            } while (response != "see balance" || response != "make deposit");
        }
    }
}
