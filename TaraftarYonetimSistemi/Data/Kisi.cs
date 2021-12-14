using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaraftarYonetimSistemi.Data
{
    [Table("Kisiler")]
    public class Kisi
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        public int? TakimId { get; set; }

        public virtual Takim Takim { get; set; }
    }
}
