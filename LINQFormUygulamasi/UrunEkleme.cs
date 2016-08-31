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
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }
        NWDataContext db = new NWDataContext();
        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            var kat = db.Categories.Select(k => new { k.CategoryID, k.CategoryName });

            cbKategori.DisplayMember = "CategoryName";
            cbKategori.ValueMember = "CategoryID";
            cbKategori.DataSource = kat;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //insert - update - delete işlemlerinde hangi türde bir Entity ile çalışıyorsak onun sınıfından bir nesne oluşturulur

            Product urun = new Product{
                 ProductName=txtAd.Text,
                 UnitsInStock=short.Parse(txtStok.Text),
                 UnitPrice = decimal.Parse(txtFiyat.Text),
                 CategoryID =(int) cbKategori.SelectedValue
            };

            db.Products.InsertOnSubmit(urun);
            db.SubmitChanges();//insert - update - delete işlemlerinde değişikliği onaylamak zorundayız.

            txtFiyat.Clear();
            txtAd.Clear();
            txtStok.Clear();
            UrunEkleme_Load(sender, e);
        }
    }
}
