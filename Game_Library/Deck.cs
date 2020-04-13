/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: Class which creates the deck
 */

using System;
using System.Linq;

namespace GameLibrary
{
    //public GameDeck class
    public class Deck : ICloneable
    {
        //instance attributes
        private CardList cards = new CardList();
        private int cardsRemaining = 0;
        private Card trumpCard = new Card();

        //default constructor
        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suits)suitVal, (Ranks)rankVal));

                }
            }
        }

        //Parameterized Constructor
        public Deck(int deckSize)
        {
            int rankStartingPoint = 0;

           if (deckSize == 52)
            {
                rankStartingPoint = 1;
            }
            else if (deckSize == 36)
            {
                rankStartingPoint = 6;

                //add aces
                cards.Add(new Card((Suits)0, (Ranks)1));
                cards.Add(new Card((Suits)1, (Ranks)1));
                cards.Add(new Card((Suits)2, (Ranks)1));
                cards.Add(new Card((Suits)3, (Ranks)1));
            }

            else if (deckSize == 20)
            {
                rankStartingPoint = 10;

                //add aces
                cards.Add(new Card((Suits)0, (Ranks)1));
                cards.Add(new Card((Suits)1, (Ranks)1));
                cards.Add(new Card((Suits)2, (Ranks)1));
                cards.Add(new Card((Suits)3, (Ranks)1));
            }


            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = rankStartingPoint; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suits)suitVal, (Ranks)rankVal));

                }
            }



        }


        //Parameterized Constructor
        private Deck(CardList newCards)
        {
            cards = newCards;
        }

        //

        //Parameterized constructor
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        //  Allows a trump suit to be used.
        public Deck(bool useTrumps, Suits trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        // Parameterized constructor
        public Deck(bool isAceHigh, bool useTrumps, Suits trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        //clone method

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as CardList);
            return newDeck;
        }

        //shuffle method,
        public void Shuffle(int deckSize)
        {
            if (deckSize == 52)
            {
                CardList newDeck = new CardList();
                bool[] assigned = new bool[52];
                Random sourceGen = new Random();
                for (int i = 0; i < 52; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;
                    while (foundCard == false)
                    {
                        sourceCard = sourceGen.Next(52);
                        if (assigned[sourceCard] == false)
                            foundCard = true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
                newDeck.CopyTo(cards);
            }
            else if (deckSize == 36)
            {
                CardList newDeck = new CardList();
                bool[] assigned = new bool[36];
                Random sourceGen = new Random();
                for (int i = 0; i < 36; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;
                    while (foundCard == false)
                    {
                        sourceCard = sourceGen.Next(36);
                        if (assigned[sourceCard] == false)
                            foundCard = true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
                newDeck.CopyTo(cards);
            }
            else if (deckSize == 20)
            {
                CardList newDeck = new CardList();
                bool[] assigned = new bool[20];
                Random sourceGen = new Random();
                for (int i = 0; i < 20; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;
                    while (foundCard == false)
                    {
                        sourceCard = sourceGen.Next(20);
                        if (assigned[sourceCard] == false)
                            foundCard = true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
                newDeck.CopyTo(cards);
            }

        }

        //getter card method
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
        }


        //draw card from deck
        public Card DrawCard()
        {
            Card card;

            card = cards.First();
            cards.RemoveAt(0);
            return card;
        }


        //draw cards based on int value
        public CardList DrawCards(int numberOfCards)
        {
            CardList cardsdrawn = new CardList();

            for (int i = 0; i < numberOfCards; i++)
            {
                cardsdrawn.Add(cards.ElementAt(0));
                cards.RemoveAt(0);
            }

            return cardsdrawn;

        }

        //length of deck
        public int length()
        {
            return cards.Count();

        }

        //tostring showing the cards in deck
        public String ToString(Deck gameDeck1)
        {
            String gameDeckString = "";

            gameDeckString += "\n\nDeckCards\n";
            for (int i = 0; i < gameDeck1.length(); i++)
            {
                Card tempCard = gameDeck1.GetCard(i);
                gameDeckString += tempCard.ToString();
                if (i != 51)
                    gameDeckString += ", ";

            }

            return gameDeckString;
        }

        //fetching remaining cards in deck
        public int getCardsRemaining()
        {
            return cardsRemaining = cards.Count;
        }

        //fetching the trump card of the deck
        public Card getTrumpCard()
        {
            return trumpCard;
        }
        //setting the trump card
        public void setTrumpCard(Deck deck)
        {

            Card trumpCard;

            trumpCard = deck.DrawCard();

            this.trumpCard = trumpCard;
        }


    }
}
