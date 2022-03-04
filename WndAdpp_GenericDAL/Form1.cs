using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WndAdpp_GenericDAL.BLL;
using WndAdpp_GenericDAL.DAL;
using WndAdpp_GenericDAL.Model;

namespace WndAdpp_GenericDAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GnFilmDB db = new GnFilmDB();
            GnBLL<Film> film = new GnBLL<Film>(db);

            dataGridView1.DataSource = film.Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GnFilmDB db = new GnFilmDB();
            GnBLL<Kategori> kat = new GnBLL<Kategori>(db);

            Kategori kategori = new Kategori() { KategoriAdi ="Uzay"};
            kat.Ekle(kategori);

            dataGridView1.DataSource = kat.Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GnFilmDB db = new GnFilmDB();
            GnBLL<Yonetmen> yon = new GnBLL<Yonetmen>(db);
            Yonetmen yonetmen = new Yonetmen() { YonetmenAdi = "Tarantino" };
            yon.Ekle(yonetmen);

            dataGridView1.DataSource = yon.Liste();
        }
    }
}
