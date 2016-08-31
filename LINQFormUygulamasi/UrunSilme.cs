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
    public partial class UrunSilme : Form
    {
        public UrunSilme()
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
        private void UrunSilme_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db = new NWDataContext();
            try
            {
                Product urun = db.Products.Where(u => u.ProductID == (int)lbUrunler.SelectedValue).First();

                db.Products.DeleteOnSubmit(urun);
                db.SubmitChanges();
                UrunGetir();
            }
            catch
            {
                MessageBox.Show("Ürünün silinmesi engellendi.");
            }
        }
    }
}
