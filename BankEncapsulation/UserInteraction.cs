namespace BankEncapsulation;

public class UserInteraction
{
    public void ATM(BankAccount account)
    {
        Console.WriteLine("Welcome! What would you like to do today?");
        Console.WriteLine("-------------------------------------");
        while (true) 
        {
            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-------------------------------------");
                
            var parsedOption = int.TryParse(Console.ReadLine(), out var selection);

            if (parsedOption == false) 
            {
                Console.WriteLine("Please select a valid number option.");
                Thread.Sleep(3000);
                Console.Clear();
                continue;
            }
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Please enter the deposit amount.");
                    var depositAmount = double.TryParse(Console.ReadLine(), out var amountDeposit);
                    if (depositAmount == false)
                    { 
                        Console.WriteLine("Please enter a valid amount.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }
                    account.Deposit(amountDeposit);
                    Console.WriteLine("Thank you for your deposit.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Please enter the withdraw amount.");
                    var withdrawAmount = double.TryParse(Console.ReadLine(), out var amountWithdraw);
                    if (withdrawAmount == false)
                    {
                        Console.WriteLine("Please enter a valid amount.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }
                    account.Withdraw(amountWithdraw);
                    Console.WriteLine("Thank you for your withdraw.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 3: 
                    Console.WriteLine($"Your current balance is: ${Math.Round(account.GetBalance(), 2)}`");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Thank you for banking with us!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Please select a valid option.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }
    }
}