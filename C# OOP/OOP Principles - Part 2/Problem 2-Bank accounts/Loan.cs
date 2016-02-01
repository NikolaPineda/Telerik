using System;

namespace Bank
{
    public class Loan : Account, IDeposit
    {
        public Loan(Customer inputClient, decimal inputBalance, decimal inputInterest)
            : base(inputClient, inputBalance, inputInterest)
        {
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("You can not deposit negative sum!");
            }
        }

        public override decimal CalculateInterest(uint mounts)
        {
            if (Customer is Indivitual)
            {
                if (mounts > 3)
                {
                    mounts = mounts - 3;
                }
                else
                {
                    mounts = 0;
                }
            }
            if (Customer is Company)
            {
                if (mounts > 2)
                {
                    mounts -= 2;
                }
                else
                {
                    mounts = 0;
                }
            }
            return base.CalculateInterest(mounts);
        }
    }
}