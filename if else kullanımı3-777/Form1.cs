using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_kullanımı3_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            float sayi1 = Convert.ToSingle(txtSayi1.Text);
            float sayi2 = Convert.ToSingle(txtSayi2.Text);
            float sonuc = 0; 

            if (rbTopla.Checked)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (rbCikar.Checked)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (rbCarp.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (rbBol.Checked)
            {
                sonuc = sayi1 / sayi2;
            }
            lblSonuc.Text = sonuc.ToString();
        }
    }
}
