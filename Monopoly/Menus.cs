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

namespace Monopoly
{
    public partial class Menus : Form
    {
        Player player1;
        Player player2;
        
        public Menus()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameInterface gameInterface = new GameInterface();
            this.Visible = false;
            gameInterface.ShowDialog();
            this.Visible = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadGame_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream input = File.OpenRead("Player.dat"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    player1 = (Player)formatter.Deserialize(input);
                    player2 = (Player)formatter.Deserialize(input);
                }                                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GameInterface gameInterface = new GameInterface(player1, player2);
            this.Visible = false;
            gameInterface.ShowDialog();
            this.Visible = true;           
        }
    }
}
