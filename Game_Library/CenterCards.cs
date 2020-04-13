/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: Class for cards in the center while playing the game
 */

using System;
using System.Linq;

namespace GameLibrary
{
    public class CenterCards: ICloneable
    {
        //instance attributes
        CardList gameCenter = new CardList();
        private int centerCardsRemaning = 0;




        //adding the card to center
        public void CardToCenter(Card card)
        {
            gameCenter.Add(card);
            centerCardsRemaning = gameCenter.Count();
        }

        //removing the card to center
        public void CardFromCenter(Card card)
        {
            gameCenter.Remove(card);
            centerCardsRemaning = gameCenter.Count();
        }

        //shows the length of the center
        public int length()
        {
            return gameCenter.Count();

        }


        //get the card based on int value
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return gameCenter[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
        }

        //clones the center cards
        public object Clone()
        {
            CenterCards newGameCenter = new CenterCards(gameCenter.Clone() as CardList);
            return newGameCenter;
        }

        //parameriterized constructor 
        private CenterCards(CardList newGameCenter)
        {
            gameCenter = newGameCenter;
        }

        //default constructor
        public CenterCards()
        {

        }

        //clears the center
        public void ClearCenter()
        {
            gameCenter.Clear();
        }




        //comparision with the center cards
        public bool cardCenterComparison(Card trumpCard)
        {


            String defendedString = "";
            bool defended = false;

            switch(gameCenter.Count)
            {

                case 2:
                    if (gameCenter[1].suit == gameCenter[0].suit | gameCenter[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameCenter[1] > gameCenter[0] | gameCenter[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nThis Card defended: " + gameCenter[1].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nThis Card DIDNOT defend: " + gameCenter[1].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Not the same suit";
                    }
                    break;

                case 4:
                    if (gameCenter[3].suit == gameCenter[2].suit | gameCenter[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameCenter[3] > gameCenter[2] | gameCenter[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nThis Card defended: " + gameCenter[3].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nThis Card DIDNOT defend: " + gameCenter[3].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Not the same suit";
                    }
                    break;

                case 6:
                    if (gameCenter[5].suit == gameCenter[4].suit | gameCenter[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameCenter[5] > gameCenter[4] | gameCenter[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nThis Card defended: " + gameCenter[5].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nThis Card DIDNOT defend: " + gameCenter[5].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Not the same suit";
                    }
                    break;

                case 8:
                    if (gameCenter[7].suit == gameCenter[6].suit | gameCenter[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameCenter[7] > gameCenter[6] | gameCenter[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nThis Card defended: " + gameCenter[7].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nThis Card DIDNOT defend: " + gameCenter[7].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Not the same suit";
                    }
                    break;

            }

            return defended;



        }


        //displaying center cards
        public String ToString(CenterCards gameCenter1)
        {
            String gameCenterString = "";

            gameCenterString += "\n\n\tCenterCards\n\t";
            for (int i = 0; i < gameCenter1.length(); i++)
            {
                Card tempCard = gameCenter1.GetCard(i);
                gameCenterString+=tempCard.ToString();
                if (i != 51)
                    gameCenterString +=", ";

            }

            return gameCenterString;
        }

        //gets center card count
        public int getCardsRemaining()
        {
            return centerCardsRemaning = gameCenter.Count;
        }


    }
}
