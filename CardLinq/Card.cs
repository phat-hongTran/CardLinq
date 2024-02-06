using System;

namespace CardLinq
{
    class Card : IComparable<Card>
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }

        public readonly string Name;

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(Card other)
        {
            return new CardComparerByValue().Compare(this, other);
        }

        public Card( Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;

            Name = $"{Value} of {Suit}";
        }
    }
}
