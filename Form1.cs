using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private float Penambahan(float a, float b)
        {
            return a + b;
        }
        private float Pengurangan(float a, float b)
        {
            return a - b;
        }
        private float Perkalian(float a, float b)
        {
            return a * b;
        }
        private float Pembagian(float a, float b)
        {
            return a / b;
        }

        private void Hasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = float.Parse(txtNilaiA.Text); // casting
            var b = Convert.ToInt32(txtNilaiB.Text); // casting

            if (comboBox1.SelectedIndex == 0)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Penambahan(a, b)));
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Pengurangan(a, b)));
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Perkalian(a, b)));
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Pembagian(a, b)));
            }
        }
    }
}
