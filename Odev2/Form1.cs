using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblrastgeleSayi_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblrastgeleSayi.Text = rnd.Next(10000000, 100000000).ToString();
        }

        private void txtgirilenSayi_TextChanged(object sender, EventArgs e)
        {
            txtgirilenSayi.Focus();
        }

        private void btngirisYap_Click(object sender, EventArgs e)
        {
            if (txtgirilenSayi.Text == lblrastgeleSayi.Text)
            {
                MessageBox.Show("Giriş Yapıldı");
            }
            else
            {
                int hak = int.Parse(lblkalanHak.Text);
                hak -= 1;
                lblkalanHak.Text = hak.ToString();
                txtgirilenSayi.Clear();
                MessageBox.Show("Girdiğiniz sayı yanlış, lütfen tekrar deneyiniz.");

                if (hak == 0)
                {
                    btngirisYap.Enabled = false;
                    txtgirilenSayi.Enabled = false;
                }
                else
                {

                }
            }

            Random rnd = new Random();
            lblrastgeleSayi.Text = rnd.Next(10000000, 100000000).ToString();
        }
    }
}
