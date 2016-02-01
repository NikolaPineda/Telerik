using System;

namespace Bank
{
    public class Mortgare : Account, IDeposit
    {
        public Mortgare(Customer clientInput, decimal balanceX, decimal interestX)
            : base(clientInput, balanceX, interestX)
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
                if (mounts <= 6)
                {
                    mounts = 0;
                }
                else
                {
                    mounts -= 6;
                }
            }
            if (Customer is Company)
            {
                if (mounts > 12)
                {
                    mounts -= 12;
                    return base.CalculateInterest(mounts) + base.CalculateInterest(12)/2;
                }
                return base.CalculateInterest(mounts)/2;
            }
            return base.CalculateInterest(mounts);
        }
    }
}