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
            return 0;
        }

        public override bool Equals(object obj)
        {

            if(obj != null)
            {
                if(obj.GetType() == typeof(Credit))
                {
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
            return Amount.GetHashCode();
        }

    }
}
