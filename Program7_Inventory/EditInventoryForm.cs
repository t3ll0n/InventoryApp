//Tellon Smith
//Program: #7 - Inventory
//File: EditInventoryForm.cs
//Form that allows the user to edit or create a new item

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7_Inventory
{
    public partial class EditInventoryForm : Form
    {
        //parameterized constructor 1
        public EditInventoryForm(InventoryDataForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            itemID_textBox.Text = (parentForm.LastItemNumber + 1).ToString();
            insert = true;
            this.Text = "New Item";
        }

        //parameterized constructor 2:
        public EditInventoryForm(InventoryDataForm parent, Record rec)
        {
            InitializeComponent();
            record = rec;
            parentForm = parent;
            itemID_textBox.Text = record.ID.ToString();
            itemName_textBox.Text = record.Name;
            qtyRequired_textBox.Text = record.QtyReq.ToString();
            qty_textBox.Text = record.Quantity.ToString();
        }

        //varables
        private Record record;
        private bool insert = false;
        private InventoryDataForm parentForm;

        //event when cancel button is clicked
        private void cancel_button_Click(object sender, EventArgs e)
        {
            ok_button.Enabled = false;
            this.Close();
        }

        //event when ok button is clicked
        private void ok_button_Click(object sender, EventArgs e)
        {
            if (itemID_textBox.Text != "" && itemName_textBox.Text != "" && qtyRequired_textBox.Text
                != "" && qty_textBox.Text != "")
            {
                try
                {
                    //save data then close
                    record = new Record();
                    record.ID = Convert.ToInt32(itemID_textBox.Text);
                    record.Name = itemName_textBox.Text;
                    record.QtyReq = Convert.ToInt32(qtyRequired_textBox.Text);
                    record.Quantity = Convert.ToInt32(qty_textBox.Text);
                    record.Practice = parentForm.Text;

                    if (insert == true)
                    {
                        parentForm.AddToList(record);
                    }
                    else
                    {
                        parentForm.UpdateList(record);
                    }

                    ok_button.Enabled = false;
                    parentForm.NeedToSave = true;
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            } // end if 
            else
            {
                MessageBox.Show(this, "One or More Fields Are Empty", "Medical Supplies Inventory",
                     MessageBoxButtons.OK, MessageBoxIcon.None,
                     MessageBoxDefaultButton.Button1);
            }
        }

        //event when form is closing
        private void EditInventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ok_button.Enabled == true)
            {
                DialogResult results = MessageBox.Show(this, "Do you want to save the changes?", 
                    "Medical Supplies Inventory", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button1);

                if (results == DialogResult.Yes)
                {
                    ok_button_Click(this, e);
                }
                else if (results == DialogResult.No)
                {
                    cancel_button_Click(this, e);
                }
                else
                {
                    e.Cancel = true; //cancel closing
                }
            }
        }
    }
}