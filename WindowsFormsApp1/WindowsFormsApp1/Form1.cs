using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelumur cetak = new labelumur();
            txtLabel.Text = System.Convert.ToString(cetak.label());
            txtLabel.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime UlangTahun = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                age umur = new age(UlangTahun);
                int lamahari = umur.Tahun * 365;
                int lamahari1 = umur.Bulan * 30;
                int lamahari_1 = lamahari + lamahari1 + umur.Hari;
                int lamajam = umur.Tahun * 8760;
                double lamajam1 = umur.Bulan * 730.001;
                int lamajam2 = umur.Hari * 24;
                double lamajam_t = lamajam + lamajam1 + lamajam2;
                textBox1.Text = "Anda telah hidup selama " + lamahari_1 + " Hari dan " + lamajam_t + " Jam.";
                textBox2.Text = +umur.Tahun + " Tahun";
                textBox3.Text = +umur.Bulan + " Bulan";
                textBox4.Text = +umur.Hari + " Hari";
            }
            catch (Exception)
            {
                MessageBox.Show("Telah terjadi kesalahan karena inputan Tanggal Melebihi tanggal sekarang!!! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exit fm = new Exit();
            fm.Show();
        }
    }
}
