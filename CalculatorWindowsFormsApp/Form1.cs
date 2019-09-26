using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Penambahan { get; set; }
        public int Pengurangan { get; set; }
        public int Perkalian { get; set; }
        public int Pembagian { get; set; }

        private int getPenambahan(int a, int b)
        {
            return a + b;
        }

        private int getPengurangan(int a, int b)
        {
            return a - b;
        }

        private int getPerkalian(int a, int b)
        {
            return a * b;
        }

        private int getPembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); // casting 
            var b = Convert.ToInt32(txtNilaiB.Text); // casting 

            IstHasil.Items.Clear();

            //tampilkan hasil semua hasil panggilan methode calculator ke dalam listbox 
            /*IstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            IstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            IstHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b)));
            IstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b)));
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = Penambahan;
        }
    }
}
