//Tellon Smith
//Program: #7 - Inventory
//File: Record.cs
//Serializable class that stores an item's properties

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7_Inventory
{
    [Serializable]
    public class Record
    {
        //default constructor
        public Record()
        {
        }

        //parameterized constructor
        public Record(int id, string name, int qtyReq, int quantity, string practice)
        {
            this.ID = id;
            this.Name = name;
            this.QtyReq = qtyReq;
            this.Quantity = quantity;
            this.Practice = practice;
        }

        //override to ToString method
        public override string ToString()
        {
            return ID.ToString() + "\t" + Name + "\t\t\t\t" + QtyReq.ToString() + "\t"
                + Quantity.ToString();
        }

        //variables and properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int QtyReq { get; set; }
        public int Quantity { get; set; }
        public string Practice { get; set; }
    }
}
