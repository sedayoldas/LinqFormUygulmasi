using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQFormUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NWDataContext db = new NWDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var kategoriler = from kategori in db.Categories
                              select new
                              {
                                  kategori.CategoryID,
                                  kategori.CategoryName
                              };

            var kat = db.Categories.Select(k => new { k.CategoryID, k.CategoryName });//lambda belirli kolonların bilgisini çekme

            cbKategori.DisplayMember = "CategoryName";
            cbKategori.ValueMember = "CategoryID";
            cbKategori.DataSource = kat;
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kategoriUrunleri = db.Products
                .Where(u => u.CategoryID == (int)cbKategori.SelectedValue);

            gvUrun.DataSource = kategoriUrunleri;
        }

        private void çokluVeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CokTablodanVeriCekme frm = new CokTablodanVeriCekme();
            frm.ShowDialog();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkleme frm = new UrunEkleme();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void güncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelle frm = new UrunGuncelle();
            frm.ShowDialog();
        }

        private void silmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSilme frm = new UrunSilme();
            frm.ShowDialog();
        }
    }
}
