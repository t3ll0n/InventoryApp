namespace Program7_Inventory
{
    partial class EditInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInventoryForm));
            this.itemDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.qty_textBox = new System.Windows.Forms.TextBox();
            this.qtyRequired_textBox = new System.Windows.Forms.TextBox();
            this.itemName_textBox = new System.Windows.Forms.TextBox();
            this.itemID_textBox = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.quantityRequired_label = new System.Windows.Forms.Label();
            this.itemName_label = new System.Windows.Forms.Label();
            this.itemID_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.itemDetails_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemDetails_groupbox
            // 
            this.itemDetails_groupbox.Controls.Add(this.qty_textBox);
            this.itemDetails_groupbox.Controls.Add(this.qtyRequired_textBox);
            this.itemDetails_groupbox.Controls.Add(this.itemName_textBox);
            this.itemDetails_groupbox.Controls.Add(this.itemID_textBox);
            this.itemDetails_groupbox.Controls.Add(this.quantity_label);
            this.itemDetails_groupbox.Controls.Add(this.quantityRequired_label);
            this.itemDetails_groupbox.Controls.Add(this.itemName_label);
            this.itemDetails_groupbox.Controls.Add(this.itemID_label);
            this.itemDetails_groupbox.Location = new System.Drawing.Point(14, 18);
            this.itemDetails_groupbox.Name = "itemDetails_groupbox";
            this.itemDetails_groupbox.Size = new System.Drawing.Size(285, 168);
            this.itemDetails_groupbox.TabIndex = 0;
            this.itemDetails_groupbox.TabStop = false;
            this.itemDetails_groupbox.Text = "Item Details";
            // 
            // qty_textBox
            // 
            this.qty_textBox.Location = new System.Drawing.Point(94, 119);
            this.qty_textBox.Name = "qty_textBox";
            this.qty_textBox.Size = new System.Drawing.Size(120, 20);
            this.qty_textBox.TabIndex = 7;
            // 
            // qtyRequired_textBox
            // 
            this.qtyRequired_textBox.Location = new System.Drawing.Point(94, 86);
            this.qtyRequired_textBox.Name = "qtyRequired_textBox";
            this.qtyRequired_textBox.Size = new System.Drawing.Size(120, 20);
            this.qtyRequired_textBox.TabIndex = 6;
            // 
            // itemName_textBox
            // 
            this.itemName_textBox.Location = new System.Drawing.Point(94, 56);
            this.itemName_textBox.Name = "itemName_textBox";
            this.itemName_textBox.Size = new System.Drawing.Size(175, 20);
            this.itemName_textBox.TabIndex = 5;
            // 
            // itemID_textBox
            // 
            this.itemID_textBox.Location = new System.Drawing.Point(94, 28);
            this.itemID_textBox.Name = "itemID_textBox";
            this.itemID_textBox.Size = new System.Drawing.Size(175, 20);
            this.itemID_textBox.TabIndex = 4;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(22, 122);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(70, 13);
            this.quantity_label.TabIndex = 3;
            this.quantity_label.Text = "Qty on Hand:";
            // 
            // quantityRequired_label
            // 
            this.quantityRequired_label.AutoSize = true;
            this.quantityRequired_label.Location = new System.Drawing.Point(22, 89);
            this.quantityRequired_label.Name = "quantityRequired_label";
            this.quantityRequired_label.Size = new System.Drawing.Size(72, 13);
            this.quantityRequired_label.TabIndex = 2;
            this.quantityRequired_label.Text = "Qty Required:";
            // 
            // itemName_label
            // 
            this.itemName_label.AutoSize = true;
            this.itemName_label.Location = new System.Drawing.Point(22, 59);
            this.itemName_label.Name = "itemName_label";
            this.itemName_label.Size = new System.Drawing.Size(61, 13);
            this.itemName_label.TabIndex = 1;
            this.itemName_label.Text = "Item Name:";
            // 
            // itemID_label
            // 
            this.itemID_label.AutoSize = true;
            this.itemID_label.Location = new System.Drawing.Point(22, 31);
            this.itemID_label.Name = "itemID_label";
            this.itemID_label.Size = new System.Drawing.Size(44, 13);
            this.itemID_label.TabIndex = 0;
            this.itemID_label.Text = "Item ID:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(69, 201);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(178, 201);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // EditInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 235);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.itemDetails_groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditInventoryForm_FormClosing);
            this.itemDetails_groupbox.ResumeLayout(false);
            this.itemDetails_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemDetails_groupbox;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox qty_textBox;
        private System.Windows.Forms.TextBox qtyRequired_textBox;
        private System.Windows.Forms.TextBox itemName_textBox;
        private System.Windows.Forms.TextBox itemID_textBox;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label quantityRequired_label;
        private System.Windows.Forms.Label itemName_label;
        private System.Windows.Forms.Label itemID_label;
    }
}