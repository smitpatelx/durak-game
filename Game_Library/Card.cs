/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: Card class sets up a playing card.
 */

using System;

namespace GameLibrary
{
    //ICloneable interface
    public class Card : ICloneable
    {

        //instance attributes
       public readonly Ranks rank;
       public readonly Suits suit;

        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suits trump = Suits.Club;

        public EventHandler CardClicked { get; set; }


        //default constructor
        public Card()
        {

        }

        //parameterized constructor
        public Card(Suits newSuit, Ranks newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public Suits getCardSuit()
        {
            return suit;
        }

        public Ranks getCardRank()
        {
            return rank;
        }

        //clone method for ICloneable
        public object Clone()
        {
            return MemberwiseClone();
        }

        //tostring method
        public override String ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        public String ToString(int playerNumber)
        {
            return "\nCard Drawn Player " + playerNumber + "\nThe " + rank + " of " + suit + "s";
        }

        //gethashcode method
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        //operator overloading methods
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }


        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }


        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Ranks.Ace)
                    {
                        if (card2.rank == Ranks.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Ranks.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Ranks.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Ranks.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }
    }
}
