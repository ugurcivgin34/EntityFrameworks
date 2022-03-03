using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndEF_CodeFirst.Model
{
    public class Oyuncu
    {
        public int ID { get; set; }
        public string OyuncuAdi { get; set; }
        public DateTime DogumYili { get; set; } = DateTime.Now;

        public string Cinsiyet { get; set; }

    }
}
