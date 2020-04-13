/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: The game ai which plays with the player.
 */

using System;

namespace GameLibrary
{
    public class DurakAI : Player
    {
        //default constructor
        public DurakAI()
        {

        }

        //parameterized constructor
        public DurakAI(String name, PlayerCard hand, bool isAttacking, bool isDefending)
        {
            setName(name);
            setHand(hand);
            setIsAttacking(isAttacking);
            setIsDefending(isDefending);
        }

        //ComputerAttacking method
        public void Attacking(CenterCards gameCenter)
        {

            Card attackingCard = new Card();

            CardList gameCenterList = new CardList();

            bool sucessfullattack = false;

            for (int i = 0; i < gameCenter.length(); i++)
            {
                gameCenterList.Add(gameCenter.GetCard(i));
            }


            switch (gameCenter.length())
            {
                case 0:
                    //AI chooses a card
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        gameCenter.CardToCenter(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        sucessfullattack = true;
                        break;
                    }
                    break;

                case 2:
                    //AI chooses a card
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank)
                        {
                            gameCenter.CardToCenter(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 4:
                    //AI chooses a card
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank | attackingCard.getCardRank() == gameCenterList[2].rank | attackingCard.getCardRank() == gameCenterList[3].rank)
                        {
                            gameCenter.CardToCenter(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 6:
                    //AI chooses a card
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank | attackingCard.getCardRank() == gameCenterList[2].rank | attackingCard.getCardRank() == gameCenterList[3].rank | attackingCard.getCardRank() == gameCenterList[4].rank | attackingCard.getCardRank() == gameCenterList[5].rank)
                        {
                            gameCenter.CardToCenter(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 8:
                    //AI chooses a card
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameCenterList[0].rank | attackingCard.getCardRank() == gameCenterList[1].rank | attackingCard.getCardRank() == gameCenterList[2].rank | attackingCard.getCardRank() == gameCenterList[3].rank | attackingCard.getCardRank() == gameCenterList[4].rank | attackingCard.getCardRank() == gameCenterList[5].rank)
                        {
                            gameCenter.CardToCenter(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;
            }


            if (sucessfullattack == false && gameCenter.length() == 0 | gameCenter.length() == 2 | gameCenter.length() == 4 | gameCenter.length() == 6 | gameCenter.length() == 8)
            {
                setIsDefending(true);
            }


        }


        //ComputerDefendingPhase method
        public void DefendingPhase(CenterCards gameCenter, Card trumpCard)
        {
                Card defendingCard = new Card();
                CardList gameCenterList = new CardList();
                bool sucessfulldefense = false;

                //int computerInput = 0;

                for (int i = 0; i < gameCenter.length(); i++)
                {
                   gameCenterList.Add(gameCenter.GetCard(i));
                }

                switch (gameCenter.length())
                {
                    case 1:
                            //AI chooses a card
                             for (int i = 0; i < getHand().length(); i++)
                            {
                                 defendingCard = getHand().ChooseCardFromHand(i);

                                 if (defendingCard.getCardSuit() == gameCenterList[0].suit & defendingCard > gameCenterList[0] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[0])
                                    {
                                gameCenter.CardToCenter(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                                 }

                        }
                    break;

                    case 3:
                        //AI chooses a card
                        for (int i = 0; i < getHand().length(); i++)
                        {
                            defendingCard = getHand().ChooseCardFromHand(i);

                            if (defendingCard.getCardSuit() == gameCenterList[2].suit & defendingCard > gameCenterList[2] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[2])
                            {
                                gameCenter.CardToCenter(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                            }

                        }
                        break;


                    case 5:
                        //AI chooses a card
                        for (int i = 0; i < getHand().length(); i++)
                        {
                            defendingCard = getHand().ChooseCardFromHand(i);

                            if (defendingCard.getCardSuit() == gameCenterList[4].suit & defendingCard > gameCenterList[4] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[4])
                            {
                                gameCenter.CardToCenter(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                            }

                        }
                        break;

                    case 7:
                        //AI chooses a card
                        for (int i = 0; i < getHand().length(); i++)
                        {
                            defendingCard = getHand().ChooseCardFromHand(i);

                            if (defendingCard.getCardSuit() == gameCenterList[6].suit & defendingCard > gameCenterList[6] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameCenterList[6])
                            {
                                gameCenter.CardToCenter(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                            }

                        }
                        break;


                }

            if (sucessfulldefense == false && gameCenter.length() == 1 | gameCenter.length() == 3 | gameCenter.length() == 5 | gameCenter.length() == 7)
            {
                setIsDefending(false);
            }


        }




        public void ChooseDefendingCard()
        {

        }









    }
}
