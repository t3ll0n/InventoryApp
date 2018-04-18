namespace Program7_Inventory
{
    partial class InventoryDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryDataForm));
            this.info_label = new System.Windows.Forms.Label();
            this.practice_label = new System.Windows.Forms.Label();
            this.itemCount_label = new System.Windows.Forms.Label();
            this.items_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.Location = new System.Drawing.Point(38, 16);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(211, 16);
            this.info_label.TabIndex = 0;
            this.info_label.Text = "Below are supply item details";
            // 
            // practice_label
            // 
            this.practice_label.AutoSize = true;
            this.practice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practice_label.Location = new System.Drawing.Point(38, 38);
            this.practice_label.Name = "practice_label";
            this.practice_label.Size = new System.Drawing.Size(69, 16);
            this.practice_label.TabIndex = 1;
            this.practice_label.Text = "Practice:";
            // 
            // itemCount_label
            // 
            this.itemCount_label.AutoSize = true;
            this.itemCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCount_label.Location = new System.Drawing.Point(38, 57);
            this.itemCount_label.Name = "itemCount_label";
            this.itemCount_label.Size = new System.Drawing.Size(94, 16);
            this.itemCount_label.TabIndex = 2;
            this.itemCount_label.Text = "<item count>";
            // 
            // items_listBox
            // 
            this.items_listBox.FormattingEnabled = true;
            this.items_listBox.Items.AddRange(new object[] {
            "ID\tName\t\t\t\tQuantity Required\tQuantity"});
            this.items_listBox.Location = new System.Drawing.Point(12, 87);
            this.items_listBox.Name = "items_listBox";
            this.items_listBox.Size = new System.Drawing.Size(397, 121);
            this.items_listBox.TabIndex = 3;
            this.items_listBox.DoubleClick += new System.EventHandler(this.items_listBox_DoubleClick);
            this.items_listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.items_listBox_KeyDown);
            // 
            // InventoryDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 230);
            this.Controls.Add(this.items_listBox);
            this.Controls.Add(this.itemCount_label);
            this.Controls.Add(this.practice_label);
            this.Controls.Add(this.info_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Practice: <untitled>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryDataForm_FormClosing);
            this.Load += new System.EventHandler(this.InventoryDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label practice_label;
        private System.Windows.Forms.Label itemCount_label;
        private System.Windows.Forms.ListBox items_listBox;
    }
}