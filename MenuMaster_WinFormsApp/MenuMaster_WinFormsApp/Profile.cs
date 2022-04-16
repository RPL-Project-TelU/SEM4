﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaster_WinFormsApp
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) | String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox1.Text) | String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text) | String.IsNullOrEmpty(textBox5.Text))
                {
                    throw new Exception("Text tidak boleh NULL");
                }
                else
                {
                    MessageBox.Show("Data Berhasil disimpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama objUI = new MenuUtama();
            objUI.ShowDialog();
            this.Close();
            
        }

        
    }
}
