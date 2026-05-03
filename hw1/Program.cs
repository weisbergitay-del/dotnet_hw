namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(1,100);
            VipAccount vac = new VipAccount(2,100);
            ac.Withdraw(200);
            vac.Withdraw(200);

        }
    }
}
