using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndEF_DBFIRST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapDBEntities db = new KitapDBEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Kitaplar.ToList();

            //db.Database.Log = Mesaj;

            dataGridView2.DataSource = db.Database.SqlQuery<Kategoriler>("SELECT * FROM Kategoriler").ToList<Kategoriler>();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Kitaplar.Add(new Kitaplar
            {
                KitapAdi = "Harry Potter",
                KategoriID = 2,
                YazarID = 2,
            });
            db.SaveChanges();
        }

        public void Mesaj(String str)
        {
            MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var result = from k in db.Kitaplar
            //             join kat in db.Kategoriler
            //             on k.KategoriID equals kat.KategoriID
            //             select new { k.KategoriID, k.KitapAdi, kat.KategoriAdi };
            //dataGridView1.DataSource = result.ToList();

            //lazy loading
            var result = from k in db.Kitaplar
                         select new { k.KitapId, k.KitapAdi, k.Kategoriler.KategoriAdi };//navigation property

            dataGridView1.DataSource = result.ToList();


        }
    }
}

