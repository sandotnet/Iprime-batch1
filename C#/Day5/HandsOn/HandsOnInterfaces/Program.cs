namespace HandsOnInterfaces
{
    public interface IBank
    {
        //abstract methods
        void OpenAccount();
        void TransferFund();
        void ApplyLoan();
        void ApplyCreditCard();
    }
    class SBI:IBank
    {
        public void OpenAccount() { 
        //wtire code here to open the account
        }
        public void ApplyLoan()
        {

        }
        public void ApplyCreditCard()
        {

        }
        public void TransferFund()
        {

        }
    }
    class DBS:IBank
    {
        public void OpenAccount()
        {
            //wtire code here to open the account
        }
        public void ApplyLoan()
        {

        }
        public void ApplyCreditCard()
        {

        }
        public void TransferFund()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
