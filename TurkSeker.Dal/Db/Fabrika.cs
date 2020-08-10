using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurkSeker.Dal.Db
{
    [Table("Fabrika")]
    public partial class Fabrika
    {
        [Key]
        public int Id { get; set; }
        public string FabrikaAdi { get; set; }
        public string Resim { get; set; }
        public virtual ICollection<genelmd> Genelmds { get; set; }



    }
}
