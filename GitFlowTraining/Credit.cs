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
<<<<<<< HEAD
                else if(c.Amount < Amount)
=======
                else if (c.Amount < Amount)
>>>>>>> develop
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
<<<<<<< HEAD

            return 0;
=======
>>>>>>> develop
        }

        public override bool Equals(object obj)
        {

<<<<<<< HEAD
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
=======
            if (obj != null)
            {
                if (obj.GetType() == typeof(Credit))
                {
                    Credit credit = (Credit)obj;

                    return (credit.Amount == Amount) ? true : false;
>>>>>>> develop
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
<<<<<<< HEAD

            return 1024 * Amount.GetHashCode();

            return Amount.GetHashCode();
=======
            return 1024 * Amount.GetHashCode();
>>>>>>> develop
        }

    }
}
