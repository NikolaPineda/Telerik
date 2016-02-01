using System;

namespace Bank
{
    public abstract class Account
    {
        private readonly decimal interest;

        protected Account(Customer inputTipe, decimal balanceInput, decimal interestInput)
        {
            Balance = balanceInput;
            interest = interestInput;
            Customer = inputTipe;
        }

        public decimal Balance { get; protected set; }

        public decimal Interest
        {
            get { return interest; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest can not be smaller than zero!");
                }
            }
        }

        public Customer Customer { get; protected set; }

        public virtual decimal CalculateInterest(uint mounts)
        {
            return mounts*Interest;
        }

        public override string ToString()
        {
            return string.Format("This is {0} acount. It belongs to {1}.It hase a balance {2} with interest rate {3}",
                Customer.GetType().Name, Customer.Name, Balance, Interest);
        }
    }
}