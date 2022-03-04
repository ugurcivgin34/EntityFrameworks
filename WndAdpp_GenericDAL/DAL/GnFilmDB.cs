using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndAdpp_GenericDAL.Model;

namespace WndAdpp_GenericDAL.DAL
{
    public class GnFilmDB:DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
    }
}
