using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssesment2HasanFidan.cs
{
    public class Musteri
    {
        public static int BayMusteri { get; set; }
        public static int KadinMusteri { get; set; }
        public static int ToplamMusteri = KadinMusteri + BayMusteri;
        
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public bool KoltukBos { get; set; }
        public bool Cinsiyet { get; set; }
        public bool BironcekiSecim { get; set; }
    }
}
