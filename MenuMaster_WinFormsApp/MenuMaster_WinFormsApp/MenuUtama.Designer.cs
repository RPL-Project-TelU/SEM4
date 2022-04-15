namespace MenuMaster_WinFormsApp
{
    partial class MenuUtama
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabOrder = new System.Windows.Forms.TabControl();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.IstProducts = new System.Windows.Forms.ListBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbltotal);
            this.tabPage2.Controls.Add(this.IstProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ShoppingCart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewOrder);
            this.tabPage1.Controls.Add(this.lblItemsOrdered);
            this.tabPage1.Controls.Add(this.btnAddToOrder);
            this.tabPage1.Controls.Add(this.dudProducts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtOrderAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabOrder
            // 
            this.TabOrder.Controls.Add(this.tabPage1);
            this.TabOrder.Controls.Add(this.tabPage2);
            this.TabOrder.Location = new System.Drawing.Point(35, 34);
            this.TabOrder.Name = "TabOrder";
            this.TabOrder.SelectedIndex = 0;
            this.TabOrder.Size = new System.Drawing.Size(753, 404);
            this.TabOrder.TabIndex = 0;
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(50, 41);
            this.txtOrderAddress.Multiline = true;
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(543, 128);
            this.txtOrderAddress.TabIndex = 0;
            this.txtOrderAddress.TextChanged += new System.EventHandler(this.txtOrderAddress_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dudProducts
            // 
            this.dudProducts.Location = new System.Drawing.Point(212, 175);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(180, 31);
            this.dudProducts.TabIndex = 2;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToOrder.Location = new System.Drawing.Point(231, 212);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(129, 28);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsOrdered.Location = new System.Drawing.Point(221, 243);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(88, 38);
            this.lblItemsOrdered.TabIndex = 4;
            this.lblItemsOrdered.Text = "Items Ordered: 0";
            this.lblItemsOrdered.Click += new System.EventHandler(this.lblItemsOrdered_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(231, 292);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(112, 34);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // IstProducts
            // 
            this.IstProducts.FormattingEnabled = true;
            this.IstProducts.ItemHeight = 25;
            this.IstProducts.Location = new System.Drawing.Point(78, 33);
            this.IstProducts.Name = "IstProducts";
            this.IstProducts.Size = new System.Drawing.Size(499, 179);
            this.IstProducts.TabIndex = 0;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.Orange;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltotal.Location = new System.Drawing.Point(78, 245);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(499, 38);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total : ";
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabOrder);
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private Label lbltotal;
        private ListBox IstProducts;
        private TabPage tabPage1;
        private Button btnNewOrder;
        private Label lblItemsOrdered;
        private Button btnAddToOrder;
        private DomainUpDown dudProducts;
        private Label label1;
        private TextBox txtOrderAddress;
        private TabControl TabOrder;
    }
}