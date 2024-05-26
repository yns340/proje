﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            ResizePictureBox();
            button1.Height = label1.Height;
            button1.Width = label1.Height;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            ResizePictureBox();
            button1.Height = label1.Height;
            button1.Width = label1.Height;

            int button2middle = this.ClientSize.Width / 4;
            int button3middle = (3 * (this.ClientSize.Width)) / 4;

            button2.Left = button2middle - (button2.Width / 2);
            button3.Left = button3middle - (button3.Width / 2);

            label2.Width = button2.Width;
            label2.Top = button2.Bottom;
            label2.Left = button2middle - (label2.Width / 2);

            label3.Width = button3.Width;
            label3.Top = button3.Bottom;
            label3.Left = button3middle - (label3.Width / 2);
        }

        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void ResizePictureBox()
        {
            pictureBox1.ClientSize = this.ClientSize;
        }


        private void button1Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ClientSize = this.ClientSize;

            if (this.WindowState == FormWindowState.Maximized)
            {
                form1.WindowState = FormWindowState.Maximized;
            }

            this.Hide();
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
