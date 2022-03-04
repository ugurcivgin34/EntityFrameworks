using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndAdpp_GenericDAL.Model
{

    [Table("Yonetmenler")]
    public class Yonetmen: IEntity
    {
        public int YonetmenID { get; set; }
        public string YonetmenAdi { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }
    }
}
