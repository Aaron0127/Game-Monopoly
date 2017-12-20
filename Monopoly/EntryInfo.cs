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
    public class EntryInfo
    {
        public int OriginPrice { get; set; }
        public int WhichPlayer { get; set; }//0 for not purchased yet, 1 for playper 1, 2 for palyer 2;
        public string EntryName { get; set; }
        public string Owner { get; set; }
        private int price;
        private Type type;

        /*construct an entry information 
         */
        public EntryInfo(int originPrice, string entryName, int price, Type type, string owner)
        {
            OriginPrice = originPrice;
            EntryName = entryName;
            this.price = price;
            this.type = type;
            Owner = owner;
        }

        public int GetPrice()
        {
            return price;
        }

        //Add property market value
        public void AddPropertyValue()
        {
            price += price;
        }

        public Type GetEnumType()
        {
            return type;
        }
    }
}
