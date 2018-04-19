//Tellon Smith
//Program: #7 - Inventory
//File: LoginPasswordUserControl.cs
//Login screen User Control.
//Allows access to the application When provided with a user name
//NOTE: Accepts any password

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7_Inventory
{
    public partial class LoginScreen_UserControl : UserControl
    {
        //default constructor
        public LoginScreen_UserControl()
        {
            InitializeComponent();
        }

        //varables and delegates
        private string userName;
        private bool close = false;
        public event EventHandler LoginSuccess;
        public event EventHandler LoginFailed;
        public event EventHandler CloseParent;

        //property UserName - gets and sets username
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        //property Close - gets and sets close (bool)
        public bool Close
        {
            get { return close; }
            set { close = value; }
        }

        //Purpose: checks if the user name text box is empty
        //Requires: none
        //Returns: true if not empty, else false
        private bool LoginCheck()
        {
            if (username_textBox.TextLength > 0)
                return true;
            else
                return false;
        }

        //Purpose: clears the username and password text box
        //Requires: none
        //Returns: none
        public void ClearFields()
        {
            username_textBox.Text = null;
            password_textBox.Text = null;
        }

        //event when the ok button is clicked
        private void ok_button_Click(object sender, EventArgs e)
        {
            UserName = username_textBox.Text.ToString();

            if (LoginCheck())
            {
                //notify subscribers for the LoginSuccess event
                if (LoginSuccess != null)
                {
                    LoginSuccess(this, new System.EventArgs());
                }
            }
            else
            {
                //notify subscribers for the LoginFailed event
                if (LoginFailed != null)
                {
                    LoginFailed(this, new System.EventArgs());
                }
            }
        }

        //event when the cancel button is clicked
        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (CloseParent != null)
            {
                Close = true;
                CloseParent(this, new System.EventArgs());
            }
        }

        //event when the text is changed in the user name text box
        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            if (username_textBox.TextLength > 0)
                ok_button.Enabled = true;
            else
                ok_button.Enabled = false;
        }

        //event when the enter key is pressed in the user name text box
        private void username_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                ok_button_Click(this, e);
            }
        }

        //event when the enter key is pressed in the password text box
        private void password_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ok_button_Click(this, e);
            }
        }
    }
}
