using System;

namespace Bank
{
    public class ClientDeposit : Account, IDeposit, IWithDraw
    {
        public ClientDeposit(Customer inputClient, decimal inputBalance, decimal inputInterest)
            : base(inputClient, inputBalance, inputInterest)
        {
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("You can not deposit negative number!");
            }
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("You can not draw negative number!");
            }
            if (Balance > amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "The amount you are traing to withdraw is more than the money in your acount!");
            }
        }

        public override decimal CalculateInterest(uint mounts)
        {
            if (Balance <= 1000 && Balance >= 0)
            {
                return 0;
            }
            return base.CalculateInterest(mounts);
        }
    }
}