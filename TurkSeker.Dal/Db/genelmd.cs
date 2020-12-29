using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkSeker.Dal.Db
{
    [Table("genelmd")]
    public partial class genelmd
    {
        [Key]
        public int Id { get; set; }
        public int? FabrikaId { get; set; }  
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
