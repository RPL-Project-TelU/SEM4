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
            this.Kembali = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Handphone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Alamat = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Kembali
            // 
            this.Kembali.Location = new System.Drawing.Point(640, 373);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(94, 29);
            this.Kembali.TabIndex = 0;
            this.Kembali.Text = "Kembali";
            this.Kembali.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(49, 73);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(49, 20);
            this.Nama.TabIndex = 2;
            this.Nama.Text = "Nama";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(49, 126);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(75, 20);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Handphone
            // 
            this.Handphone.AutoSize = true;
            this.Handphone.Location = new System.Drawing.Point(49, 177);
            this.Handphone.Name = "Handphone";
            this.Handphone.Size = new System.Drawing.Size(87, 20);
            this.Handphone.TabIndex = 4;
            this.Handphone.Text = "Handphone";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(49, 229);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 271);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 10;
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(49, 278);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(57, 20);
            this.Alamat.TabIndex = 6;
            this.Alamat.Text = "Alamat";
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(609, 35);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(125, 62);
            this.Foto.TabIndex = 11;
            this.Foto.TabStop = false;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Handphone);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Kembali);
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Kembali;
        private TextBox textBox1;
        private Label Nama;
        private Label Username;
        private Label Handphone;
        private Label Email;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label Alamat;
        private PictureBox Foto;
    }
}