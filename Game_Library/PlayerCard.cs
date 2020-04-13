/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: This is the class which will keep the track of cards the player will have at one instance as a hand.
 */

using System;
using System.Linq;

namespace GameLibrary
{
    public class PlayerCard : ICloneable
    {


        //instance attributes
        CardList playerCard = new CardList();

        private int cardsRemaining = 0;



        //default constructor
        public PlayerCard()
        {

        }

        //parameterized constructor
        private PlayerCard(CardList newPlayerHand)
        {
            playerCard = newPlayerHand;
        }

        //clone method


        public object Clone()
        {
            PlayerCard newplayerHand = new PlayerCard(playerCard.Clone() as CardList);
            return newplayerHand;
        }

        // will add a card to the players hand
        public void CardToHand(Card card)
        {
            playerCard.Add(card);
            cardsRemaining = playerCard.Count();
        }

        //will add cards to players hand
        public void AddCardsToHand(CardList cards)
        {


            for (int i = 0; i < cards.Count(); i++)
            {
                playerCard.Add(cards[i]);
            }

            cardsRemaining = playerCard.Count();
        }





        //removecardfromhand method
        public void RemoveCardFromHand(Card card)
        {
            playerCard.Remove(card);
            cardsRemaining = playerCard.Count();
        }

        //gets hand count
        public int length()
        {
            return playerCard.Count();

        }

        //choosecardfromhand method
        public Card ChooseCardFromHand(int cardNumber)
        {
            Card card;
            card = playerCard.ElementAt(cardNumber);
            //playerHand.Remove(card);

            return card;
        }

        //choose specific card from hand
        public Card ChooseCardFromHand(Card card)
        {
            return card;

        }

        //get card based on int number
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return playerCard[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
        }


        //shows hand as a string
        public String ToString(PlayerCard playerCard1, String playerName)
        {
            String playerCardString = "";

            playerCardString += playerName.ToString() + "Cards: \n\t";
            for (int i = 0; i < playerCard1.length(); i++)
            {
                Card tempCard = playerCard1.GetCard(i);
                playerCardString += tempCard.ToString();
                if (i != 51)
                    playerCardString += ", ";

            }

            return playerCardString;
        }


        //shows hand as a string
        public String ToString(PlayerCard playerCard1, int playerNumber)
        {
            String playerCardString = "";

            playerCardString += "\n\nPlayer" + playerNumber.ToString() + "\n";
            for (int i = 0; i < playerCard1.length(); i++)
            {
                Card tempCard = playerCard1.GetCard(i);
                playerCardString += tempCard.ToString();
                if (i != 51)
                    playerCardString += ", ";

            }

            return playerCardString;
        }


    }

}
