/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: standard functionality for a player
 */

using System;

namespace GameLibrary
{
    public class Player
    {
        //instance attributes
        private String name = "";
        private PlayerCard hand = new PlayerCard();
        private bool isAttacking = false;
        private bool isDefending = false;


        //class attributes
        public const String DEFAULT_NAME = "John Doe";
        public const PlayerCard DEFAULT_PLAYERHAND = null;
        public const bool DEFAULT_ISATTACKING = false;
        public const bool DEFAULT_ISDEFENDING = false;


        //default constructor
        public Player()
        {
            setName(DEFAULT_NAME);
            setHand(DEFAULT_PLAYERHAND);
            setIsAttacking(DEFAULT_ISATTACKING);
            setIsDefending(DEFAULT_ISDEFENDING);
        }

        //parameterized constructor(PlayerHand hand, bool isAttacking, bool is defending)
        public Player(String name, PlayerCard hand, bool isAttacking, bool isDefending)
        {
            setName(name);
            setHand(hand);
            setIsAttacking(isAttacking);
            setIsDefending(isDefending);
        }


        //Attacking phase for human players
        public virtual void Attacking(CenterCards gameCenter, Card attackingCard)
        {

            CardList gameCenterList = new CardList();


            for (int i = 0; i < gameCenter.length(); i++)
            {
                gameCenterList.Add(gameCenter.GetCard(i));
            }



            switch (gameCenter.length())
            {
                case 0:


                    gameCenter.CardToCenter(attackingCard);
                    getHand().RemoveCardFromHand(attackingCard);

                    break;

                case 2:
                    if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank)
                    {
                        gameCenter.CardToCenter(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);

                        break;
                    }
                    break;

                case 4:
                    if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank | attackingCard.getCardRank() == gameCenterList[2].rank | attackingCard.getCardRank() == gameCenterList[3].rank)
                    {
                        gameCenter.CardToCenter(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        break;
                    }
                    break;

                case 6:
                    if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank | attackingCard.getCardRank() == gameCenterList[2].rank | attackingCard.getCardRank() == gameCenterList[3].rank | attackingCard.getCardRank() == gameCenterList[4].rank | attackingCard.getCardRank() == gameCenterList[5].rank)
                    {
                        gameCenter.CardToCenter(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        break;
                    }
                    break;

                case 8:
                    if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank | attackingCard.getCardRank() == gameCenterList[2].rank | attackingCard.getCardRank() == gameCenterList[3].rank | attackingCard.getCardRank() == gameCenterList[4].rank | attackingCard.getCardRank() == gameCenterList[5].rank)
                    {
                        gameCenter.CardToCenter(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        break;
                    }
                    break;
            }



        }

        //Defending phase for human players
        public virtual void DefendingPhase(CenterCards gameCenter, Card trumpCard, Card defendingCard)
        {
            //Card defendingCard = new Card();
            CardList gameCenterList = new CardList();
            bool sucessfulldefense = false;


           



            for (int i = 0; i < gameCenter.length(); i++)
            {
                gameCenterList.Add(gameCenter.GetCard(i));
            }



            switch (gameCenter.length())
            {
                case 1:


                    if (defendingCard.getCardSuit() == gameCenterList[0].suit & defendingCard > gameCenterList[0] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[0])
                    {
                        gameCenter.CardToCenter(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;

                case 3:


                    if (defendingCard.getCardSuit() == gameCenterList[2].suit & defendingCard > gameCenterList[2] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[2])
                    {
                        gameCenter.CardToCenter(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;


                case 5:


                    if (defendingCard.getCardSuit() == gameCenterList[4].suit & defendingCard > gameCenterList[4] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[4])
                    {
                        gameCenter.CardToCenter(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;

                case 7:


                    if (defendingCard.getCardSuit() == gameCenterList[6].suit & defendingCard > gameCenterList[6] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[6])
                    {
                        gameCenter.CardToCenter(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;


            }





        }





            //to string player info outputs as a string player information
            public String ToStringPlayerInfo()
            {
                String playerInfoString = "";

                playerInfoString += "\n" + getName() + " " + getHand().ToString(getHand(), getName()) +
                    "\nAttacking: " + getIsAttacking() + "\nDefending: " + getIsDefending();

                return playerInfoString;


            }


            //will refill player hand
            public void RefillHand(Deck deck)
            {

                CardList cards = deck.DrawCards(6 - hand.length());
                hand.AddCardsToHand(cards);

            }




            //getters and setters
            public String getName()
            {
                return name;
            }

            public void setName(String name)
            {
                this.name = name;
            }

            public PlayerCard getHand()
            {
                return hand;
            }

            public void setHand(PlayerCard hand)
            {
                this.hand = hand;
            }

            public bool getIsAttacking()
            {
                return isAttacking;
            }

            public void setIsAttacking(bool isAttacking)
            {
                this.isAttacking = isAttacking;
            }

            public bool getIsDefending()
            {
                return isDefending;
            }

            public void setIsDefending(bool isDefending)
            {
                this.isDefending = isDefending;
            }

        }


}
