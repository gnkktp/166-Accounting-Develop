using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Account_166
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ac = new Account("myacc", 6000, 500);
            ac.Display();
            ac.Buy(5500);
            ac.Display();

        }
    }

    public class Account
    {
        private string accountName;
        private int credit;
        private int debit;

        public void Credit(int credit)
        {
            Console.WriteLine("Credit Limit {0} bath", credit);
        }
        public void Debit(int debit)
        {
            Console.WriteLine("Debit have {0} bath", debit);
        }
        public void Buy(int buy)
        {
            if (credit >= buy)
            {
                credit = credit - buy;
            }
            else
            {
                Console.Write("Select 1 Credit Card , 2 Debit Card : ");
                int w = Convert.ToInt32(Console.ReadLine());
                switch (w)
                {
                    case 1:
                        debit = debit - (buy - credit);
                        credit = 0;
                        break;
                    case 2:
                        Console.WriteLine("You");
                        credit = credit - (buy - debit);
                        debit = 0;
                        break;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Balance: Credit = {1,10:C} , Debit = {2,10:C}", accountName, credit, debit);
        }

        public Account(string accountName, int credit, int debit)
        {
            this.accountName = accountName;
            this.credit = credit;
            this.debit = debit;

        }


    }
}
