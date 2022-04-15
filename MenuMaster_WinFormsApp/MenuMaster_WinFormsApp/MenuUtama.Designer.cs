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
            this.Profile = new System.Windows.Forms.Button();
            this.Keranjang = new System.Windows.Forms.Button();
            this.Pencarian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(12, 23);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(94, 29);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // Keranjang
            // 
            this.Keranjang.Location = new System.Drawing.Point(651, 374);
            this.Keranjang.Name = "Keranjang";
            this.Keranjang.Size = new System.Drawing.Size(94, 29);
            this.Keranjang.TabIndex = 2;
            this.Keranjang.Text = "Keranjang";
            this.Keranjang.UseVisualStyleBackColor = true;
            this.Keranjang.Click += new System.EventHandler(this.Keranjang_Click);
            // 
            // Pencarian
            // 
            this.Pencarian.Location = new System.Drawing.Point(459, 23);
            this.Pencarian.Name = "Pencarian";
            this.Pencarian.Size = new System.Drawing.Size(94, 29);
            this.Pencarian.TabIndex = 3;
            this.Pencarian.Text = "Pencarian";
            this.Pencarian.UseVisualStyleBackColor = true;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pencarian);
            this.Controls.Add(this.Keranjang);
            this.Controls.Add(this.Profile);
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Profile;
        private Button Keranjang;
        private Button Pencarian;
    }
}