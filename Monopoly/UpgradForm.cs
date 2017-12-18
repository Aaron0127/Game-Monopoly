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
    public partial class UpgradForm : Form
    {
        EntryInfo entryInfo;
        Player player;

        public UpgradForm(EntryInfo entryInfo, Player player)
        {
            InitializeComponent();
            this.entryInfo = entryInfo;
            this.player = player;

            UpgradBox.AppendText("Would you like to Upgrade this propoty?");
        }

        /*If the player has sufficient fund, the process of upgrading new property 
        *can be done, otherwise the player cannot upgrad the property
        */
        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            if(player.GetFund() > entryInfo.OriginPrice)
            {
                player.Payment(entryInfo.OriginPrice);
                entryInfo.AddPropertyValue();
                this.Close();
            }
            else
            {
                InformationForm insufficentForm = new InformationForm(player, FormType.insufficientFund);
                insufficentForm.ShowDialog();
            }                
        }

        private void NotUpgradeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
