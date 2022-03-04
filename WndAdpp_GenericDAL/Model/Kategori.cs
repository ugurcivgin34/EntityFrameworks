using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndAdpp_GenericDAL.Model
{

    [Table("Kategoriler")]
    public class Kategori: IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        //lazy loading
        public virtual ICollection<Film> Filmler { get; set; }


    }
}
