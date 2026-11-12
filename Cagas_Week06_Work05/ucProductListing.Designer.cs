namespace Cagas_Week06_Work05
{
    partial class ucProductListing
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
            this.grpboxItemDes = new System.Windows.Forms.GroupBox();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxAmount = new System.Windows.Forms.ComboBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.grpboxItemDes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxItemDes
            // 
            this.grpboxItemDes.BackColor = System.Drawing.Color.Silver;
            this.grpboxItemDes.Controls.Add(this.lbxItems);
            this.grpboxItemDes.Controls.Add(this.btnDelete);
            this.grpboxItemDes.Controls.Add(this.btnAdd);
            this.grpboxItemDes.Controls.Add(this.comboBoxAmount);
            this.grpboxItemDes.Controls.Add(this.txtamount);
            this.grpboxItemDes.Controls.Add(this.txtdescription);
            this.grpboxItemDes.Controls.Add(this.lblamount);
            this.grpboxItemDes.Controls.Add(this.lbldescription);
            this.grpboxItemDes.Location = new System.Drawing.Point(12, 12);
            this.grpboxItemDes.Name = "grpboxItemDes";
            this.grpboxItemDes.Size = new System.Drawing.Size(625, 285);
            this.grpboxItemDes.TabIndex = 1;
            this.grpboxItemDes.TabStop = false;
            this.grpboxItemDes.Text = "Item Description";
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(44, 109);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(542, 147);
            this.lbxItems.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(496, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Location = new System.Drawing.Point(496, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // comboBoxAmount
            // 
            this.comboBoxAmount.FormattingEnabled = true;
            this.comboBoxAmount.Location = new System.Drawing.Point(254, 75);
            this.comboBoxAmount.Name = "comboBoxAmount";
            this.comboBoxAmount.Size = new System.Drawing.Size(126, 21);
            this.comboBoxAmount.TabIndex = 5;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(122, 76);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(126, 20);
            this.txtamount.TabIndex = 4;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(122, 50);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(359, 20);
            this.txtdescription.TabIndex = 3;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(55, 78);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(43, 13);
            this.lblamount.TabIndex = 1;
            this.lblamount.Text = "Amount";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(52, 47);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(60, 13);
            this.lbldescription.TabIndex = 0;
            this.lbldescription.Text = "Description";
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpboxItemDes);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(663, 371);
            this.Load += new System.EventHandler(this.ucProductListing_Load);
            this.grpboxItemDes.ResumeLayout(false);
            this.grpboxItemDes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxItemDes;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxAmount;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtdescription;
    }
}