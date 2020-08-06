using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkSeker.Dal.Db
{
    public partial class Base
    {
        public Base()
        {
            IlkKayitIP = "127.0.0.1";
            IlkKayitTarihi = new DateTime(2018, 1, 1);
            IlkKayitKullaniciID = 0;
            Silindi = false;
            Guid = System.Guid.NewGuid().ToString().ToUpper();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int ID { get; set; }

         [Column(Order = 2)]
        [StringLength(50, ErrorMessage = "GUID 50 karakterden fazla olamaz.")]
        public string Guid { get; set; }

        [Column(Order = 3)]
         
        [StringLength(50, ErrorMessage = "IP adresi 50 karakterden fazla olamaz.")]
        public string IlkKayitIP { get; set; }

        [Column(Order = 4)]
        public DateTime IlkKayitTarihi { get; set; }

        [Column(Order = 5)]
        public int IlkKayitKullaniciID { get; set; }

        [Column(Order = 6)]
        [StringLength(50, ErrorMessage = "IP adresi 50 karakterden fazla olamaz.")]
        public string SonKayitIP { get; set; }

        [Column(Order = 7)]
        public DateTime? SonKayitTarihi { get; set; }

        [Column(Order = 8)]
        public int? SonKayitKullaniciID { get; set; }

        [Column(Order = 9)]
        public bool? Silindi { get; set; }

    }
}
