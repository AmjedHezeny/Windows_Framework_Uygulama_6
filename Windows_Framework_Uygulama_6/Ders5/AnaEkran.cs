﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5
{
    public partial class AnaEkran : Form
    {
        public AnaEkran(string kullaniciAdi)
        {
            InitializeComponent();
            label1.Text = "Hoşgeldin\n"+kullaniciAdi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f= new Form1();
            f.Show();
            this.Hide();
        }

      
    }
}
