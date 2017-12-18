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
    public partial class PropertyPopupFrom : Form
    {
        EntryInfo entryInfo;
        Player player;
        public PropertyPopupFrom(EntryInfo entryInfo, Player player)
        {
            InitializeComponent();
            this.entryInfo = entryInfo;
            this.player = player;
            PropertyNameTextBox.AppendText("Hello, you have arrived at " + 
                entryInfo.EntryName +"\n");
            PropertyNameTextBox.AppendText("Would you like to buy this propoty?");
        }

        /*If the player has sufficient fund, the process of purchasing new property 
        *can be done, otherwise the player cannot buy the property
        */ 
        private void BuyBotton_Click(object sender, EventArgs e)
        {
            if(player.GetFund() > entryInfo.OriginPrice)
            {
                player.Payment(entryInfo.OriginPrice);
                entryInfo.WhichPlayer = player.PlayerID;
               
                player.AddProperty(entryInfo);
                this.Close();
            }
            else
            {
                InformationForm insufficentForm = new InformationForm(player, FormType.insufficientFund);
                insufficentForm.ShowDialog();
            }            
        }

        private void NotBuyBotton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
