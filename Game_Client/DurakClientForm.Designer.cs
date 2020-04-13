/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 */

using Microsoft.VisualBasic;

namespace GameClient
{
    partial class GameClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string UserNamePrompt()
        {
            string message, title, defaultName;
            string userName;

            message = "Please enter your name: ";
            title = "Durak Game - By Group 8";
            defaultName = "PlayerOne";

            userName = Interaction.InputBox(message, title, defaultName).ToString().Trim();

            if (userName == "")
            {
                userName = defaultName;
            }

            return userName;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameClientForm));
            this.lbl_game_deck = new System.Windows.Forms.Label();
            this.lbl_human_player = new System.Windows.Forms.Label();
            this.lbl_computer_player = new System.Windows.Forms.Label();
            this.lbl_river = new System.Windows.Forms.Label();
            this.lbl_computer_attacking = new System.Windows.Forms.Label();
            this.lbl_human_attacking = new System.Windows.Forms.Label();
            this.lbl_trump_card = new System.Windows.Forms.Label();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.btn_pick_up = new System.Windows.Forms.Button();
            this.flp_computers_hand = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_river_hand = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_player_hand = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_deck = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_trump_card = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_discarded_pile = new System.Windows.Forms.Label();
            this.flp_discard_pile = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_deck_cards_remaining = new System.Windows.Forms.TextBox();
            this.txt_dicard_cards_remaining = new System.Windows.Forms.TextBox();
            this.txt_river_cards_remaning = new System.Windows.Forms.TextBox();
            this.btn_cease_attack = new System.Windows.Forms.Button();
            this.btn_52_deck = new System.Windows.Forms.Button();
            this.btn_36_deck = new System.Windows.Forms.Button();
            this.btn_20_deck = new System.Windows.Forms.Button();
            this.btn_clear_log = new System.Windows.Forms.Button();
            this.btn_show_log = new System.Windows.Forms.Button();
            this.lbl_round_number = new System.Windows.Forms.Label();
            this.txtRoundNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_game_deck
            // 
            this.lbl_game_deck.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_game_deck.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lbl_game_deck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_game_deck.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_game_deck.Location = new System.Drawing.Point(13, 206);
            this.lbl_game_deck.Name = "lbl_game_deck";
            this.lbl_game_deck.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_game_deck.Size = new System.Drawing.Size(132, 27);
            this.lbl_game_deck.TabIndex = 0;
            this.lbl_game_deck.Text = "Game Deck";
            this.lbl_game_deck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_human_player
            // 
            this.lbl_human_player.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_human_player.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_human_player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_human_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_human_player.Location = new System.Drawing.Point(1122, 548);
            this.lbl_human_player.Name = "lbl_human_player";
            this.lbl_human_player.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_human_player.Size = new System.Drawing.Size(208, 36);
            this.lbl_human_player.TabIndex = 1;
            this.lbl_human_player.Text = "Human Player Cards";
            this.lbl_human_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_computer_player
            // 
            this.lbl_computer_player.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_computer_player.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_computer_player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_computer_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computer_player.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_computer_player.Location = new System.Drawing.Point(1122, 136);
            this.lbl_computer_player.Name = "lbl_computer_player";
            this.lbl_computer_player.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_computer_player.Size = new System.Drawing.Size(208, 36);
            this.lbl_computer_player.TabIndex = 2;
            this.lbl_computer_player.Text = "Computer Player Cards";
            this.lbl_computer_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_river
            // 
            this.lbl_river.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_river.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_river.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_river.Location = new System.Drawing.Point(1126, 269);
            this.lbl_river.Name = "lbl_river";
            this.lbl_river.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_river.Size = new System.Drawing.Size(129, 28);
            this.lbl_river.TabIndex = 3;
            this.lbl_river.Text = "River Cards";
            this.lbl_river.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_computer_attacking
            // 
            this.lbl_computer_attacking.AutoEllipsis = true;
            this.lbl_computer_attacking.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_computer_attacking.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_computer_attacking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_computer_attacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computer_attacking.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_computer_attacking.Location = new System.Drawing.Point(1122, 100);
            this.lbl_computer_attacking.Name = "lbl_computer_attacking";
            this.lbl_computer_attacking.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_computer_attacking.Size = new System.Drawing.Size(208, 36);
            this.lbl_computer_attacking.TabIndex = 4;
            this.lbl_computer_attacking.Text = "Computer Attacking";
            this.lbl_computer_attacking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_human_attacking
            // 
            this.lbl_human_attacking.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_human_attacking.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_human_attacking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_human_attacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_human_attacking.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_human_attacking.Location = new System.Drawing.Point(1122, 584);
            this.lbl_human_attacking.Name = "lbl_human_attacking";
            this.lbl_human_attacking.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_human_attacking.Size = new System.Drawing.Size(208, 36);
            this.lbl_human_attacking.TabIndex = 5;
            this.lbl_human_attacking.Text = "Human Attacking";
            this.lbl_human_attacking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_trump_card
            // 
            this.lbl_trump_card.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_trump_card.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lbl_trump_card.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_trump_card.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_trump_card.Location = new System.Drawing.Point(12, 413);
            this.lbl_trump_card.Name = "lbl_trump_card";
            this.lbl_trump_card.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_trump_card.Size = new System.Drawing.Size(133, 27);
            this.lbl_trump_card.TabIndex = 6;
            this.lbl_trump_card.Text = "Trump\'s Card";
            this.lbl_trump_card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start_game
            // 
            this.btn_start_game.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.BackgroundImage = global::GameClient.Properties.Resources.btn_1;
            this.btn_start_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start_game.FlatAppearance.BorderSize = 0;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start_game.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_game.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_start_game.Location = new System.Drawing.Point(8, 136);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Padding = new System.Windows.Forms.Padding(5);
            this.btn_start_game.Size = new System.Drawing.Size(242, 48);
            this.btn_start_game.TabIndex = 7;
            this.btn_start_game.Text = "Start New Game";
            this.btn_start_game.UseVisualStyleBackColor = false;
            this.btn_start_game.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btn_pick_up
            // 
            this.btn_pick_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_pick_up.BackgroundImage = global::GameClient.Properties.Resources.btn_1;
            this.btn_pick_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pick_up.CausesValidation = false;
            this.btn_pick_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pick_up.FlatAppearance.BorderSize = 0;
            this.btn_pick_up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pick_up.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pick_up.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_pick_up.Location = new System.Drawing.Point(1122, 675);
            this.btn_pick_up.Name = "btn_pick_up";
            this.btn_pick_up.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_pick_up.Size = new System.Drawing.Size(205, 48);
            this.btn_pick_up.TabIndex = 8;
            this.btn_pick_up.Text = "Pick River Cards";
            this.btn_pick_up.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_pick_up.UseVisualStyleBackColor = false;
            this.btn_pick_up.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // flp_computers_hand
            // 
            this.flp_computers_hand.BackColor = System.Drawing.Color.Transparent;
            this.flp_computers_hand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_computers_hand.ForeColor = System.Drawing.Color.SpringGreen;
            this.flp_computers_hand.Location = new System.Drawing.Point(327, 21);
            this.flp_computers_hand.Name = "flp_computers_hand";
            this.flp_computers_hand.Padding = new System.Windows.Forms.Padding(10);
            this.flp_computers_hand.Size = new System.Drawing.Size(773, 242);
            this.flp_computers_hand.TabIndex = 9;
            // 
            // flp_river_hand
            // 
            this.flp_river_hand.BackColor = System.Drawing.Color.Transparent;
            this.flp_river_hand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_river_hand.ForeColor = System.Drawing.Color.SpringGreen;
            this.flp_river_hand.Location = new System.Drawing.Point(327, 269);
            this.flp_river_hand.Name = "flp_river_hand";
            this.flp_river_hand.Size = new System.Drawing.Size(773, 273);
            this.flp_river_hand.TabIndex = 10;
            // 
            // flp_player_hand
            // 
            this.flp_player_hand.BackColor = System.Drawing.Color.Transparent;
            this.flp_player_hand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_player_hand.ForeColor = System.Drawing.Color.SpringGreen;
            this.flp_player_hand.Location = new System.Drawing.Point(327, 548);
            this.flp_player_hand.Name = "flp_player_hand";
            this.flp_player_hand.Size = new System.Drawing.Size(773, 264);
            this.flp_player_hand.TabIndex = 11;
            // 
            // flp_deck
            // 
            this.flp_deck.BackColor = System.Drawing.Color.Transparent;
            this.flp_deck.Location = new System.Drawing.Point(21, 236);
            this.flp_deck.Name = "flp_deck";
            this.flp_deck.Size = new System.Drawing.Size(109, 137);
            this.flp_deck.TabIndex = 12;
            // 
            // flp_trump_card
            // 
            this.flp_trump_card.BackColor = System.Drawing.Color.Transparent;
            this.flp_trump_card.Location = new System.Drawing.Point(20, 443);
            this.flp_trump_card.Name = "flp_trump_card";
            this.flp_trump_card.Size = new System.Drawing.Size(109, 137);
            this.flp_trump_card.TabIndex = 13;
            // 
            // lbl_discarded_pile
            // 
            this.lbl_discarded_pile.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_discarded_pile.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_discarded_pile.Location = new System.Drawing.Point(12, 633);
            this.lbl_discarded_pile.Name = "lbl_discarded_pile";
            this.lbl_discarded_pile.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_discarded_pile.Size = new System.Drawing.Size(133, 27);
            this.lbl_discarded_pile.TabIndex = 14;
            this.lbl_discarded_pile.Text = "Discarded Cards";
            this.lbl_discarded_pile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_discard_pile
            // 
            this.flp_discard_pile.BackColor = System.Drawing.Color.Transparent;
            this.flp_discard_pile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_discard_pile.Location = new System.Drawing.Point(21, 663);
            this.flp_discard_pile.Name = "flp_discard_pile";
            this.flp_discard_pile.Size = new System.Drawing.Size(109, 129);
            this.flp_discard_pile.TabIndex = 15;
            // 
            // txt_deck_cards_remaining
            // 
            this.txt_deck_cards_remaining.BackColor = System.Drawing.Color.Lime;
            this.txt_deck_cards_remaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_deck_cards_remaining.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_deck_cards_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deck_cards_remaining.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_deck_cards_remaining.Location = new System.Drawing.Point(140, 206);
            this.txt_deck_cards_remaining.Multiline = true;
            this.txt_deck_cards_remaining.Name = "txt_deck_cards_remaining";
            this.txt_deck_cards_remaining.ReadOnly = true;
            this.txt_deck_cards_remaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_deck_cards_remaining.Size = new System.Drawing.Size(40, 27);
            this.txt_deck_cards_remaining.TabIndex = 16;
            this.txt_deck_cards_remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dicard_cards_remaining
            // 
            this.txt_dicard_cards_remaining.BackColor = System.Drawing.Color.Lime;
            this.txt_dicard_cards_remaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dicard_cards_remaining.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_dicard_cards_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dicard_cards_remaining.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_dicard_cards_remaining.Location = new System.Drawing.Point(140, 633);
            this.txt_dicard_cards_remaining.Multiline = true;
            this.txt_dicard_cards_remaining.Name = "txt_dicard_cards_remaining";
            this.txt_dicard_cards_remaining.ReadOnly = true;
            this.txt_dicard_cards_remaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_dicard_cards_remaining.Size = new System.Drawing.Size(40, 27);
            this.txt_dicard_cards_remaining.TabIndex = 17;
            this.txt_dicard_cards_remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_river_cards_remaning
            // 
            this.txt_river_cards_remaning.BackColor = System.Drawing.Color.Lime;
            this.txt_river_cards_remaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_river_cards_remaning.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_river_cards_remaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_river_cards_remaning.Location = new System.Drawing.Point(1255, 269);
            this.txt_river_cards_remaning.Multiline = true;
            this.txt_river_cards_remaning.Name = "txt_river_cards_remaning";
            this.txt_river_cards_remaning.ReadOnly = true;
            this.txt_river_cards_remaning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_river_cards_remaning.Size = new System.Drawing.Size(28, 28);
            this.txt_river_cards_remaning.TabIndex = 18;
            this.txt_river_cards_remaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cease_attack
            // 
            this.btn_cease_attack.BackColor = System.Drawing.Color.Transparent;
            this.btn_cease_attack.BackgroundImage = global::GameClient.Properties.Resources.btn_1;
            this.btn_cease_attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cease_attack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cease_attack.FlatAppearance.BorderSize = 0;
            this.btn_cease_attack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cease_attack.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cease_attack.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_cease_attack.Location = new System.Drawing.Point(1122, 744);
            this.btn_cease_attack.Name = "btn_cease_attack";
            this.btn_cease_attack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_cease_attack.Size = new System.Drawing.Size(205, 48);
            this.btn_cease_attack.TabIndex = 19;
            this.btn_cease_attack.Text = "Stop Attack";
            this.btn_cease_attack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_cease_attack.UseVisualStyleBackColor = false;
            this.btn_cease_attack.Click += new System.EventHandler(this.btnCeaseAttack_Click);
            // 
            // btn_52_deck
            // 
            this.btn_52_deck.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_52_deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_52_deck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_52_deck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_52_deck.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_52_deck.Location = new System.Drawing.Point(8, 4);
            this.btn_52_deck.Name = "btn_52_deck";
            this.btn_52_deck.Padding = new System.Windows.Forms.Padding(5);
            this.btn_52_deck.Size = new System.Drawing.Size(95, 41);
            this.btn_52_deck.TabIndex = 20;
            this.btn_52_deck.Text = "52 Deck";
            this.btn_52_deck.UseVisualStyleBackColor = false;
            this.btn_52_deck.Click += new System.EventHandler(this.btn52Deck_Click);
            // 
            // btn_36_deck
            // 
            this.btn_36_deck.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_36_deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_36_deck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_36_deck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_36_deck.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btn_36_deck.Location = new System.Drawing.Point(109, 4);
            this.btn_36_deck.Name = "btn_36_deck";
            this.btn_36_deck.Padding = new System.Windows.Forms.Padding(5);
            this.btn_36_deck.Size = new System.Drawing.Size(95, 41);
            this.btn_36_deck.TabIndex = 21;
            this.btn_36_deck.Text = "36 Deck";
            this.btn_36_deck.UseVisualStyleBackColor = false;
            this.btn_36_deck.Click += new System.EventHandler(this.btn36Deck_Click);
            // 
            // btn_20_deck
            // 
            this.btn_20_deck.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_20_deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_20_deck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_20_deck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_20_deck.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btn_20_deck.Location = new System.Drawing.Point(210, 4);
            this.btn_20_deck.Name = "btn_20_deck";
            this.btn_20_deck.Padding = new System.Windows.Forms.Padding(5);
            this.btn_20_deck.Size = new System.Drawing.Size(95, 41);
            this.btn_20_deck.TabIndex = 22;
            this.btn_20_deck.Text = "20 Deck";
            this.btn_20_deck.UseVisualStyleBackColor = false;
            this.btn_20_deck.Click += new System.EventHandler(this.btn20Deck_Click);
            // 
            // btn_clear_log
            // 
            this.btn_clear_log.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_clear_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear_log.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear_log.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_clear_log.Location = new System.Drawing.Point(170, 64);
            this.btn_clear_log.Name = "btn_clear_log";
            this.btn_clear_log.Padding = new System.Windows.Forms.Padding(5);
            this.btn_clear_log.Size = new System.Drawing.Size(135, 54);
            this.btn_clear_log.TabIndex = 23;
            this.btn_clear_log.Text = "Clear Log";
            this.btn_clear_log.UseVisualStyleBackColor = false;
            this.btn_clear_log.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btn_show_log
            // 
            this.btn_show_log.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_show_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show_log.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_log.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_show_log.Location = new System.Drawing.Point(8, 64);
            this.btn_show_log.Name = "btn_show_log";
            this.btn_show_log.Padding = new System.Windows.Forms.Padding(5);
            this.btn_show_log.Size = new System.Drawing.Size(137, 54);
            this.btn_show_log.TabIndex = 24;
            this.btn_show_log.Text = "Show Log";
            this.btn_show_log.UseVisualStyleBackColor = false;
            this.btn_show_log.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // lbl_round_number
            // 
            this.lbl_round_number.AutoSize = true;
            this.lbl_round_number.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_round_number.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_round_number.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_round_number.Location = new System.Drawing.Point(1122, 12);
            this.lbl_round_number.Name = "lbl_round_number";
            this.lbl_round_number.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_round_number.Size = new System.Drawing.Size(133, 28);
            this.lbl_round_number.TabIndex = 25;
            this.lbl_round_number.Text = "Round Number :";
            this.lbl_round_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoundNumber
            // 
            this.txtRoundNumber.BackColor = System.Drawing.Color.Lime;
            this.txtRoundNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoundNumber.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundNumber.Location = new System.Drawing.Point(1255, 12);
            this.txtRoundNumber.Multiline = true;
            this.txtRoundNumber.Name = "txtRoundNumber";
            this.txtRoundNumber.ReadOnly = true;
            this.txtRoundNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoundNumber.Size = new System.Drawing.Size(28, 28);
            this.txtRoundNumber.TabIndex = 26;
            this.txtRoundNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1345, 824);
            this.Controls.Add(this.txtRoundNumber);
            this.Controls.Add(this.lbl_round_number);
            this.Controls.Add(this.btn_show_log);
            this.Controls.Add(this.btn_clear_log);
            this.Controls.Add(this.btn_20_deck);
            this.Controls.Add(this.btn_36_deck);
            this.Controls.Add(this.btn_52_deck);
            this.Controls.Add(this.btn_cease_attack);
            this.Controls.Add(this.txt_river_cards_remaning);
            this.Controls.Add(this.txt_dicard_cards_remaining);
            this.Controls.Add(this.txt_deck_cards_remaining);
            this.Controls.Add(this.flp_discard_pile);
            this.Controls.Add(this.lbl_discarded_pile);
            this.Controls.Add(this.flp_trump_card);
            this.Controls.Add(this.flp_deck);
            this.Controls.Add(this.flp_player_hand);
            this.Controls.Add(this.flp_river_hand);
            this.Controls.Add(this.flp_computers_hand);
            this.Controls.Add(this.btn_pick_up);
            this.Controls.Add(this.btn_start_game);
            this.Controls.Add(this.lbl_trump_card);
            this.Controls.Add(this.lbl_human_attacking);
            this.Controls.Add(this.lbl_computer_attacking);
            this.Controls.Add(this.lbl_river);
            this.Controls.Add(this.lbl_computer_player);
            this.Controls.Add(this.lbl_human_player);
            this.Controls.Add(this.lbl_game_deck);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "GameClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak - by Group 8";
            this.Load += new System.EventHandler(this.GameClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_game_deck;
        private System.Windows.Forms.Label lbl_human_player;
        private System.Windows.Forms.Label lbl_computer_player;
        private System.Windows.Forms.Label lbl_river;
        private System.Windows.Forms.Label lbl_computer_attacking;
        private System.Windows.Forms.Label lbl_human_attacking;
        private System.Windows.Forms.Label lbl_trump_card;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn_pick_up;
        private System.Windows.Forms.FlowLayoutPanel flp_computers_hand;
        private System.Windows.Forms.FlowLayoutPanel flp_river_hand;
        private System.Windows.Forms.FlowLayoutPanel flp_player_hand;
        private System.Windows.Forms.FlowLayoutPanel flp_deck;
        private System.Windows.Forms.FlowLayoutPanel flp_trump_card;
        private System.Windows.Forms.Label lbl_discarded_pile;
        private System.Windows.Forms.FlowLayoutPanel flp_discard_pile;
        private System.Windows.Forms.TextBox txt_deck_cards_remaining;
        private System.Windows.Forms.TextBox txt_dicard_cards_remaining;
        private System.Windows.Forms.TextBox txt_river_cards_remaning;
        private System.Windows.Forms.Button btn_cease_attack;
        private System.Windows.Forms.Button btn_52_deck;
        private System.Windows.Forms.Button btn_36_deck;
        private System.Windows.Forms.Button btn_20_deck;
        private System.Windows.Forms.Button btn_clear_log;
        private System.Windows.Forms.Button btn_show_log;
        private System.Windows.Forms.Label lbl_round_number;
        private System.Windows.Forms.TextBox txtRoundNumber;
    }
}