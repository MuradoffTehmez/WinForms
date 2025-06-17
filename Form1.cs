using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private List<string[]> melumatlar = new List<string[]>();

        private void btnElaveEt_Click(object sender, EventArgs e)
        {

            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string dogum = textBoxDogumTarixi.Text;
            string olke = textBoxOlke.Text;

            string[] melumat = new string[] { ad, soyad, dogum, olke };
            melumatlar.Add(melumat);
            comboBox1.Items.Add(ad + " " + soyad);
            MessageBox.Show("Əlavə olundu: " + melumatlar.Count + " nəfər");

            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxDogumTarixi.Clear();
            textBoxOlke.Clear();
            textBoxAd.Focus();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= 0 && index < melumatlar.Count)
            {
                string[] secilmis = melumatlar[index];
                textBoxAd.Text = secilmis[0];
                textBoxSoyad.Text = secilmis[1];
                textBoxDogumTarixi.Text = secilmis[2];
                textBoxOlke.Text = secilmis[3];
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
