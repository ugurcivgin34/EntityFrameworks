using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndEF_CodeFirst.Model
{
    [Table("Kategoriler")]
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        //lazy loading
        public  ICollection<Film> Filmler { get; set; }
        

    }
}
