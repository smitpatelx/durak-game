/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: Class for list of cards.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    //public cardList class
    public class CardList : List<Card>, ICloneable



    //clone method

    {
        public object Clone()
        {
            CardList newCards = new CardList();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());

            }
            return newCards;
        }


        public void CopyTo(CardList targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        //toString displays players cards 
        public String ToString(CardList cardsDrawn, int playerNumber)
        {
            String cardsDrawnString = "";

            cardsDrawnString += "\n\nDrawnCards Player " + playerNumber.ToString() + "\n";
            for (int i = 0; i < cardsDrawn.Count(); i++)
            {
                Card tempCard = cardsDrawn.GetCard(i, cardsDrawn);
                cardsDrawnString += tempCard.ToString();
                if (i != 51)
                    cardsDrawnString += ", ";

            }

            return cardsDrawnString;
        }

        //fetching a card based on number
        public Card GetCard(int cardNum, CardList cards)
        {

            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
        }


    }
}
