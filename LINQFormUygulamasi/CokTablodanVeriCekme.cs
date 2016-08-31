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
    public partial class CokTablodanVeriCekme : Form
    {
        public CokTablodanVeriCekme()
        {
            InitializeComponent();
        }
        NWDataContext db = new NWDataContext();
        private void CokTablodanVeriCekme_Load(object sender, EventArgs e)
        {
            var urunBilgisi = from u in db.Products
                              from k in db.Categories
                              where u.CategoryID == k.CategoryID
                              select new
                              {
                                  u.ProductName,
                                  u.UnitsInStock,
                                  k.CategoryName
                              };

            //PK-FK ilişkisi nedeniyle Product sınıfında Category adında; Category sınıfını kullanmamızı sağlayan bir property yer alır. urun.Category kullanımı Category türünde bir entity ye karşılık gelir ve bu urun.Category.CategoryID nin k.CategoryID ile aynı bilgi olduğunu söyler. 
            var bilgi = from urun in db.Products
                        where urun.CategoryID == urun.Category.CategoryID
                        select new
                        {
                            urun.ProductName,
                            urun.UnitsInStock,
                            urun.Category.CategoryName
                        };

            dataGridView1.DataSource = bilgi;
        }
    }
}
