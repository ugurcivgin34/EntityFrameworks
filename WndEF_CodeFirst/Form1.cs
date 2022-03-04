using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WndEF_CodeFirst.DAL;
using WndEF_CodeFirst.Model;

namespace WndEF_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilmDB db = new FilmDB();
        private void Form1_Load(object sender, EventArgs e)
        {
          
          //
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //var liste = from f in db.Filmler
            //            select new
            //            {
            //                f.FilmID,
            //                Ad = f.FilmAdi,
            //                f.Kategori.KategoriAdi,
            //                f.Yonetmen.YonetmenAdi
            //            };
            var liste = db.Filmler.ToList();
            dataGridView1.DataSource = liste.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Model de Navigation Prop. önünde "virtual" olup olmamasına göre çalışması değişir..
            var liste = db.Filmler.Include("Kategori").Include("Yonetmen").ToList();
            dataGridView1.DataSource = liste.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Kategoriler.Add(new Kategori { KategoriAdi = "Animasyon" });
            db.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var film1 = db.Filmler.Find(1);
            var film2 = db.Filmler.Where(f => f.FilmID == 1).SingleOrDefault();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kategori kat = db.Kategoriler.Find(5);
            db.Kategoriler.Remove(kat);
            db.SaveChanges();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var kat = db.Kategoriler.Find(3);
            db.Entry<Kategori>(kat).State = System.Data.Entity.EntityState.Modified;
            kat.KategoriAdi = "Eğlence";

            db.SaveChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strAra = textBox1.Text;
            var result = db.Filmler.Where(f => f.FilmAdi.Contains(strAra));
            dataGridView1.DataSource = result.ToList();
        }
    }
}
