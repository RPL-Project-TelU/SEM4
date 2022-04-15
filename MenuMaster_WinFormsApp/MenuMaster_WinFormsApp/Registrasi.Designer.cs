namespace MenuMaster_WinFormsApp
{
    partial class Registrasi
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
            this.label_Nama = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label_NaAw = new System.Windows.Forms.Label();
            this.txt_NamaAwal = new System.Windows.Forms.TextBox();
            this.label_NaAk = new System.Windows.Forms.Label();
            this.txt_NamaAkhir = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label_ConfirmPass = new System.Windows.Forms.Label();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.btn_registrasi = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Nama
            // 
            this.label_Nama.AutoSize = true;
            this.label_Nama.Location = new System.Drawing.Point(32, 34);
            this.label_Nama.Name = "label_Nama";
            this.label_Nama.Size = new System.Drawing.Size(60, 15);
            this.label_Nama.TabIndex = 0;
            this.label_Nama.Text = "Username";
            this.label_Nama.Click += new System.EventHandler(this.label_Nama_Click_1);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(114, 31);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(138, 23);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Nama_TextChanged);
            // 
            // label_NaAw
            // 
            this.label_NaAw.AutoSize = true;
            this.label_NaAw.Location = new System.Drawing.Point(15, 71);
            this.label_NaAw.Name = "label_NaAw";
            this.label_NaAw.Size = new System.Drawing.Size(68, 15);
            this.label_NaAw.TabIndex = 2;
            this.label_NaAw.Text = "Nama Awal";
            this.label_NaAw.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_NamaAwal
            // 
            this.txt_NamaAwal.Location = new System.Drawing.Point(114, 68);
            this.txt_NamaAwal.Name = "txt_NamaAwal";
            this.txt_NamaAwal.Size = new System.Drawing.Size(138, 23);
            this.txt_NamaAwal.TabIndex = 3;
            this.txt_NamaAwal.TextChanged += new System.EventHandler(this.txt_NamaAwal_TextChanged);
            // 
            // label_NaAk
            // 
            this.label_NaAk.AutoSize = true;
            this.label_NaAk.Location = new System.Drawing.Point(15, 105);
            this.label_NaAk.Name = "label_NaAk";
            this.label_NaAk.Size = new System.Drawing.Size(70, 15);
            this.label_NaAk.TabIndex = 4;
            this.label_NaAk.Text = "Nama Akhir";
            // 
            // txt_NamaAkhir
            // 
            this.txt_NamaAkhir.Location = new System.Drawing.Point(114, 102);
            this.txt_NamaAkhir.Name = "txt_NamaAkhir";
            this.txt_NamaAkhir.Size = new System.Drawing.Size(138, 23);
            this.txt_NamaAkhir.TabIndex = 5;
            this.txt_NamaAkhir.TextChanged += new System.EventHandler(this.txt_NamaAkhir_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(32, 144);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(36, 15);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(114, 141);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(138, 23);
            this.txt_Email.TabIndex = 7;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(114, 178);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(138, 23);
            this.txt_Pass.TabIndex = 9;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // label_ConfirmPass
            // 
            this.label_ConfirmPass.AutoSize = true;
            this.label_ConfirmPass.Location = new System.Drawing.Point(3, 215);
            this.label_ConfirmPass.Name = "label_ConfirmPass";
            this.label_ConfirmPass.Size = new System.Drawing.Size(104, 15);
            this.label_ConfirmPass.TabIndex = 10;
            this.label_ConfirmPass.Text = "Confirm Password";
            this.label_ConfirmPass.Click += new System.EventHandler(this.label_ConfirmPass_Click);
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Location = new System.Drawing.Point(114, 212);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.PasswordChar = '*';
            this.txt_ConfirmPass.Size = new System.Drawing.Size(138, 23);
            this.txt_ConfirmPass.TabIndex = 11;
            this.txt_ConfirmPass.TextChanged += new System.EventHandler(this.txt_ConfirmPass_TextChanged);
            // 
            // btn_registrasi
            // 
            this.btn_registrasi.Location = new System.Drawing.Point(114, 253);
            this.btn_registrasi.Name = "btn_registrasi";
            this.btn_registrasi.Size = new System.Drawing.Size(138, 23);
            this.btn_registrasi.TabIndex = 12;
            this.btn_registrasi.Text = "Buat akun";
            this.btn_registrasi.UseVisualStyleBackColor = true;
            this.btn_registrasi.Click += new System.EventHandler(this.btn_registrasi_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(241, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 23);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Registrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 310);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_registrasi);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.label_ConfirmPass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.txt_NamaAkhir);
            this.Controls.Add(this.label_NaAk);
            this.Controls.Add(this.txt_NamaAwal);
            this.Controls.Add(this.label_NaAw);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label_Nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrasi";
            this.Text = "Registrasi";
            this.Load += new System.EventHandler(this.Registrasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Nama;
        private TextBox txt_Username;
        private Label label_NaAw;
        private TextBox txt_NamaAwal;
        private Label label_NaAk;
        private TextBox txt_NamaAkhir;
        private Label label_email;
        private TextBox txt_Email;
        private Label label1;
        private TextBox txt_Pass;
        private Label label_ConfirmPass;
        private TextBox txt_ConfirmPass;
        private Button btn_registrasi;
        private Button btn_close;
    }
}