﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndEF_CodeFirst.Model
{
    [Table("Yonetmenler")]
    public class Yonetmen
    {
        public int YonetmenID { get; set; }
        public string YonetmenAdi { get; set; }

        public  ICollection<Film> Filmler { get; set; }
    }
}
