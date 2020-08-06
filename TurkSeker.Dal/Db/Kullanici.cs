using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkSeker.Dal.Db
{
    [Table("Kullanici")]
    public partial class Kullanici:Base
    {
        [Required]
        [StringLength(50, ErrorMessage = "Kullanıcı adı 50 karakterden fazla olamaz.")]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Ad 50 karakterden fazla olamaz.")]
        public string Adi { get; set; } 
        [Required]
        [StringLength(150, ErrorMessage = "Şifre 150 karakterden fazla olamaz.")]
        public string Sifre { get; set; }  
 
        [StringLength(50, ErrorMessage = "Soyad 50 karakterden fazla olamaz.")]
        public string Soyadi { get; set; }
    }
}
