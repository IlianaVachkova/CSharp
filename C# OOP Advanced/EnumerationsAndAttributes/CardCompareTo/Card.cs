using System;

namespace CardCompareTo
{
    public class Card : IComparable<Card>
    {
        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public Rank Rank { get; private set; }

        public Suit Suit { get; private set; }

        public int CalculatePower()
        {
            return (int)this.Rank + (int)this.Suit;
        }

        public int CompareTo(Card other)
        {
            if (this.CalculatePower() >= other.CalculatePower())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return this.Rank + " of " + this.Suit;
        }
    }
}
