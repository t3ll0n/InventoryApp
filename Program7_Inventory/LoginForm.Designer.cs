namespace Program7_Inventory
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginScreen_UserControl = new Program7_Inventory.LoginScreen_UserControl();
            this.SuspendLayout();
            // 
            // loginScreen_UserControl
            // 
            this.loginScreen_UserControl.Close = false;
            this.loginScreen_UserControl.Location = new System.Drawing.Point(2, 1);
            this.loginScreen_UserControl.Name = "loginScreen_UserControl";
            this.loginScreen_UserControl.Size = new System.Drawing.Size(371, 137);
            this.loginScreen_UserControl.TabIndex = 0;
            this.loginScreen_UserControl.UserName = null;
            this.loginScreen_UserControl.LoginSuccess += new System.EventHandler(this.loginScreen_UserControl_LoginSuccess);
            this.loginScreen_UserControl.CloseParent += new System.EventHandler(this.loginScreen_UserControl_CloseParent);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 139);
            this.Controls.Add(this.loginScreen_UserControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Supplies Inventory - Login";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginScreen_UserControl loginScreen_UserControl;
    }
}