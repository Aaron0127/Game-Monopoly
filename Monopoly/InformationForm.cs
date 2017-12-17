using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class InformationForm : Form
    {
        //Constructor for displaying go to jail text to player
        public InformationForm(Player player, FormType formType)
        {
            InitializeComponent();
            if(formType == FormType.goJailForm)
            {
                player.GoJail();
                infoTextBox.AppendText("Police has arrested you!\n" +
                    "You will be held in custody for 2 turns.");                
            }else if(formType == FormType.luxuryForm)
            {
                player.Payment(75);
                infoTextBox.AppendText("You need to pay luxury tax $75");
            }else if(formType == FormType.incomeForm)
            {
                player.Payment(100);
                infoTextBox.AppendText("You need to pay income tax $100");
            }else if(formType == FormType.chanceForm)
            {
                Random ran = new Random();
                int possiblle_chance = ran.Next(0, 3);
                switch(possiblle_chance)
                {
                    case 0:
                        infoTextBox.AppendText("Your position will not been moved");
                        break;
                    case 1:
                        player.TotalMovement = 20;
                        infoTextBox.AppendText("You have been moved to Free Parking");
                        break;
                    case 2:
                        player.TotalMovement = 10;
                        infoTextBox.AppendText("You have been moved to Visiting Jail");
                        break;
                }
                
            }
            else if(formType == FormType.insufficientFund)
            {
                infoTextBox.AppendText(player.PlayerName + " has insuffient Fund!");
            }
            timer.Interval = 3000;
            timer.Start();
        }

        //Constructor for displaying pay rent to another player
        public InformationForm(EntryInfo info, Player playerWhoPay, Player playerWhoRecieve)
        {
            InitializeComponent();

            int rentPirce = info.GetPrice();
            playerWhoPay.Payment(rentPirce);
            playerWhoRecieve.RecieveFund(rentPirce);
            infoTextBox.AppendText(string.Format("you Pay ${0} rent to {1} at {2}",
                rentPirce, playerWhoRecieve.PlayerName, info.EntryName));

            timer.Interval = 3000;
            timer.Start();
        }

        //ChestForm(GameInterface.ChestItem chestItem, int radomNum, Player player1, Player player2, int id)
        public InformationForm(GameInterface.ChestItem chestItem, int radomNum, Player player1, Player player2, int playerID)
        {
            InitializeComponent();

            switch (chestItem)
            {

                case GameInterface.ChestItem.advancedToGo:
                    infoTextBox.AppendText("You have just win $200!");                 
                    if (playerID == 1)
                    {
                        player1.RecieveFund(200);
                    }
                    else if (playerID == 2)
                    {
                        player2.RecieveFund(200);
                    }
                    break;
                case GameInterface.ChestItem.bankError:
                    infoTextBox.AppendText("Your bank account has error.\n" +
                        "$50 has been added to your fund");
                    if (playerID == 1)
                    {
                        player1.RecieveFund(50);
                    }
                    else if (playerID == 2)
                    {
                        player2.RecieveFund(50);
                    }
                    break;
                case GameInterface.ChestItem.doctorFee:
                    infoTextBox.AppendText("You pay $50 to your doctor!");
                    if (playerID == 1)
                    {
                        player1.Payment(50);
                    }
                    else if (playerID == 2)
                    {
                        player2.Payment(50);
                    }
                    break;
                case GameInterface.ChestItem.goToJail:
                    if (playerID == 1)
                    {
                        player1.GoJail();
                    }
                    else if (playerID == 2)
                    {
                        player2.GoJail();
                    }
                    infoTextBox.AppendText("You have just win $200!");
                    break;
                case GameInterface.ChestItem.holidayTrip:
                    infoTextBox.AppendText("You have a holiday trip card!\n" +
                        "It worth $150");
                    if (playerID == 1)
                    {
                        player1.RecieveFund(150);
                    }
                    else if (playerID == 2)
                    {
                        player2.RecieveFund(150);
                    }
                    break;
                case GameInterface.ChestItem.grandOperaNight:
                    infoTextBox.AppendText("All players visit Grand Opera Night.\n" +
                        "Ticket fee is $50");
                    player1.Payment(50);
                    player2.Payment(50);
                    break;
            }
            timer.Interval = 3000;
            timer.Start();
        }

        public InformationForm(Player winner, Player loser, FormType formType)
        {
            InitializeComponent();
            infoTextBox.Font = new Font(infoTextBox.Font.FontFamily, 16);
            string message = String.Format("Game is over.\n The winner is: {0}\n"
                , winner.PlayerName);
            infoTextBox.AppendText(message);
            timer.Interval = 5000;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
