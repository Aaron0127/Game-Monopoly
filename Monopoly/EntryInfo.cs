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
        //TODO change some methods into Property
        public int OriginPrice { get; set; }
        public int WhichPlayer { get; set; }//0 for not purchased yet, 1 for playper 1, 2 for palyer 2;
        public string EntryName { get; set; }
        private int price;
        private Type type;

        /*construct an entry information 
         */
        public EntryInfo(int originPrice, string entryName, int price, Type type)
        {
            OriginPrice = originPrice;
            EntryName = entryName;
            this.price = price;
            this.type = type;
        }

        public int GetPrice()
        {
            return price;
        }

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
