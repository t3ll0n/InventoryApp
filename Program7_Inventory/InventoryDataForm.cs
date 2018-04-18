//Tellon Smith
//Program: #7 - Inventory
//File: InventoryDataForm.cs
//MDI Child Form - Shows and allows manipulation of Iventory
//                 items stored in the list box

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7_Inventory
{
    public partial class InventoryDataForm : Form, IForm
    {
        //default constructor
        public InventoryDataForm()
        {
            InitializeComponent();
        }

        //paramterized constructor 
        public InventoryDataForm(string file, bool newItem, MSIMainForm parent)
        {
            InitializeComponent();
            MSImain = parent;
            fileName = file;
            practice = Path.GetFileNameWithoutExtension(fileName);
            newInventory = newItem;
            this.Text = "Practice: " + practice;
        }

        //Variables
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream dataFile;
        private string fileName;
        private Record record;
        private EditInventoryForm editInventory;
        private MSIMainForm MSImain;
        bool updateControl;
        private int lastItemNumber;
        private string practice;
        private bool newInventory = false;
        private bool needToSave = false;


        //property LastItemNumber: gets and sets lastItemNumber 
        public int LastItemNumber
        {
            get { return lastItemNumber; }
            set { lastItemNumber = value; }
        }
        //property UpdateControl: gets and sets updateControl
        public bool UpdateControl
        {
            get { return updateControl; }
            set { updateControl = value; }
        }
        //property Record: gets and sets record
        public Record Record
        {
            get { return record; }
            set { record = value; }
        }

        //property NeedToSave: gets and sets needToSave
        public bool NeedToSave
        {
            get { return needToSave; }
            set { needToSave = value; }
        }

        //Purpose: Opens new form to edit/update exiting item and save changes
        //Requires: none
        //Returns: changes to the listbox
        private void UpdateItem()
        {
            UpdateControl = false;
            int index = items_listBox.SelectedIndex;
            if (index > 0)
            {
                string inputRecord = items_listBox.SelectedItem.ToString();
                string[] inputFields; //stores each data piece
                inputFields = inputRecord.Split('\t');
                Record = new Record(Convert.ToInt32(inputFields[0]), inputFields[1],
                  Convert.ToInt32(inputFields[5]), Convert.ToInt32(inputFields[6]), practice);
                editInventory = new EditInventoryForm(this, record); //new form
                editInventory.ShowDialog();
                UpdateForm();
            }
        }

        //Purpose: Save items in listbox items to file
        //Requires: none
        //Returns: file with saved changes
        private void SaveItem()
        {
            //create data file (clears the original contents)
            dataFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            dataFile.Close();
            //always use the file to be appended
            dataFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);

            foreach (object item in items_listBox.Items)
            {
                // Skip the header
                if (item.ToString() != "ID\tName\t\t\t\tQuantity Required\tQuantity")
                {
                    string inputRecord = item.ToString();
                    string[] inputFields; //stores data piece
                    inputFields = inputRecord.Split('\t');
                    Record = new Record(Convert.ToInt32(inputFields[0]), inputFields[1],
                      Convert.ToInt32(inputFields[5]),
                      Convert.ToInt32(inputFields[6]), practice);
                    formatter.Serialize(dataFile, Record);
                }
            }
            NeedToSave = false;
            UpdateForm();
            dataFile.Close();
        }

        //Purpose: refreshes and updates form controls
        //Requires: none
        //Returns: updated form controls
        private void UpdateForm()
        {
            //set up labels
            if (NeedToSave)
                this.Text = "Practice: " + practice + "*";
            else
                this.Text = "Practice: " + practice;
            practice_label.Text = practice;
            itemCount_label.Text = "There are " + (items_listBox.Items.Count - 1).ToString()
                + " supply items in this practice";
            this.Invalidate();
        }

        //Purpose: deletes selected item from list box
        //Requires: none
        //Returns: none
        private void DeleteItem()
        {
            int index = items_listBox.SelectedIndex;
            if (index > 0)
            {
                DialogResult delete = MessageBox.Show(this, "Are you sure you want to delete this item?"
                    , "Confirm Delete!", MessageBoxButtons.YesNo);
                if (delete == DialogResult.Yes)
                {
                    items_listBox.Items.RemoveAt(index);
                    this.UpdateForm();
                }
            }
            NeedToSave = true;
            //sort list box contents by item ID 
            SortListBox(items_listBox);
            UpdateForm();
        }

        //Purpose: updates the list box
        //Requires: none
        //Returns: updated list box
        public void UpdateList(Record record)
        {
            items_listBox.Items[items_listBox.SelectedIndex] = record.ToString();
            //sort list box contents by item ID 
            SortListBox(items_listBox);
            UpdateForm();
        }

        //Purpose: adds new item to list box
        //Requires: none
        //Returns: list box with new item appended
        public void AddToList(Record record)
        {
            items_listBox.Items.Add(record.ToString());
            LastItemNumber = record.ID;
            NeedToSave = true;
            //sort list box contents by item ID
            SortListBox(items_listBox);
            UpdateForm();
        }

        //Purpose:  sort list box in ascending order
        //Requires: none
        //Returns: list box sorted in ascending order
        private void SortListBox(ListBox list)
        {
            SortedList lListItems = new SortedList();


            //add list box items to SortedList 
            foreach (object lItem in list.Items)
            {
                //skip the header
                if (lItem.ToString() != "ID\tName\t\t\t\tQuantity Required\tQuantity")
                    lListItems.Add(lItem, lItem);
            }
            //clear list box 
            list.Items.Clear();
            list.Items.Add("ID\tName\t\t\t\tQuantity Required\tQuantity");

            //add sorted items to list box 
            for (int i = 0; i < lListItems.Count; i++)
            {
                list.Items.Add(lListItems[lListItems.GetKey(i)]);
            }
        }

        //implemtation of interface method
        public void FormItemUpdate()
        {
            UpdateItem();
        }

        //implemtation of interface method 
        public void FormItemDelete()
        {
            DeleteItem();
        }

        //implemtation of interface method
        public void FormItemSave()
        {
            SaveItem();
        }

        //event when form loads
        private void InventoryDataForm_Load(object sender, EventArgs e)
        {
            //create FileStream to obtain read access to file
            if (newInventory == false)
            {
                //new file stream 
                dataFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
                while (dataFile.Position != dataFile.Length)
                {
                    //dead in data 
                    Record = (Record)formatter.Deserialize(dataFile);
                    //add item to list box
                    items_listBox.Items.Add(Record.ToString());
                }
                if (Record != null)
                {
                    LastItemNumber = Record.ID;
                }
                dataFile.Close(); //close file Stream
            }
            this.UpdateForm();
        }

        //event when list box is double-clicked
        private void items_listBox_DoubleClick(object sender, EventArgs e)
        {
            UpdateItem();
        }

        //event when keydown on list box
        private void items_listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteItem();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateItem();
            }
        }

        //event when from is closing
        private void InventoryDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NeedToSave)
            {
                DialogResult results = MessageBox.Show(this, "Do you want to save changes to "
                    + practice + ".inv?", "Quick Inventory",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1);

                if (results == DialogResult.Yes)
                {
                    SaveItem();
                    NeedToSave = false;
                    MSImain.RemoveFileFromList(fileName);
                    MSImain.CloseAll = true;
                }
                else if (results == DialogResult.Cancel)
                {
                    e.Cancel = true; //cancel closing 
                    MSImain.CloseAll = false;
                }
                else if (results == DialogResult.No)
                {
                    NeedToSave = false;
                    MSImain.RemoveFileFromList(fileName);
                    MSImain.CloseAll = true;
                }
            }
            else
            {
                MSImain.RemoveFileFromList(fileName);
            }
        }
    }
}
