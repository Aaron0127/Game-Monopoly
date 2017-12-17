using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class PropertyManagement : EntryInfo
    {
        private int PlayerID { get; set; }
        public string PropertyName { get; set; }
        public int MarketPrice { get; set; }
        public Type Type { get; }

        //public EntryInfo(int originPrice, string entryName, int price, Type type)
        public PropertyManagement(int playerID, string houseName, int currentPrice, Type type) 
            : base(playerID, houseName, currentPrice, type)
        {
            PlayerID = playerID;
            PropertyName = houseName;
            MarketPrice = currentPrice;
            Type = type;
        }
    }
}
