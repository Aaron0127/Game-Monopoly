﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Monopoly
{
    public enum Type
    {
        go, property, incomeTax, chance, goJail, chest,
        luxuryTax, visitJail, freeParking
    };

    //GameBoardInfo class is used to contain the information of each entry on the game board 
    [Serializable]
    public class GameBoardInfo
    {
        public static List<EntryInfo> list = new List<EntryInfo>();
        public GameBoardInfo()
        {
            InitalEntryInfo();
        }

        private void InitalEntryInfo()
        {
            //EntryInfo(int id, string entryName, int price, Type type)
            
            //bottom of the Board
            //index from 0 to 10(11 entries)
            list.Add(new EntryInfo(0, "GO", 0, Type.go, null));
            list.Add(new EntryInfo(60, "MEDITERANEAN AVENUE", 60, Type.property, null));//1
            list.Add(new EntryInfo(0, "COMMUNITY CHEST", 0, Type.chest, null));
            list.Add(new EntryInfo(60, "BALTI AVENUE", 60, Type.property, null));//3
            list.Add(new EntryInfo(0, "INCOME TAX", 0, Type.incomeTax, null));
            list.Add(new EntryInfo(200, "READING RAILROAD", 200, Type.property, null));//5
            list.Add(new EntryInfo(100, "ORIENTAL AVENUE", 100, Type.property, null));//6
            list.Add(new EntryInfo(0, "CHANCE", 0, Type.chance, null));
            list.Add(new EntryInfo(100, "VERMONT AVENUE", 100, Type.property, null));//8
            list.Add(new EntryInfo(120, "COMMECTICUT AVENUE", 120, Type.property, null));//9
            list.Add(new EntryInfo(0, "VISITING JAIL", 0, Type.visitJail, null));

            //left of the Board
            //index from 11 to 20
            list.Add(new EntryInfo(140, "ST.CHARLES PLACE", 140, Type.property, null));//11
            list.Add(new EntryInfo(150, "ELECTRIC COMPANY", 150, Type.property, null));//12
            list.Add(new EntryInfo(140, "STATES AVENUE", 140, Type.property, null));//13
            list.Add(new EntryInfo(160, "VIRGINIA AVENUE", 160, Type.property, null));//14
            list.Add(new EntryInfo(200, "PENNSYLVANIA RAILROAD", 200, Type.property, null));//15
            list.Add(new EntryInfo(180, "ST.JAMES PLACE", 180, Type.property, null));//16
            list.Add(new EntryInfo(0, "COMMUNITY CHEST", 0, Type.chest, null));
            list.Add(new EntryInfo(180, "TENNESSEE AVENUE", 180, Type.property, null));//18
            list.Add(new EntryInfo(200, "NEW YORK AVENUE", 200, Type.property, null));//19
            list.Add(new EntryInfo(0, "FREE PARKING", 0, Type.freeParking, null));

            //top of the Board
            //index from 21 to 30 
            list.Add(new EntryInfo(220, "KENTUCKY AVENUE",220, Type.property, null));//21
            list.Add(new EntryInfo(0, "CHANCE", 0, Type.chance, null));
            list.Add(new EntryInfo(220, "INDIANA AVENUE", 220, Type.property, null));//23
            list.Add(new EntryInfo(240, "ILLINOIS AVENUE", 240, Type.property, null));//24
            list.Add(new EntryInfo(200, "B&O RAILROAD", 200, Type.property, null));//25
            list.Add(new EntryInfo(260, "ATLANTIC AVENUE", 260, Type.property, null));//26
            list.Add(new EntryInfo(260, "VENTINOR AVENUE", 260, Type.property, null));//27
            list.Add(new EntryInfo(150, "WATER WORKS", 150, Type.property, null));//28
            list.Add(new EntryInfo(280, "MARVIN GRADENS", 280, Type.property, null));//29
            list.Add(new EntryInfo(0, "GO TO JAIL", 0, Type.goJail, null));

            //right of the Board
            //index from 31 to 39
            list.Add(new EntryInfo(300, "PACIFIC AVENUE", 300, Type.property, null));//31
            list.Add(new EntryInfo(300, "NORTH CAROLINA", 300, Type.property, null));//32
            list.Add(new EntryInfo(0, "COMMUNITY CHEST", 0, Type.chest, null));
            list.Add(new EntryInfo(320, "PENNSYLVANIA AVENUE", 320, Type.property, null));//34
            list.Add(new EntryInfo(200, "SHORT LINE", 200, Type.property, null));//35
            list.Add(new EntryInfo(0, "CHANCE", 0, Type.chance, null));
            list.Add(new EntryInfo(350, "PARK PLACE", 350, Type.property, null));//37
            list.Add(new EntryInfo(0, "LUXURY TAX", 0, Type.luxuryTax, null));
            list.Add(new EntryInfo(400, "BOARDWALK", 400, Type.property, null));//39
        }
    }
}