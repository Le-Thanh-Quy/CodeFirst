using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5B.DTO
{
    [Table("LopSinhHoat")]
    public class LSH
    {
        [Key]
        public int IDLop { get; set; }
        public string TenLop { get; set; }

        public LSH()
        {
            SV = new HashSet<SV>();
        }
        public virtual ICollection<SV> SV { get; set; }
    }
}
