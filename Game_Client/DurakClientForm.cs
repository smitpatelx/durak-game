/*
 Authors: Ryan Ramkalawan, Joseph Maxim, Tyler Nankishore, David Bond
 Creation Date: 2017/02/21
 Revision Date: 2017/02/21
 Description: GameClientForm, controls all form funcationality
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;


namespace GameClient
{
    public partial class GameClientForm : Form
    {
        private static string userName;
        //initialize components of the form
        public GameClientForm()
        {
            userName = UserNamePrompt();
            myPlayerOne.setName(userName);
            InitializeComponent();
        }

        //declares all variables
        #region  Declaration of Variables and Game Reset
        Deck myDeck = new Deck();
        CenterCards myRiver = new CenterCards();
        static PlayerCard myHandOne = new PlayerCard();
        static PlayerCard myHandTwo = new PlayerCard();
        Player myPlayerOne = new Player(userName, myHandOne, true, false);
        //Player myPlayerTwo = new Player("PlayerTwo", myHandTwo, false, true);
        DurakAI myPlayerTwo = new DurakAI("PlayerTwo", myHandTwo, false, true);
        CardList DeckDisplayList = new CardList();
        CardList HandOneDisplayList = new CardList();
        CardList HandTwoDisplayList = new CardList();
        CardList PlayerOneDisplayList = new CardList();
        CardList PlayerTwoDisplayList = new CardList();
        CardList RiverDisplayList = new CardList();
        CardList trumpCardDisplayList = new CardList();
        CardList discardDisplayList = new CardList();
        GameLog GameLog = new GameLog();

        int deckSize = 52;
        int roundNumber = 0;
        int playerOneWins = 0;
        int playerOneLosses = 0;
        int playerTwoWins = 0;
        int playerTwoLosses = 0;


        //resets game
        public void ResetGame()
        {
            lbl_human_attacking.Visible = true;
            lbl_computer_attacking.Visible = false;
            lbl_human_player.Text = myPlayerOne.getName().ToString();
            lbl_computer_player.Text = myPlayerTwo.getName().ToString();
            flp_deck.Controls.Clear();
            flp_computers_hand.Controls.Clear();
            flp_player_hand.Controls.Clear();
            flp_river_hand.Controls.Clear();
            flp_trump_card.Controls.Clear();
            flp_discard_pile.Controls.Clear();
            CardImageControl startingCardControl = new CardImageControl();
           flp_deck.Controls.Add(startingCardControl);
            myDeck = new Deck(deckSize);
            myRiver = new CenterCards();
            myHandOne = new PlayerCard();
            myHandTwo = new PlayerCard();
            myPlayerOne = new Player(userName, myHandOne, true, false);
            myPlayerTwo = new DurakAI("PlayerTwo", myHandTwo, false, true);
            DeckDisplayList = new CardList();
            HandOneDisplayList = new CardList();
            HandTwoDisplayList = new CardList();
            PlayerOneDisplayList = new CardList();
            PlayerTwoDisplayList = new CardList();
            RiverDisplayList = new CardList();
            trumpCardDisplayList = new CardList();
            discardDisplayList = new CardList();
            myDeck.Shuffle(deckSize);

            txt_deck_cards_remaining.Text = myDeck.getCardsRemaining().ToString();
            txt_river_cards_remaning.Text = myRiver.getCardsRemaining().ToString();
            txt_dicard_cards_remaining.Text = discardDisplayList.Count().ToString();
            txtRoundNumber.Text = roundNumber.ToString();

            btn_pick_up.Enabled = false;
            btn_cease_attack.Enabled = true;

            roundNumber = 0;
            DateTime localDate = DateTime.Now;
            GameLog.Log("\nNEW GAME - " + localDate.ToString() + " " + localDate.Kind);
            GameLog.Log("\n " + userName.ToUpper() + " Win/Loss Ratio " + playerOneWins.ToString() + "/" + playerOneLosses.ToString());
            GameLog.Log("\n PlayerTwo Win/Loss Ratio " + playerTwoWins.ToString() + "/" + playerTwoLosses.ToString() + "\n");
        }
        #endregion

        //on form load reset game
        private void GameClientForm_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        //starts a new game
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            myDeck.setTrumpCard(myDeck);
            myPlayerOne.RefillHand(myDeck);
            myPlayerTwo.RefillHand(myDeck);

            DisplayAllCardLists();


            //AttackDefendPhase();

        }


        public void AttackDefendPhase()
        {
            //int userInput = 1;
            //Attacking/defendingPhase
            //myPlayerOne.AttackingPhase(myRiver, userInput);

            //myPlayerTwo.DefendingPhase(myRiver);

            DisplayAllCardLists();

        }



         //on card click will raise event in card image control class
         //clicked card will go through player attack/defend phase method
        private void Card_Click(object sender, EventArgs e)
        {
            CardImageControl clickedCardControl = new CardImageControl();

            clickedCardControl = (CardImageControl)sender;

            //if (myPlayerTwo.getIsDefending() == false)
            //{
            //    myPlayerOne.setIsDefending(true);
            //}
            //else if (myPlayerTwo.getIsDefending() == true)
            //{
            //    myPlayerOne.setIsDefending(false);
            //}

            //checks to see if computer is defending if so human player attack phas starts and computer
            //defend phase begins
            if (myPlayerTwo.getIsDefending() == true)
            {
                myPlayerOne.Attacking(myRiver, (clickedCardControl.Card));

                myPlayerTwo.DefendingPhase(myRiver, myDeck.getTrumpCard());


                //checks to see if computer is defending if not will log round in output file
                //will reset round and have human start defending
                if (myPlayerTwo.getIsDefending() == false)
                {
                    roundNumber +=  1;

                    GameLog.LogRound(GameLog, roundNumber, myPlayerOne, myPlayerTwo, myRiver);


                    for (int i = 0; i < myRiver.length(); i++)
                    {
                        myHandTwo.CardToHand(myRiver.GetCard(i));
                    }
                    myRiver.ClearCenter();
                    lbl_computer_attacking.Visible = true;
                    lbl_human_attacking.Visible = false;
                    try
                    {
                        myPlayerOne.RefillHand(myDeck);
                        myPlayerTwo.RefillHand(myDeck);
                    }
                    catch (Exception)
                    {

                    }

                    btn_pick_up.Enabled = true;
                    btn_cease_attack.Enabled = false;

                    myPlayerTwo.Attacking(myRiver);
                }
            }

            //human is defending, from computer attacks
            else
            {


                myPlayerOne.DefendingPhase(myRiver, myDeck.getTrumpCard(), (clickedCardControl.Card));
                myPlayerTwo.Attacking(myRiver);

                //if human no longer defending, round over and reset, computer is now defending
                if (myPlayerTwo.getIsDefending() == true)
                {
                    roundNumber += 1;

                    GameLog.LogRound(GameLog, roundNumber, myPlayerOne, myPlayerTwo, myRiver);

                    for (int i = 0; i < myRiver.length(); i++)
                    {
                        discardDisplayList.Add(myRiver.GetCard(i));
                    }
                    myRiver.ClearCenter();
                    lbl_computer_attacking.Visible = false;
                    lbl_human_attacking.Visible = true;
                    try
                    {
                        myPlayerOne.RefillHand(myDeck);
                        myPlayerTwo.RefillHand(myDeck);
                    }
                    catch (Exception)
                    {

                    }
                    btn_pick_up.Enabled = false;
                    btn_cease_attack.Enabled = true;
                }

            }



            DisplayAllCardLists();

            //logs who won the game and win/loss ratios
            if (myPlayerOne.getHand().length() == 0)
            {
                playerOneWins += 1;
                playerTwoLosses += 1;
                MessageBox.Show("GAME OVER: PLAYER ONE HAS WON");
                GameLog.Log("\n*****GAME OVER: PLAYER ONE HAS WON***** \n");
                GameLog.Log("\n "+userName.ToUpper()+" Win/Loss Ratio " + playerOneWins.ToString() + "/" + playerOneLosses.ToString());
                GameLog.Log("\n PlayerTwo Win/Loss Ratio " + playerTwoWins.ToString() + "/" + playerTwoLosses.ToString() + "\n");
                ResetGame();
            }

            if (myPlayerTwo.getHand().length() == 0)
            {
                playerTwoWins += 1;
                playerOneLosses += 1;
                MessageBox.Show("GAME OVER: PLAYER TWO HAS WON");
                GameLog.Log("\n*****GAME OVER: PLAYER TWO HAS WON***** \n");
                GameLog.Log("\n "+userName.ToUpper()+" Win/Loss Ratio " + playerOneWins.ToString() + "/" + playerOneLosses.ToString());
                GameLog.Log("\n PlayerTwo Win/Loss Ratio " + playerTwoWins.ToString() + "/" + playerTwoLosses.ToString() + "\n");
                ResetGame();
            }





        }


        //will display all card lists on the windows form
        public void DisplayAllCardLists()
        {
            DisplayPlayerOneCards();
            DisplayPlayerTwoCards();
            DisplayRiverCards();

            txt_deck_cards_remaining.Text = myDeck.getCardsRemaining().ToString();
            txt_river_cards_remaning.Text = myRiver.getCardsRemaining().ToString();
            txt_dicard_cards_remaining.Text = discardDisplayList.Count().ToString();
            txtRoundNumber.Text = roundNumber.ToString();

            DisplayTrumpCards();
            DisplayDiscardCards();
        }

        //displays discard cards
        public void DisplayDiscardCards()
        {
            if (discardDisplayList.Count() > 0)
            {
                CardImageControl startingCardControl = new CardImageControl();
                flp_discard_pile.Controls.Add(startingCardControl);
            }
        }

        //displays trump card
        public void DisplayTrumpCards()
        {
            flp_trump_card.Controls.Clear();
            trumpCardDisplayList.Clear();

            for (int i = 0; i < 1; i++)
            {
                trumpCardDisplayList.Add(myDeck.getTrumpCard());
            }
            foreach (Card card in trumpCardDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flp_trump_card.Controls.Add(myCardControl);

            }
        }

        //displays player one cards
        public void DisplayPlayerOneCards()
        {
            //PlayerOne Display Cards

            flp_player_hand.Controls.Clear();
            PlayerOneDisplayList.Clear();

            for (int i = 0; i < myPlayerOne.getHand().length(); i++)
            {
                PlayerOneDisplayList.Add(myPlayerOne.getHand().GetCard(i));
            }
            foreach (Card card in PlayerOneDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flp_player_hand.Controls.Add(myCardControl);

               //stores a card click event method for each card
               myCardControl.CardClicked += new EventHandler(Card_Click);
            }
        }

        //displays player two cards
        public void DisplayPlayerTwoCards()
        {
            //PlayerTwo Display Cards

            flp_computers_hand.Controls.Clear();
            PlayerTwoDisplayList.Clear();

            for (int i = 0; i < myPlayerTwo.getHand().length(); i++)
            {
                PlayerTwoDisplayList.Add(myPlayerTwo.getHand().GetCard(i));
            }
            foreach (Card card in PlayerTwoDisplayList)
            {
                //CardImageControl myCardControl = new CardImageControl();
                //myCardControl.Card = card;
                //flpComputerHand.Controls.Add(myCardControl);

                //myCardControl.CardClicked += new EventHandler(Card_Click);

                CardImageControl startingCardControl = new CardImageControl();
                flp_computers_hand.Controls.Add(startingCardControl);

            }
        }

        //displays river cards
        public void DisplayRiverCards()
        {
            //River Display Cards

            flp_river_hand.Controls.Clear();
            RiverDisplayList.Clear();

            for (int i = 0; i < myRiver.length(); i++)
            {
                RiverDisplayList.Add(myRiver.GetCard(i));
            }
            foreach (Card card in RiverDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flp_river_hand.Controls.Add(myCardControl);
            }
        }

        //button pickup clicked ends human turn and picks up cards
        private void btnPickUp_Click(object sender, EventArgs e)
        {
            roundNumber += 1;

            GameLog.LogRound(GameLog, roundNumber, myPlayerOne, myPlayerTwo, myRiver);

            for (int i = 0; i < myRiver.length(); i++)
            {
                myHandOne.CardToHand(myRiver.GetCard(i));
            }
            myRiver.ClearCenter();
            try
            {


                myPlayerOne.RefillHand(myDeck);
                myPlayerTwo.RefillHand(myDeck);
            }
            catch (Exception)
            {

            }
            //myPlayerOne.setIsAttacking(true);
            //myPlayerOne.setIsDefending(false);
            //myPlayerTwo.setIsAttacking(false);
            myPlayerTwo.setIsDefending(true);


            lbl_computer_attacking.Visible = false;
            lbl_human_attacking.Visible = true;

            btn_pick_up.Enabled = false;
            btn_cease_attack.Enabled = true;

            DisplayAllCardLists();


        }

        //cease attack button ends human turn and computer starts attacking
        private void btnCeaseAttack_Click(object sender, EventArgs e)
        {
            roundNumber += 1;

            GameLog.LogRound(GameLog, roundNumber, myPlayerOne, myPlayerTwo, myRiver);

            for (int i = 0; i < myRiver.length(); i++)
            {
                discardDisplayList.Add(myRiver.GetCard(i));
            }
            myRiver.ClearCenter();
            try
            {
                myPlayerOne.RefillHand(myDeck);
                myPlayerTwo.RefillHand(myDeck);
            }
            catch (Exception)
            {

            }
            //myPlayerOne.setIsAttacking(false);
            //myPlayerOne.setIsDefending(true);
            //myPlayerTwo.setIsAttacking(true);
            myPlayerTwo.setIsDefending(false);

            lbl_computer_attacking.Visible = true;
            lbl_human_attacking.Visible = false;

            btn_pick_up.Enabled = true;
            btn_cease_attack.Enabled = false;

            myPlayerTwo.Attacking(myRiver);

            DisplayAllCardLists();

        }

        //52 deck
        private void btn52Deck_Click(object sender, EventArgs e)
        {
            deckSize = 52;
            myDeck = new Deck(deckSize);
            ResetGame();
        }
        //36 deck
        private void btn36Deck_Click(object sender, EventArgs e)
        {
            deckSize = 36;
            myDeck = new Deck(deckSize);
            ResetGame();
        }

        //20 deck
        private void btn20Deck_Click(object sender, EventArgs e)
        {
            deckSize = 20;
            myDeck = new Deck(deckSize);
            ResetGame();
        }

        //clears the log
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            GameLog.ClearLog("Durak Log File : Group 8\n\n");
        }

        //shows the log
        private void btnShowLog_Click(object sender, EventArgs e)
        {
            Process.Start(@"notepad.exe", @"../../gamelog.txt");
        }
    }
}
