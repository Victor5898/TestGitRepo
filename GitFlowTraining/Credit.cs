using System;


namespace GitFlowTraining
{
    public class Credit : IComparable<Credit>
    {
        private readonly decimal amount;

        public Credit(decimal amount)
        {
            this.amount = amount;
        }

        public decimal Amount { get { return amount; } }

        public int CompareTo(Credit c)
        {
            if(c == null)
            {
                throw new ArgumentException();
            }

            if (c.Amount > Amount)
            {
                return -1;
            }
            else if (c.Amount < Amount)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(object obj)
        {

            if (obj != null)
            {
                if (obj.GetType() == typeof(Credit))
                {
                    Credit credit = (Credit)obj;

                    return (credit.Amount == Amount) ? true : false;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return 17 * Amount.GetHashCode();
        }

    }
}
