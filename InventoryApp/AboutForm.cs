//Tellon Smith
//Program: #7 - Inventory
//File: AboutForm.cs
//Shows Information about the Medical Supplies Inventory Program

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
    public partial class AboutForm : Form
    {
        //default constructor
        public AboutForm()
        {
            InitializeComponent();
        }

        //event when the ok botton is clicked
        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
