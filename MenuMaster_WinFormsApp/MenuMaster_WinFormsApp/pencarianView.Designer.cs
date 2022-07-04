namespace MenuMaster_WinFormsApp
{
    partial class pencarianView
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
            this.TombolCari = new System.Windows.Forms.Button();
            this.kolomPencarian = new System.Windows.Forms.TextBox();
            this.labelHasilPencarian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TombolCari
            // 
            this.TombolCari.Location = new System.Drawing.Point(601, 220);
            this.TombolCari.Name = "TombolCari";
            this.TombolCari.Size = new System.Drawing.Size(75, 23);
            this.TombolCari.TabIndex = 3;
            this.TombolCari.Text = "Cari";
            this.TombolCari.UseVisualStyleBackColor = true;
            this.TombolCari.Click += new System.EventHandler(this.TombolCari_Click);
            // 
            // kolomPencarian
            // 
            this.kolomPencarian.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kolomPencarian.Location = new System.Drawing.Point(232, 220);
            this.kolomPencarian.Name = "kolomPencarian";
            this.kolomPencarian.Size = new System.Drawing.Size(339, 23);
            this.kolomPencarian.TabIndex = 4;
            this.kolomPencarian.TextChanged += new System.EventHandler(this.kolomPencarian_TextChanged);
            // 
            // labelHasilPencarian
            // 
            this.labelHasilPencarian.AutoSize = true;
            this.labelHasilPencarian.Location = new System.Drawing.Point(232, 257);
            this.labelHasilPencarian.Name = "labelHasilPencarian";
            this.labelHasilPencarian.Size = new System.Drawing.Size(0, 15);
            this.labelHasilPencarian.TabIndex = 5;
            this.labelHasilPencarian.Click += new System.EventHandler(this.labelHasilPencarian_Click);
            // 
            // FiturPencarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 497);
            this.Controls.Add(this.labelHasilPencarian);
            this.Controls.Add(this.kolomPencarian);
            this.Controls.Add(this.TombolCari);
            this.Name = "FiturPencarian";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TombolCari;
        private TextBox kolomPencarian;
        private Label labelHasilPencarian;
    }
}