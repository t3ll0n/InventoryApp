//-----------------------------------------------------------------------------------------------------
//
// Name: Tellon Smith
//
// Course: CS 4143 - Contemporary Programming Lang, Fall 16, Dr. Stringfellow
//
// Program Assignment : #7
//
// Due Date: Tuesday, Dec. 6th, 2016, 11AM
//
// Purpose: This program is a Medical Supplies Inventory program which demonstrates the use of menus,
//          list boxes, and MDI.
//
//-----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7_Inventory
{
    public partial class MSIMainForm : Form
    {
        //default constructor
        public MSIMainForm()
        {
            InitializeComponent();
        }

        //parameterized constructor
        public MSIMainForm(string username, LoginForm login)
        {
            InitializeComponent();
            UserName = username;
            this.login = login;
        }

        //variables
        string userName;
        private InventoryDataForm activeChild;
        private LoginForm login;
        bool closeAll = true;
        private bool logOut = false;
        public List<string> OpenFiles = new List<string>();

        //property UserName - gets and sets userName 
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        //property CloseAll - gets and sets closeAll 
        public bool CloseAll
        {
            get { return closeAll; }
            set { closeAll = value; }
        }

        //Purpose: checks to see which child is active
        //Requires: none
        //Returns: none
        private void CheckActiveChild()
        {
            activeChild = (InventoryDataForm)this.ActiveMdiChild;
        }

        //Purpose: get child count
        //Requires: none
        //Returns: none
        private int GetMDIChildCount()
        {
            int count = 0;
            foreach (object frm_loopVariable in this.MdiChildren)
            {
                Form frm = (Form)frm_loopVariable;
                if ((frm.Visible))
                    count++;
            }
            return count;
        }

        //Purpose: removes closed files from the list of open files
        //Requires: none
        //Returns: none
        public void RemoveFileFromList(string file)
        {
            OpenFiles.Remove(file);
        }

        //event when open menu is clicked
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create and show dialog box enabling user to open file         
            DialogResult result; //result of OpenFileDialog
            string fileName; //name of file containing data

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.InitialDirectory = Directory.GetCurrentDirectory();
                //dialog filers for only "inv" files
                fileChooser.Filter = "inv files (*.inv)|*.inv|All files (*.*)|*.*";
                fileChooser.RestoreDirectory = true;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; //get specified name
            }

            //ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                //show error if user specified invalid file
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (OpenFiles.Contains(fileName))
                {
                    MessageBox.Show(this, "File is already open", "Quick Inventory",
                     MessageBoxButtons.OK, MessageBoxIcon.None,
                     MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //open new MDI child 
                    InventoryDataForm newMDIChildData = new InventoryDataForm(fileName, false, this);
                    //add file to list
                    OpenFiles.Add(fileName);
                    //set the parent Form of the child window.
                    newMDIChildData.MdiParent = this;
                    //display the new form.
                    newMDIChildData.Show();
                }
            }
        }

        //event when the new menu item is clicked
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create and show dialog box enabling user to open file         
            DialogResult result; //result of SaveFileDialog
            string fileName; //name of file containing data

            using (SaveFileDialog newfile = new SaveFileDialog())
            {
                newfile.InitialDirectory = Directory.GetCurrentDirectory();
                //dialog filers for only "inv" files
                newfile.Filter = "inv files (*.inv)|*.inv|All files (*.*)|*.*";
                newfile.RestoreDirectory = true;
                result = newfile.ShowDialog();
                fileName = newfile.FileName; //get specified name
            }

            //ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                //show error if user specified invalid file
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //Open new MDI Child 
                    InventoryDataForm newMDIChildData = new InventoryDataForm(fileName, true, this);
                    //add file to list
                    OpenFiles.Add(fileName);
                    //set the parent Form of the child window.
                    newMDIChildData.MdiParent = this;
                    //display the new form.
                    newMDIChildData.Show();
                }
            }
        }

        //even when the save menu item is clicked
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   //using the interface, call child method
                ((IForm)this.ActiveMdiChild).FormItemSave();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //even when the logout menu item is clicked
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOut = true;
            CloseAll = true;
            //call the logout functionin in the parent form
            login.QImain_Logout(this, e);
        }

        //event when the exit menu item is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exit application
        }

        //event when the insert menu item is clicked
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //determine the active child form.
            CheckActiveChild();

            //if there is an active child form, find the active control
            if (activeChild != null)
            {
                try
                {
                    //open new blank edit item  
                    EditInventoryForm newInventory =
                        new EditInventoryForm((InventoryDataForm)activeChild);
                    //display the new form.
                    newInventory.ShowDialog();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        //event when the delete menu item is clicked
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //determine the active child form.
            CheckActiveChild();

            //if there is an active child form, find the active control
            if (activeChild != null)
            {
                try
                {   //calls active child form delete item function 
                    ((IForm)this.ActiveMdiChild).FormItemDelete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        //event when the update menu item is selected
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //determine the active child form.
            CheckActiveChild();

            //if there is an active child form, find the active control
            if (activeChild != null)
            {
                try
                {
                    ((IForm)this.ActiveMdiChild).FormItemUpdate();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        //event when the about menu item is clicked
        private void aboutMedicalSuppliesInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        //event when the form is closed
        private void MSIForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if form is asked to close and logOut 
            //is false, then it will exit application
            if (!logOut)
                Application.Exit();
        }

        //event when the form is closing
        private void MSIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseAll)
                e.Cancel = true;
        }

        //event when the form is loading
        private void MSIForm_Load(object sender, EventArgs e)
        {
            //show the current username in the strip status
            MSI_toolStripStatusLabel.Text = "User: " + UserName.ToString();
            //disable contriols 
            saveToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
        }

        //event when mdi child is activated
        private void MSIForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (GetMDIChildCount() > 0)
            {
                editToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
            }
        }
    }
}
