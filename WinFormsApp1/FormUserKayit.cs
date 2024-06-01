﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class FormUserKayit : Form
    {
        
        public FormUserKayit()
        {
            InitializeComponent();
        }

        private void FormUserKayit_Load(object sender, EventArgs e)
        {
            FormUserKayit_Resize(this, EventArgs.Empty);
        }

        private void FormUserKayit_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            textBox2.Left = (this.ClientSize.Width - textBox2.Width) / 2;
            textBox1.Width = label2.Width;
            textBox2.Width = textBox1.Width;
            label3.Left = textBox1.Left;
            label4.Left = textBox2.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database2.accdb"))
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO kullaniciislemleri (userName,[password]) VALUES (@ad,@sifre)";
                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", textBox1.Text);
                        komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                        komut.ExecuteNonQuery();
                    }
                    baglanti.Close();
                }

                MessageBox.Show("kullanıcı eklendi!!");
                FormGirisEkrani formGiris = new FormGirisEkrani();
                formGiris.Show();
                this.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}