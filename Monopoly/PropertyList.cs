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
    public partial class PropertyList : Form
    {
        public PropertyList(List<EntryInfo> player1List, List<EntryInfo> player2List)
        {
            InitializeComponent();
            propertyListP1.ScrollBars = ScrollBars.Vertical;
            propertyListP2.ScrollBars = ScrollBars.Vertical;

            propertyListP1.AppendText("Player 1 has folllowing property: \n");
            propertyListP1.AppendText("\n");
            foreach (var property in player1List)
            {
                string nameMessage = "Property Name: " + property.EntryName + "\n";
                propertyListP1.AppendText(nameMessage);
                string priceMessage = "Current Market Price: " + property.GetPrice() + "\n";
                propertyListP1.AppendText(priceMessage);
                propertyListP1.AppendText("\n");
            }

            propertyListP2.AppendText("Player 2 has folllowing property: \n");
            propertyListP2.AppendText("\n");
            foreach (var property in player2List)
            {                
                string nameMessage = "Property Name: " + property.EntryName + "\n";
                propertyListP2.AppendText(nameMessage);
                string priceMessage = "Current Market Price: " + property.GetPrice() + "\n";
                propertyListP2.AppendText(priceMessage);
                propertyListP2.AppendText("\n");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
