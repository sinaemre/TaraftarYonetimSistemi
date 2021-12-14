using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaraftarYonetimSistemi.Data;

namespace TaraftarYonetimSistemi
{
    public partial class Form1 : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        public Form1()
        {
            InitializeComponent();
            TakimlariListele();
        }

        private void TakimlariListele()
        {
            cboTuttuguTakim.DataSource = db.Takimlar.ToList();
            var takimlistesi = db.Takimlar.ToList();
            takimlistesi.Insert(0, new Takim()
            {
                Ad = "Takımı yok",
                Taraftarlar = db.Kisiler.Where(k => k.TakimId == null).ToList()
            });
            cboTakim.DataSource = takimlistesi;
            cboYeniTakim.DataSource = db.Takimlar.ToList();

        }

        private void cboTakim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTakim.SelectedIndex == -1)
            {
                lstTaraftarlar.DataSource = null;
                return;
            }
            else
            {
                Takim takim = (Takim)cboTakim.SelectedItem;
                lstTaraftarlar.DataSource = takim.Taraftarlar.ToList();
            }
        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            string takimAd = txtTakimAd.Text.Trim();

            if (takimAd == "") return;

            db.Takimlar.Add(new Takim() { Ad = takimAd });
            db.SaveChanges();
            txtTakimAd.Clear();
            TakimlariListele();

        }

        private void chkTakimTutmuyor_CheckedChanged(object sender, EventArgs e)
        {
            cboTuttuguTakim.Enabled = !chkTakimTutmuyor.Checked;
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Takim takim = (Takim)cboTuttuguTakim.SelectedItem;
            string kisiAd = txtKisiAd.Text.Trim();
            
            if (kisiAd == "" || !chkTakimTutmuyor.Checked && takim == null) return;

            Kisi kisi = new Kisi()
            {
                Ad = kisiAd,
                Takim = chkTakimTutmuyor.Checked ? null : takim
            };

            db.Kisiler.Add(kisi);
            db.SaveChanges();
            txtKisiAd.Clear();
            TakimlariListele();
        }

        private void btnTakimiSil_Click(object sender, EventArgs e)
        {
            Takim takim = (Takim)cboTakim.SelectedItem;
            if (takim == null || takim.Id == 0) return;

            db.Takimlar.Remove(takim);
            db.SaveChanges();
            TakimlariListele();
        }

        private void btnTakimdanCikar_Click(object sender, EventArgs e)
        {
            Takim takim = (Takim)cboTakim.SelectedItem;
            Kisi taraftar = (Kisi)lstTaraftarlar.SelectedItem;

            if (takim == null || taraftar == null || takim.Id == 0) return;

            //taraftar.TakimId = null;
            takim.Taraftarlar.Remove(taraftar);
            db.SaveChanges();
            TakimlariListele();
        }

        private void btnTakimDegistir_Click(object sender, EventArgs e)
        {
            Kisi taraftar = (Kisi)lstTaraftarlar.SelectedItem;
            Takim yeniTakim = (Takim)cboYeniTakim.SelectedItem;

            if (taraftar == null || yeniTakim == null) return;

            taraftar.Takim = yeniTakim;
            db.SaveChanges();
            TakimlariListele();
        }
    }
}
