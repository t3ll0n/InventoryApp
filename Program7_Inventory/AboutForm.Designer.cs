namespace Program7_Inventory
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.about_pictureBox = new System.Windows.Forms.PictureBox();
            this.about_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.about_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // about_pictureBox
            // 
            this.about_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("about_pictureBox.Image")));
            this.about_pictureBox.Location = new System.Drawing.Point(101, 12);
            this.about_pictureBox.Name = "about_pictureBox";
            this.about_pictureBox.Size = new System.Drawing.Size(87, 74);
            this.about_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.about_pictureBox.TabIndex = 0;
            this.about_pictureBox.TabStop = false;
            // 
            // about_label
            // 
            this.about_label.AutoSize = true;
            this.about_label.Location = new System.Drawing.Point(74, 96);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(134, 39);
            this.about_label.TabIndex = 1;
            this.about_label.Text = "Medical Supplies Inventory\r\nVersion: 1.0\r\nDevelopver: Tellon Smith";
            this.about_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(103, 149);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 194);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.about_label);
            this.Controls.Add(this.about_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medical Supplies Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.about_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox about_pictureBox;
        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.Button ok_button;
    }
}