using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    public partial class Form1 : Form
    {
        //List for the Unshuffled Deck
        List<Card> MessyDeck = new List<Card>(108);

        //Lists for the 2 shuffled 10 card decks per player
        List<Card> Deck1 = new List<Card>(10);
        List<Card> Deck2 = new List<Card>(10);

        //Lists for the cards played per player
        List<Card> Play1 = new List<Card>();
        List<Card> Play2 = new List<Card>();

        //Player Hands
        private Hand player1Hand = new Hand();
        private Hand player2Hand = new Hand();

        //Setting tempCards to null
        Card tempCard = null;
        Card tempCard2 = null;

        //Setting playerTotals to 0
        int player1Total = 0;
        int player2Total = 0;

        //Declaring card count per player to 0 at start of game
        int player1Dumpling = 0;
        int player2Dumpling = 0;
        int player1Sashimi = 0;
        int player2Sashimi = 0;
        int player1Tempura = 0;
        int player2Tempura = 0;
        int player1Pudding=0;
        int player2Pudding = 0;
        int player1Maki = 0;
        int player2Maki = 0;

        //Declaring round to 0 at start of game
        int Round = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the deck of cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            DeckOfCards();
        }

        /// <summary>
        /// Deck of unshuffled cards method
        /// </summary>
        public void DeckOfCards()
        {
            //Create 108 cards
            for (int i = 0; i <= 108; i++)
            {
                //14 tempura
                if (i < 14)
                {
                    Tempura tmpr = new Tempura();
                    MessyDeck.Add(tmpr);
                }
                //14 Sashimi
                if (14 < 28)
                {
                    Sashimi sshm = new Sashimi();
                    MessyDeck.Add(sshm);
                }
                //14 Dumpling
                if (28 < 42)
                {
                    Dumpling dmplng = new Dumpling();
                    MessyDeck.Add(dmplng);
                }
                //12 Maki with 2 pieces
                if (42 < 54)
                {
                    Maki mk = new Maki(2);
                    MessyDeck.Add(mk);
                }
                //8 Maki with 3 pieces
                if (54 < 62)
                {
                    Maki mk = new Maki(3);
                    MessyDeck.Add(mk);
                }
                //6 Maki with 1 piece
                if (62 < 68)
                {
                    Maki mk = new Maki(1);
                    MessyDeck.Add(mk);
                }
                //10 Salmon Nigiri
                if (68 < 78)
                {
                    Nigiri slmnNigiri = new Nigiri("Salmon");
                    MessyDeck.Add(slmnNigiri);
                }
                //5 Squid Nigiri
                if (78 < 83)
                {
                    Nigiri sqdNigiri = new Nigiri("Squid");
                    MessyDeck.Add(sqdNigiri);
                }
                //5 Egg Nigiri
                if (83 < 88)
                {
                    Nigiri eggNigiri = new Nigiri("Egg");
                    MessyDeck.Add(eggNigiri);
                }
                //10 puddings
                if (88 < 98)
                {
                    Pudding pddng = new Pudding();
                    MessyDeck.Add(pddng);
                }
                //6 Wasabi
                if (98 < 104)
                {
                    Wasabi wsb = new Wasabi();
                    MessyDeck.Add(wsb);
                }
                //4 Chopsticks
                if (104 < 108)
                {
                    Chopsticks chop = new Chopsticks();
                    MessyDeck.Add(chop);
                }
            }

        }
        /// <summary>
        /// Deal the cards to each player
        /// </summary>
        public void Deal()
        {
            Random rand = new Random();
            player1Total = 0;
            //Give each player 10 cards randomly from the unshuffled Deck
            for (int d = 0; d < 10; d++)
            {
                Deck1.Add(MessyDeck[rand.Next(0, 108)]);
                Deck2.Add(MessyDeck[rand.Next(0, 108)]);
            }
            //Update the listboxes
            UpdateListBoxes();
        }

        /// <summary>
        /// Method to update the listboxes
        /// </summary>
        public void UpdateListBoxes()
        {
            listBoxPlayer1.Items.Clear();
            listBoxPlayer2.Items.Clear();
            listBoxPlayArea1.Items.Clear();
            listBoxPlayArea2.Items.Clear();
            player1Hand.ClearCards();
            player2Hand.ClearCards();
            tempCard = null;
            tempCard2= null;

            //foreach card in player1 deck add card to listBox for that player
            foreach (Card c in Deck1)
            {
                listBoxPlayer1.Items.Add(c);
            }
            //foreach card in player2 deck add card to listBox for that player
            foreach (Card c in Deck2)
            {
                listBoxPlayer2.Items.Add(c);
            }
            //foreach card in player1 play area add card to listBox and handlist for that player
            foreach (Card c in Play1)
            {
                listBoxPlayArea1.Items.Add(c);
                player1Hand.AddCard(c);
            }
            //foreach card in player2 play area add card to listBox and handlist for that player
            foreach (Card c in Play2)
            {
                listBoxPlayArea2.Items.Add(c);
                player2Hand.AddCard(c);
            }        
        }

        /// <summary>
        /// Method to calculate the scores
        /// </summary>
        private void Scoring()
        {
            player1Total = player1Hand.Total() + DumplingPoints(player1Dumpling) + SashimiPoints(player1Sashimi) + TempuraPoints(player1Tempura); //The total score for player 1
            player2Total = player2Hand.Total() + DumplingPoints(player2Dumpling) + SashimiPoints(player2Sashimi) + TempuraPoints(player2Tempura); // The total score for player 2

            //If final round
            if (Round == 3)
            {
                //Calculate who has the most puddings and award points accordingly
                if (player1Pudding > player2Pudding)
                {
                    player1Total += 6;
                }
                if (player1Pudding < player2Pudding)
                {
                    player2Total += 6;
                }
                //If even pudding cards then split the points between players
                if (player1Pudding == player2Pudding)
                {
                    player1Total += 3;
                    player1Total += 3;
                }
                //Calculate who has the most Maki and award points accordingly
                if (player1Maki > player2Maki)
                {
                    player1Total += 6;
                }
                if (player1Maki < player2Maki)
                {
                    player2Total += 6;
                }
                //If even Maki cards then split the points between players
                if (player1Maki == player2Maki)
                {
                    player1Total += 3;
                    player2Total += 3;
                }

            }
            
        }

        /// <summary>
        /// Deal button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeal_Click(object sender, EventArgs e)
        {
            //disable the swap button and finish button
            buttonSwap.Enabled = false;
            buttonFinish.Enabled = false;
            //increment round 
            Round++;
            //call upon deal method
            Deal();
            //If it is final round disable the deal button
            if (Round == 3)
            {
                buttonDeal.Enabled = false;                
            }
        }

       /// <summary>
       /// Exit game
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Determine if card selected in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;

            //if something is selected go and find the index method get selected index(), global card variable, go into list corresponding
            //this temporary card replaces new card. 
            if (listBoxPlayer1.SelectedIndex != -1)
            {
                index = listBoxPlayer1.SelectedIndex;
                tempCard = Deck1[index];
            }
            //else nothing is selected
            else
            {
                tempCard = null;
            }
        }

        /// <summary>
        /// Play selected card method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //If there is a temp card add that tempcard to play area and remove from deck
            if (tempCard != null)
            {
                Play1.Add(tempCard);
                Deck1.Remove(tempCard);

                //depending on the card type increment the player count of that specific card
                if (tempCard._type == "Dumpling")
                {
                    player1Dumpling++;
                }
                if (tempCard._type == "Sashimi")
                {
                    player1Sashimi++;
                }
                if (tempCard._type == "Tempura")
                {
                    player1Tempura++;
                }
                if (tempCard._type == "Pudding")
                {
                    player1Pudding++;
                }
                //if there is no cards remaining in the deck calculate the player score
                if (Deck1.Count == 0)
                {
                    Scoring();
                }
            }
            //Update the listboxes
            UpdateListBoxes();

            //If the deck counts arent 0 then disable the play button
            if (Deck1.Count != 0 && Deck2.Count !=0)
            {
                buttonPlay.Enabled = false;
            }
            //If its the final round and both the player decks are empty enable the finish button
            if (Round == 3)
            {
                if (Deck1.Count == 0 && Deck2.Count == 0)
                {
                    buttonFinish.Enabled = true;
                }
            }
            //If the play buttons are not enabled, enable the swap button
            if (buttonPlayPlayer2.Enabled == false && buttonPlay.Enabled == false)
            {
                buttonSwap.Enabled = true;
            }

        }
        /// <summary>
        /// Button to swap decks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSwap_Click(object sender, EventArgs e)
        {
            //disable swap button after click
            buttonSwap.Enabled = false;
            //templist is equal to deck
            List<Card> tempList = Deck1;
            //swap decks
            Deck1 = Deck2;
            //deck2 is equal to tempDeck
            Deck2 = tempList;
            //Update the listboxes
            UpdateListBoxes();
            //Enabvle the play buttons
            buttonPlay.Enabled = true;
            buttonPlayPlayer2.Enabled = true;
        }
        /// <summary>
        /// Determine if card selected in listbox player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;

            //if something is selected go and find the index method get selected index(), global card variable, go into list corresponding
            //this temporary card replaces new card. 
            if (listBoxPlayer2.SelectedIndex != -1)
            {
                index = listBoxPlayer2.SelectedIndex;
                tempCard2 = Deck2[index];
            }
            //else nothing is selected
            else
            {
                tempCard2 = null;
            }
        }

        /// <summary>
        /// Play selected card method player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayPlayer2_Click(object sender, EventArgs e)
        {
            //If there is a temp card add that tempcard to play area and remove from deck
            if (tempCard2 != null)
            {
                Play2.Add(tempCard2);
                Deck2.Remove(tempCard2);

                //depending on the card type increment the player count of that specific card
                if (tempCard2._type == "Dumpling")
                {
                    player2Dumpling++;
                }
                if (tempCard2._type == "Sashimi")
                {
                    player2Sashimi++;
                }
                if (tempCard2._type == "Tempura")
                {
                    player2Tempura++;
                }
                if (tempCard2._type == "Pudding")
                {
                    player2Pudding++;
                }
                //if there is no cards remaining in the deck calculate the player score
                if (Deck2.Count == 0)
                {
                    Scoring();
                }
            }
            //Update the listboxes
            UpdateListBoxes();

           

            //If the deck counts arent 0 then disable the play button
            if (Deck1.Count != 0 && Deck2.Count != 0)
            {
                buttonPlayPlayer2.Enabled = false;
            }
            if (Round == 3)
            {
                if (Deck1.Count == 0 && Deck2.Count == 0)
                {
                    buttonFinish.Enabled = true;
                }
            }
            //If the play buttons are disabled, enable the swap button
            if (buttonPlayPlayer2.Enabled == false && buttonPlay.Enabled == false)
            {
                buttonSwap.Enabled = true;
            }

        }

        /// <summary>
        /// Method to calculate the points dependant on dumpling amount
        /// </summary>
        /// <param name="dumplings">parse the number of dumplings</param>
        /// <returns></returns>
        private int DumplingPoints(int dumplings)
        {
            int Points = 0;
            //1 dumplins is 1 point
            if (dumplings == 1)
            {
                Points = 1;
            }
            //2 dumplins is 3 point
            if (dumplings == 2)
            {
                Points = 3;
            }
            //3 dumplins is 6 point
            if (dumplings == 3)
            {
                Points = 6;
            }
            //4 dumplins is 10 point
            if (dumplings == 4)
            {
                Points = 10;
            }
            //5 or greater dumplins is 15 point
            if (dumplings >= 5)
            {
                Points = 15;
            }
            return Points;
        }
        /// <summary>
        /// Calculate tempura points
        /// </summary>
        /// <param name="tempura"> number of tempura</param>
        /// <returns></returns>
        private int TempuraPoints(int tempura)
        {
            int Points = 0;
            //If it is a set of 2 it equals 5 points
            Points =(tempura/2) *5;
            return Points;
        }
        /// <summary>
        /// Calculatre sashimi points
        /// </summary>
        /// <param name="sashimi">number of sashimi</param>
        /// <returns></returns>
        private int SashimiPoints(int sashimi)
        {
            int Points = 0;
            //If it is a set of 3 it equals 10 points
            Points = (sashimi / 3) * 10;
            return Points;
        }
        /// <summary>
        /// Calculate pudding points
        /// </summary>
        /// <param name="pudding">number of puddings</param>
        /// <returns></returns>
        private int PuddingPoints(int pudding)
        {
            //Puddings is 6 points (dependant on who has the most)
            int Points = 6;
            return Points;
        }
        /// <summary>
        /// Finish the game method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFinish_Click(object sender, EventArgs e)
        {           
            textBoxPlayerPoints.Text = player1Total.ToString(); // display player 1 points
            textBoxPlayer2Points.Text = player2Total.ToString(); // display player 2 points

            //Work out who the winner is
            if (int.Parse(textBoxPlayerPoints.Text) > int.Parse(textBoxPlayer2Points.Text))
            {
                MessageBox.Show("Player1 wins with a total of " + (int.Parse(textBoxPlayerPoints.Text)) + " points!");
            }
            else if (int.Parse(textBoxPlayerPoints.Text) < int.Parse(textBoxPlayer2Points.Text))
            {
                MessageBox.Show("Player2 wins with a total of " + (int.Parse(textBoxPlayer2Points.Text)) + " points!");
            }
            //If it is even points then it is a draw
            else if (int.Parse(textBoxPlayerPoints.Text) == int.Parse(textBoxPlayer2Points.Text))
            {
                MessageBox.Show("Draw!");
            }
        }
        /// <summary>
        /// Clear the entire game and reset everything to zero and default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UpdateListBoxes();
            MessyDeck.Clear();
            Deck1.Clear();
            Deck2.Clear();
            Play1.Clear();
            Play2.Clear();
            listBoxPlayer1.Items.Clear();
            listBoxPlayer2.Items.Clear();
            listBoxPlayArea1.Items.Clear();
            listBoxPlayArea2.Items.Clear();
            player1Total = 0;
            player2Total = 0;
            textBoxPlayerPoints.Text= "Player1 Points";
            textBoxPlayer2Points.Text = "Player2 Points";
            DeckOfCards();
            buttonDeal.Enabled=true;
            Round = 0;
        }
        /// <summary>
        /// Menu strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
