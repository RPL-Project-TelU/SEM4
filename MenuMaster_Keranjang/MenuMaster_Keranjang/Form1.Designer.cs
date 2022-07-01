namespace MenuMaster_Keranjang
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textOrderAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtMailingLabel = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(46, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 385);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart_SelectedIndexChanged);
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnExit);
            this.tabOrder.Controls.Add(this.btnNewOrder);
            this.tabOrder.Controls.Add(this.lblItemsOrdered);
            this.tabOrder.Controls.Add(this.btnAddToOrder);
            this.tabOrder.Controls.Add(this.dudProducts);
            this.tabOrder.Controls.Add(this.label1);
            this.tabOrder.Controls.Add(this.textOrderAddress);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(621, 352);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.Text = "Order Form";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(169, 307);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(130, 29);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.AutoSize = true;
            this.lblItemsOrdered.Location = new System.Drawing.Point(165, 283);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(128, 20);
            this.lblItemsOrdered.TabIndex = 4;
            this.lblItemsOrdered.Text = "Items Ordered: 0";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(159, 237);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(140, 34);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // dudProducts
            // 
            this.dudProducts.Location = new System.Drawing.Point(159, 193);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(148, 26);
            this.dudProducts.TabIndex = 2;
            this.dudProducts.SelectedItemChanged += new System.EventHandler(this.dudProducts_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address";
            // 
            // textOrderAddress
            // 
            this.textOrderAddress.Location = new System.Drawing.Point(22, 50);
            this.textOrderAddress.Multiline = true;
            this.textOrderAddress.Name = "textOrderAddress";
            this.textOrderAddress.Size = new System.Drawing.Size(408, 128);
            this.textOrderAddress.TabIndex = 0;
            this.textOrderAddress.TextChanged += new System.EventHandler(this.textOrderAddress_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalCost);
            this.tabPage2.Controls.Add(this.lstProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ShoppingCart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.RosyBrown;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(70, 209);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(265, 36);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total:";
            this.lblTotalCost.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(43, 42);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(317, 124);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtMailingLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(621, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailing Label";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtMailingLabel
            // 
            this.txtMailingLabel.AllowDrop = true;
            this.txtMailingLabel.Location = new System.Drawing.Point(32, 32);
            this.txtMailingLabel.Multiline = true;
            this.txtMailingLabel.Name = "txtMailingLabel";
            this.txtMailingLabel.Size = new System.Drawing.Size(427, 156);
            this.txtMailingLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DomainUpDown dudProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrderAddress;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtMailingLabel;
    }
}

