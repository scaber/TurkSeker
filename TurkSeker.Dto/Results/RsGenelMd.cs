using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkSeker.Dal.Db;

namespace TurkSeker.Dto.Results
{
   public class RsGenelMd
    {
        public int Id { get; set; }
        public int? FabrikaId { get; set; }
        public string FabrikaAdi{ get; set; }
        public DateTime? Kayit_tar_saat { get; set; }
        public double? Kiyim1_anlik_ton { get; set; }
        public double? Kiyim2_anlik_ton { get; set; }
        public double? Kiyim3_anlik_ton { get; set; }
        public double? Ham_bek_sek { get; set; }
        public double? Raf_bek_sek { get; set; }
        public double? Top_bek_sek { get; set; }
        public double? Bugun_cik_sek { get; set; }
        public double? Dun_cik_sek { get; set; }
        public double? Bugun_kes_pan { get; set; }
        public double? Dun_kes_pan { get; set; }
        public double? Kiyim_polu { get; set; }
        public double? ToplamPancar { get; set; }
        public double? BugunGelenPancar { get; set; }
        public double? KantardakiPancar { get; set; }
    }
}
