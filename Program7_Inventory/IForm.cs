//Tellon Smith
//Program: #7 - Inventory
//File: IForm.cs
//Interface for MDIChild Forms

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7_Inventory
{
    internal interface IForm
    {
        //variables 
        bool NeedToSave { get; set; }

        //Purpose: updates/refreshes the form
        //Requires: none
        //Returns:
        void FormItemUpdate();

        //Purpose: delete selected items
        //Requires: none
        //Returns: none
        void FormItemDelete();

        //Purpose: saves new changes
        //Requires: none
        //Returns: none
        void FormItemSave();
    }
}
