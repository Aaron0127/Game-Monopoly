using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace Monopoly
{
    public enum FormType {goJailForm,  payRentForm, luxuryForm, incomeForm, chestForm, chanceForm, gameOver,
    insufficientFund};
    public partial class GameInterface : Form
    {       
        private class Coordinate
        {           
            private int x, y;
            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int GetX()
            {
                return x;
            }

            public int GetY()
            {
                return y;
            }
        }

        public enum ChestItem {advancedToGo, bankError, doctorFee,
            goToJail, holidayTrip, grandOperaNight};
        /* if the remider of stateOfPlayer is 0, palyer1's turn to play game 
         * otherwise, palyer2's turn to play game
        */
        private int whichTurn = 0;
        private int numberOfDices;
        Player currentPlayer;
        Player nextPlayer;

        private bool bolGameStarted = false; //0 for begin, 1 for playing
        GameBoardInfo gameBoardInfo;
        List<Coordinate> coordinates;
        List<EntryInfo> propertyOfPlayer1;
        List<EntryInfo> propertyOfPlayer2;
        Player player1;
        Player player2;
        bool isJustLoaded; //true means jsut loaded a game
        IDictionary<int,Player> Players;
        Rectangle recPlayer1;
        Rectangle recPlayer2;
        SoundPlayer sound;
        bool isTurnOffSound;

        public GameInterface()
        {
            InitializeComponent();
            coordinates = new List<Coordinate>();
            InitalCoordinate();
            player1 = new Player("Player1", 1);
            player2 = new Player("Player2", 2);
            gameBoardInfo = new GameBoardInfo();

            ShowAvaliableFund();
            this.Players = new Dictionary<int,Player>();
            this.Players.Add(0, player1);
            this.Players.Add(1, player2);
            isJustLoaded = false;
            isTurnOffSound = false;
            try
            {
                sound = new SoundPlayer(Monopoly.Properties.Resources.Divided_We_Fall);
                sound.PlayLooping();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace.ToString(), "Error");
            }
        }
        
        public GameInterface(Player player1, Player player2)
        {
            InitializeComponent();
            coordinates = new List<Coordinate>();
            InitalCoordinate();
            this.player1 = player1;
            this.player2 = player2;
            this.gameBoardInfo = new GameBoardInfo();

            ShowAvaliableFund();
            this.Players = new Dictionary<int, Player>();
            this.Players.Add(0, player1);
            this.Players.Add(1, player2);
            isJustLoaded = true;
            bolGameStarted = true;
            isTurnOffSound = false;
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            sound.Stop();
            this.Close();
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {
            if(!bolGameStarted)
            {
                DrawPlayerAtStart(e);
            } else
            {
                int xPlayer1 = coordinates[player1.TotalMovement].GetX();
                int yPlayer1 = coordinates[player1.TotalMovement].GetY();
                DrawMovementPlayer1(e, xPlayer1, yPlayer1);
                
                int xPlayer2 = coordinates[player2.TotalMovement].GetX();
                int yPlayer2 = coordinates[player2.TotalMovement].GetY();
                DrawMovementPlayer2(e, xPlayer2, yPlayer2);
            }            
        }

        private void DrawPlayerAtStart(PaintEventArgs e)
        {
            //Draw first player's position
            SolidBrush firca_dis = new SolidBrush(Color.FromArgb(192, 0, 192));
            Rectangle cirPlayer1 = new Rectangle(504, 530, 15, 15); //Size and location of the Circle

            e.Graphics.FillEllipse(firca_dis, cirPlayer1); //Draw a Circle and fill it
            e.Graphics.DrawEllipse(new Pen(firca_dis), cirPlayer1);

            //Draw second player's position
            SolidBrush secca_dis = new SolidBrush(Color.FromArgb(17, 0,255));
            Rectangle cirPlayer2 = new Rectangle(532, 530, 15, 15); //Size and location of the Circle

            e.Graphics.FillEllipse(secca_dis, cirPlayer2); //Draw a Circle and fill it
            e.Graphics.DrawEllipse(new Pen(secca_dis), cirPlayer2);

            Invalidate();
        }

        private void DrawMovementPlayer1(PaintEventArgs e, int x, int y)
        {
            SolidBrush firca_dis = new SolidBrush(Color.FromArgb(192, 0, 192));
            recPlayer1 = new Rectangle(x, y, 15, 15); //Size and location of the Circle

            e.Graphics.FillEllipse(firca_dis, recPlayer1); //Draw a Circle and fill it
            e.Graphics.DrawEllipse(new Pen(firca_dis), recPlayer1);
        }

        private void DrawMovementPlayer2(PaintEventArgs e, int x, int y)
        {
            SolidBrush secca_dis = new SolidBrush(Color.FromArgb(17, 0, 255));
            recPlayer2 = new Rectangle(x + 23, y, 15, 15); //Size and location of the Circle

            e.Graphics.FillEllipse(secca_dis, recPlayer2); //Draw a Circle and fill it
            e.Graphics.DrawEllipse(new Pen(secca_dis), recPlayer2);
        }

        private void panelBoard_MouseMove(object sender, MouseEventArgs e)
        {
            Text= e.Location.X + ":" + e.Location.Y;
        }

        private void panelBoard_MouseDown(object sender, MouseEventArgs e)
        { 
            rolledDice.AppendText(e.Location.X + ":" + e.Location.Y + "\n") ;
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            bolGameStarted = true;
            if (!isJustLoaded) //if start from a new game
            {
                currentPlayer = Players[whichTurn % 2];
                nextPlayer = Players[(whichTurn + 1) % 2];
            }
            else //if start from a load game
            {
                if (Players[0].IsPlayerTurn == true)
                {
                    currentPlayer = player1;
                    nextPlayer = player2;
                }
                else
                {
                    currentPlayer = player2;
                    nextPlayer = player1;
                }
                isJustLoaded = false;
            }

            numberOfDices = currentPlayer.GetRollDiceResult();
            currentPlayer.TotalMovement += numberOfDices;
            /*
            * if player 1 has already moved 39 steps,
            * then find the remminder to incase excess the total number of space on the game board
            */
            if (currentPlayer.TotalMovement >= 39)
            {
                currentPlayer.TotalMovement = currentPlayer.TotalMovement % 39;
                currentPlayer.RecieveFund(200);
            }
            rolledDice.AppendText(currentPlayer.PlayerName + " arrived " + GameBoardInfo.list[currentPlayer.TotalMovement].EntryName + " (number of dices" + numberOfDices + ")" + "\n");
            rolledDice.AppendText("\n");
            rollDiceButton.Enabled = false;
            panelBoard.Invalidate();                     
            PlayerRules(currentPlayer, currentPlayer.TotalMovement);
                    
            ShowAvaliableFund(); // update avalibale fund
        }

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            if(currentPlayer.GetFund() < 0)
            {
                InformationForm gameOverForm = new InformationForm(nextPlayer, currentPlayer, FormType.gameOver);
                gameOverForm.ShowDialog();
                sound.Stop();
                this.Close();
            }

            if(nextPlayer.JailTerm > 0)
            {
                nextPlayer.ReduceJailTerm();
                currentPlayer.IsPlayerTurn = true;
                nextPlayer.IsPlayerTurn = false;
            }
            else
            {
                if(nextPlayer.IsJustOutOfJail == true)
                {
                    nextPlayer.TotalMovement = 10;
                    panelBoard.Invalidate();
                    nextPlayer.IsJustOutOfJail = false;
                }
                whichTurn += 1;
            }
            
            rollDiceButton.Enabled = true;         
        }

        private void ShowInformation(EntryInfo info, Player player, int playerID, FormType formType)
        {
            switch (formType)
            {
                case FormType.goJailForm:
                    InformationForm goJailForm = new InformationForm(player, formType);
                    goJailForm.ShowDialog();
                    break;
                case FormType.payRentForm:
                    if (player.PlayerID == 1)//if player 1 pays rent
                    {
                        InformationForm payRentForm = new InformationForm(info, player, player2);
                        payRentForm.ShowDialog();
                    }
                    else if (player.PlayerID == 2)//if player 2 pays rent
                    {
                        InformationForm payRentForm = new InformationForm(info, player, player1);
                        payRentForm.ShowDialog();
                    }
                    break;
                case FormType.luxuryForm:
                    InformationForm luxuryForm = new InformationForm(player, formType);
                    luxuryForm.ShowDialog();
                    break;
                case FormType.incomeForm:
                    InformationForm incomeForm = new InformationForm(player, formType);
                    incomeForm.ShowDialog();
                    break;
                case FormType.chestForm:
                    ChestItem item;
                    Random random = new Random();
                    int ran = random.Next(0, 6);
                    item = (ChestItem)Enum.Parse(typeof(ChestItem), ran.ToString());
                    InformationForm chestForm = new InformationForm(item, ran, player1, player2, playerID);
                    chestForm.ShowDialog();
                    break;
                case FormType.chanceForm:
                    InformationForm chanceForm = new InformationForm(player, formType);
                    chanceForm.ShowDialog();
                    break;
            }
        }

        private void PlayerRules(Player player, int toatoalmovemnt)
        {
            EntryInfo info;
            info = GameBoardInfo.list[toatoalmovemnt];
            
            if (info.GetEnumType() == Type.property &&
                info.WhichPlayer == 0)
            {
                PropertyPopupFrom propertyPopup = new PropertyPopupFrom(info, player);
                propertyPopup.ShowDialog();
                
            }
            else if (info.GetEnumType() == Type.property &&
                info.WhichPlayer == player.PlayerID)
            {
                UpgradForm upgradForm = new UpgradForm(info, player);
                upgradForm.ShowDialog();
            }
            //ShowInformation(EntryInfo info, Player player, 
            //int playerID, FormType formType)
            else if (info.GetEnumType() == Type.property &&
                info.WhichPlayer != player.PlayerID)
            {
                if(player.PlayerID == 1)//if player 1 pays rent
                {
                    ShowInformation(info, player, player.PlayerID, FormType.payRentForm);
                } else if(player.PlayerID == 2)//if player 2 pays rent
                {
                    ShowInformation(info, player, player.PlayerID, FormType.payRentForm);
                }
            }
            else if (info.GetEnumType() == Type.chest)
            {
                ShowInformation(info, player, player.PlayerID, FormType.chestForm);
            }
            else if(info.GetEnumType() == Type.goJail)
            {
                ShowInformation(info, player, player.PlayerID, FormType.goJailForm);
            }            
            else if(info.GetEnumType() == Type.incomeTax)
            {
                ShowInformation(info, player, player.PlayerID, FormType.incomeForm);
            }
            else if(info.GetEnumType() == Type.luxuryTax)
            {
                ShowInformation(info, player, player.PlayerID, FormType.luxuryForm);
            }
            //TODO move player to certain locations
            else if (info.GetEnumType() == Type.chance)
            {
                ShowInformation(info, player, player.PlayerID, FormType.chanceForm);
                panelBoard.Invalidate();
            }
            currentPlayer.IsPlayerTurn = false;
            nextPlayer.IsPlayerTurn = true;
        }

        //initial each space coordinate on the board
        private void InitalCoordinate() 
        {
            //bottom of the Board
            //index from 0 to 10(11 entries)
            coordinates.Add(new Coordinate(504, 530));
            coordinates.Add(new Coordinate(448, 530));
            coordinates.Add(new Coordinate(405, 530));
            coordinates.Add(new Coordinate(359, 530));
            coordinates.Add(new Coordinate(313, 530));
            coordinates.Add(new Coordinate(267, 530));
            coordinates.Add(new Coordinate(221, 530));
            coordinates.Add(new Coordinate(174, 530));
            coordinates.Add(new Coordinate(128, 530));
            coordinates.Add(new Coordinate(83, 530));
            coordinates.Add(new Coordinate(10, 530));

            //left of the Board
            //index from 11 to 20
            coordinates.Add(new Coordinate(10, 468));
            coordinates.Add(new Coordinate(10, 425));
            coordinates.Add(new Coordinate(10, 376));
            coordinates.Add(new Coordinate(10, 328));
            coordinates.Add(new Coordinate(10, 285));
            coordinates.Add(new Coordinate(10, 237));
            coordinates.Add(new Coordinate(10, 191));
            coordinates.Add(new Coordinate(10, 141));
            coordinates.Add(new Coordinate(10, 98));
            coordinates.Add(new Coordinate(10, 33));

            //top of the Board
            //index from 21 to 30 
            coordinates.Add(new Coordinate(81, 33));
            coordinates.Add(new Coordinate(128, 33));
            coordinates.Add(new Coordinate(173, 33));
            coordinates.Add(new Coordinate(220, 33));
            coordinates.Add(new Coordinate(266, 33));
            coordinates.Add(new Coordinate(312, 33));
            coordinates.Add(new Coordinate(359, 33));
            coordinates.Add(new Coordinate(406, 33));
            coordinates.Add(new Coordinate(452, 33));
            coordinates.Add(new Coordinate(515, 33));

            //right of the Board
            //index from 31 to 39
            coordinates.Add(new Coordinate(515, 98));
            coordinates.Add(new Coordinate(515, 144));
            coordinates.Add(new Coordinate(515, 186));
            coordinates.Add(new Coordinate(515, 230));
            coordinates.Add(new Coordinate(515, 282));
            coordinates.Add(new Coordinate(515, 328));
            coordinates.Add(new Coordinate(515, 370));
            coordinates.Add(new Coordinate(515, 418));
            coordinates.Add(new Coordinate(515, 465));
        }
       
        private void ShowAvaliableFund()
        {
            Player1FundBox.Clear();
            Player1FundBox.AppendText(" $" + player1.GetFund());

            Player2FundBox.Clear();
            Player2FundBox.AppendText(" $" + player2.GetFund());
        }

        private void ManageProperty()
        {
            propertyOfPlayer1 = player1.GetPropertyList();
            propertyOfPlayer2 = player2.GetPropertyList();
            PropertyList propertyList = new PropertyList(propertyOfPlayer1, propertyOfPlayer2);
            propertyList.ShowDialog();
        }

        private void propertyButton_Click(object sender, EventArgs e)
        {
            ManageProperty();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {              
                using (Stream output = File.Create("Player.dat"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(output, player1);
                    formatter.Serialize(output, player2);
                }
                MessageBox.Show("Game Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void stopMusicButton_Click(object sender, EventArgs e)
        {
            if(!isTurnOffSound)
            {
                sound.Stop();
                isTurnOffSound = true;
                stopMusicButton.Text = "Open Music";
            }
            else if(isTurnOffSound)
            {
                sound.Play();
                isTurnOffSound = false;
                stopMusicButton.Text = "Stop Music";
            }           
        }
    }    
}
