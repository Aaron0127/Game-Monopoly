using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Monopoly
{
    [Serializable]
    public class Player
    {
        public string PlayerName { get; set; }
        public bool IsJustOutOfJail { get; set; }//If player just relaesed from the jail, then true
        public int JailTerm { get; set; }//The number of turns that player left in staying in jail
        public int TotalMovement { get; set; }
        public int PlayerID { get; set; }
        public bool IsPlayerTurn { get; set; }
        private int fund = 3000;
        List<EntryInfo> listOfPropoty;//Stroe Player's properties' information 
        public Player(string nameOfPlayer, int id)
        {
            TotalMovement = 0;
            PlayerName = nameOfPlayer;
            PlayerID = id;
            IsJustOutOfJail = false;
            listOfPropoty = new List<EntryInfo>();
        }

        public int GetRollDiceResult()
        {
            Random random = new Random();
            return random.Next(1, 13);
        }

        public void RecieveFund(int money)
        {
            fund += money;
        }

        //Return available fund of the player
        public int GetFund()
        {
            return fund;
        }

        //pay certain amount of bill
        public void Payment(int bill) 
        {
            fund = fund - bill;
        }
        
        public void GoJail()
        {
            JailTerm = 2;
        }

        //reduce jail term by one
        public void ReduceJailTerm()
        {
            JailTerm -= 1;
            if (JailTerm == 0)
                IsJustOutOfJail = true;
        }

        public void AddProperty(EntryInfo propertyManagement)
        {
            listOfPropoty.Add(propertyManagement);
        }

        public List<EntryInfo> GetPropertyList()
        {
            return listOfPropoty;
        }
    }
}
