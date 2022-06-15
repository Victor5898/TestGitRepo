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
            if (c != null)
            {
                if (c.Amount > Amount)
                {
                    return -1;
                }
                else if(c.Amount < Amount)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return 0;
        }

        public override bool Equals(object obj)
        {

            if(obj != null)
            {
                if(obj.GetType() == typeof(Credit))
                {

                    Credit credit = (Credit)obj;

                    return (credit.Amount == Amount) ? true : false;

                    Credit creditObj = obj as Credit;

                    if (this.Amount == creditObj.Amount)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public override int GetHashCode()
        {

            return 1024 * Amount.GetHashCode();

            return Amount.GetHashCode();
        }

    }
}
