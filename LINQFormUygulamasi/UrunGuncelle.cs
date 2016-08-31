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
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }
        NWDataContext db = new NWDataContext();

        void UrunGetir()
        {
            var sonuc = db.Products.Select(u => new { u.ProductID, u.ProductName });

            lbUrunler.DisplayMember = "ProductName";
            lbUrunler.ValueMember = "ProductID";
            lbUrunler.DataSource = sonuc;
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
             urun = db.Products.Where(u => u.ProductID == (int)lbUrunler.SelectedValue).First();//id unique olsa bile First

            txtAd.Text = urun.ProductName;
            txtFiyat.Text = urun.UnitPrice.ToString();
            txtStok.Text = urun.UnitsInStock.ToString();
        }
        Product urun = new Product();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            urun.ProductName = txtAd.Text;
            urun.UnitPrice = decimal.Parse(txtFiyat.Text);
            urun.UnitsInStock = short.Parse(txtStok.Text);
            //update konumundaki entity seçim ve değişim esnasında aynı satıra karşılık geldiğinde sadece değişikliği onaylamak yeterlidir. bu nedenle UpdateOnSubmit gibi bir metot yok.
            db.SubmitChanges();
                //submit
            //Bubble Boy 500 Dollars
            UrunGetir();
        }
    }
}
