using Ders5.Properties;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtParola.UseSystemPasswordChar = !txtParola.UseSystemPasswordChar;
            btnView.Image = (txtParola.UseSystemPasswordChar ? Resources.eye_off : Resources.eye_on);

            //if (txtParola.UseSystemPasswordChar)
            //{
            //    btnView.Image = Resources.eye_off;
            //}
            //else
            //{
            //    btnView.Image = Resources.eye_on;
            //}
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = Liste.Kullanicilar.FirstOrDefault(x => x.Kadi ==txtKullaniAdi.Text && x.Parola==txtParola.Text);
            if (kullanici != null) 
            {
                AnaEkran anaEkranFormu =new AnaEkran(kullanici.Kadi);
                anaEkranFormu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Kullanıcı Bilgileri Hatalı","Uyarı !!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
