//Tellon Smith
//Program: #7 - Inventory
//File: LoginForm.cs
//Login screen that grants access to the program
//No validation of username and password.
//Keeps track of username

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
    public partial class LoginForm : Form
    {
        //default constructor
        public LoginForm()
        {
            InitializeComponent();
        }

        //variable
        MSIMainForm MSImain; //instance of main form

        //event when a login is successful (fired by the user control)
        private void loginScreen_UserControl_LoginSuccess(object sender, EventArgs e)
        {
            //new instance of the main form passing the username and the parent form as parameters
            MSImain = new MSIMainForm(loginScreen_UserControl.UserName.ToString(), this);
            this.Hide();
            MSImain.Show();
        }

        //event when the cancel button is clicked on the user contorl
        private void loginScreen_UserControl_CloseParent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //event when logout button is clicked on the main form (return to login screen)
        public void QImain_Logout(object sender, EventArgs e)
        {
            MSImain.Close();
            if (MSImain.OpenFiles.Count == 0)
            {
                loginScreen_UserControl.ClearFields();
                this.Show();
            }
        }
    }
}
