using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UncleSoftware
{
    public partial class frmSeleniumTests : Form
    {
        public frmSeleniumTests()
        {
            InitializeComponent();
        }

        Testler tst = new Testler();
        private void buttonProfil_Click(object sender, EventArgs e)
        {
            tst.ProfilBilgileriniGoruntule();
            MessageBox.Show("Test başarılı!!","Test Durumu..");
        }

        private void buttonBilgiDuzen_Click(object sender, EventArgs e)
        {
            tst.ProfilBilgileriniDuzenleme();
            MessageBox.Show("Test başarılı!!","Test Durumu..");
        }

        private void buttonHesapCikis_Click(object sender, EventArgs e)
        {
            tst.HesaptanCikisYapma();
            MessageBox.Show("Test başarılı!!","Test Durumu..");
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            tst.YeniKayitOlusturma();
            MessageBox.Show("Test başarılı!!", "Test Durumu..");
        }
    }
}
