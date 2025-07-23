namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var interation = new UserInteraction();
            var accountOne = new BankAccount();
            interation.ATM(accountOne);
        }
    }
}
